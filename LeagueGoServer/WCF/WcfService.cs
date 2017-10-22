﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Collections;
using System.ServiceModel.Channels;

using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using LeagueGoServer.Model;
using System.Threading.Tasks;

namespace LeagueGoServer
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“Service1”。
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Multiple, UseSynchronizationContext = false)]
    public partial class WcfService : IWcfService
    {
        /// <summary>
        /// 客户端登录
        /// 登录以后，给客户端发送所有游戏信息
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public int Login(string userName)
        {
            string ssid = OperationContext.Current.SessionId;
            //获取传进的消息属性  
            MessageProperties properties = OperationContext.Current.IncomingMessageProperties;
            //获取消息发送的远程终结点IP和端口  
            RemoteEndpointMessageProperty endpoint = properties[RemoteEndpointMessageProperty.Name] as RemoteEndpointMessageProperty;
            string ip = endpoint.Address;
            int port = endpoint.Port;
            Console.WriteLine(userName + " " + ssid + " " + ip + " " + port);

            //将此用户加入集合
            ICallback callBack = OperationContext.Current.GetCallbackChannel<ICallback>();
            //添加客户端信息到客户端集合
            ClientInfo _info = new ClientInfo();
            _info.SessionID = ssid;
            _info.UserName = userName;
            _info.ClientCallback = callBack;
            _info.ClientChannel = OperationContext.Current.Channel;
            _info.HeartbeatTime = DateTime.Now;
            Common.ClientListAdd(ssid, _info);

            OperationContext.Current.Channel.Closing += new EventHandler(ClientChannel_Closing);
            return 0;
        }

        /// <summary>
        /// 新建游戏
        /// </summary>
        /// <param name="players"></param>
        /// <param name="gameSettign"></param>
        public void CreateGame(Player[] players, GameSetting gameSettign)
        {
            //收到请求后，1、如果Host或Realboard在玩家列表里，添加Client信息。
            //2、添加游戏列表
            //3、给所有client发送消息
            string sessionID = OperationContext.Current.SessionId;
            ClientInfo client = Common.ClientListGet(sessionID);
            foreach (Player player in players)
            {
                //除了Internet，其他三个，AI、Realboard、Host的连接都是Host本身的连接
                if (player.Type != PlayerType.Internet)
                {
                    player.Client = client;
                }
            }

            Game game = new Game() { Name = gameSettign.Name, GameID = sessionID, Players = players, GameSetting = gameSettign };
            Common.GameList.TryAdd(sessionID, game);

            foreach (ClientInfo c in Common.ClientList.Values)
            {
                //if (c.PlayingState == ClientState.Idel)
                //{
                Task.Factory.StartNew(() =>
                 {
                     ICallback callback = c.ClientCallback;
                     callback.AddNewGame(game);
                 });
                //}
            }
        }

        /// <summary>
        /// 用户申请加入游戏
        /// 成功后调用callback给所有用户推送结果
        /// </summary>
        /// <param name="gameID"></param>
        /// <param name="playerID"></param>
        /// <returns>成功返回true，失败返回false（例如申请的game或player刚刚被占用或失效了）</returns>
        public void ApplyToJoinGame(string gameID, int playerID)
        {
            string sessionID = OperationContext.Current.SessionId;
            ClientInfo currentClient = Common.ClientListGet(sessionID);
            if (Common.GameList.ContainsKey(gameID))
            {
                lock (Common.GameList[gameID])//???????????????????想要锁住Game对象的状态，是否可以这么用？
                {
                    if (Common.GameList[gameID].State == GameState.Waiting)
                    {
                        Player player = Common.GameList[gameID].Players.FirstOrDefault(p => p.ID == playerID);
                        if (player != null && player.Client == null)//后者判断此player位置还未被占用
                        {

                            player.Client = currentClient;
                            foreach (var client in Common.ClientList.Values)
                            {
                                client.ClientCallback.ReturnApplyGameResult(true, Common.GameList[gameID]);
                            }
                            return;
                        }
                    }
                }
            }
            //如果没有成功
            currentClient.ClientCallback.ReturnApplyGameResult(false, null);
        }

        /// <summary>
        /// Host发送开始命令，转发给game中的player，并启动游戏
        /// </summary>
        public void GameStart()
        {
            string sessionID = OperationContext.Current.SessionId;
            ClientInfo currentClient = Common.ClientListGet(sessionID);
            Game game = Common.GameList[sessionID];
            //Host和其他的internet玩家分开发送
            foreach (var player in Common.GameList[sessionID].Players)
            {
                if (player.Client != null && player.Client != currentClient)
                {
                    player.Client.ClientCallback.SendGameStart(game.BlackPlayerIDs.Select(p => p.ID).ToArray(), game.WhitePlayerIDs.Select(p => p.ID).ToArray(), game.CurrentPlayer.ID);
                }
            }
            currentClient.ClientCallback.SendGameStart(game.BlackPlayerIDs.Select(p => p.ID).ToArray(), game.WhitePlayerIDs.Select(p => p.ID).ToArray(), game.CurrentPlayer.ID);
        }

        public void ClientCommitMove(int stepNum, int x, int y)
        {
            string sessionID = OperationContext.Current.SessionId;
            ClientInfo currentClient = Common.ClientListGet(sessionID);
            Game game = Common.GameList[sessionID];
            if (game.CurrentPlayer.Client!=currentClient||game.StepNum!=stepNum)
            {
                //不是应该提交的client提交了数据，错误。 TODO:记录日志
                return;
            }
            game.DealArrivedMove(x, y);
            game.DistributeNextMove();
        }

        #region 私有方法
        private void ClientChannel_Closing(object sender, EventArgs e)
        {
            ClientInfo info = GetClientInfo((ICallback)sender);
            if (info == null)
                return;
            Common.ClientListDelete(info.SessionID);
        }

        /// <summary>
        /// 查询某个回调对应的用户
        /// </summary>
        private ClientInfo GetClientInfo(ICallback callBack)
        {
            foreach (var info in Common.ClientList)
            {
                if (info.Value.ClientCallback == callBack)
                    return info.Value;
            }
            return null;
        }
        #endregion
    }
}
