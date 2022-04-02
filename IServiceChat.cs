using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcf_chat
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceChat" in both code and config file together.
    [ServiceContract(CallbackContract = typeof(IServerChatCallBack))]
    public interface IServiceChat
    {

        [OperationContract]
        int Connect();

        [OperationContract]
        void Disconnect();

        [OperationContract(IsOneWay = true)]
        void SendMessage(string message);

    }

    public interface IServerChatCallBack
    {
        void MessageCallBack(string msg);

    }
}
