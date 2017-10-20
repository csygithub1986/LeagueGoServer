using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;


namespace LeagueGoServer
{
    [ServiceContract]
    public interface ICallBack
    {
        #region 客户端使用

        /// <summary>
        /// 向客户端发送强制下线信息
        /// </summary>
        /// <param name="Msg">信息</param>
        [OperationContract(IsOneWay = true)]
        void ClientOffline(string Msg);
        #endregion

    }
}
