using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using System.IO;
using LeagueGoServer.Model;

namespace LeagueGoServer
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IService1”。
    [ServiceContract(CallbackContract = typeof(ICallBack), SessionMode = SessionMode.Required)]
    public interface IWcfService
    {
        ///// <summary>
        ///// 客户端心跳触发
        ///// </summary>
        //[OperationContract]
        //int ClientHeartbeat();


        ///// <summary>
        ///// 获取所有账号信息
        ///// </summary>
        ///// <returns></returns>
        //[OperationContract]
        //List<GameConfig> ClientGetAllAccount();

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        [OperationContract]
        int Login(string userName);


        [OperationContract]
        void CreateGame(Player[] players,GameSetting gameSettign);
    }
}
