using System;
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

namespace LeagueGoServer
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“Service1”。
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Multiple, UseSynchronizationContext = false)]
    public partial class WcfService : IWcfService
    {
        public List<GameConfig> ClientGetAllAccount()
        {
            throw new NotImplementedException();
        }

        public int ClientHeartbeat()
        {
            throw new NotImplementedException();
        }

        //客户端登录
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
            ICallBack callBack = OperationContext.Current.GetCallbackChannel<ICallBack>();
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

        private void ClientChannel_Closing(object sender, EventArgs e)
        {
            ClientInfo info = GetClientInfo((ICallBack)sender);
            if (info == null)
                return;
            Common.ClientListDelete(info.SessionID);
        }

        /// <summary>
        /// 查询某个回调对应的用户
        /// </summary>
        public ClientInfo GetClientInfo(ICallBack callBack)
        {
            foreach (var info in Common.ClientList)
            {
                if (info.Value.ClientCallback == callBack)
                    return info.Value;
            }
            return null;
        }
    }


}
