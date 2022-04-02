using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcf_chat
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceChat" in both code and config file together.
    public class ServiceChat : IServiceChat
    {
        public int Connect()
        {
            throw new NotImplementedException();
        }

        public void Disconnect()
        {
            throw new NotImplementedException();
        }

        public void DoWork()
        {
        }

        public void SendMessage(string message)
        {
            throw new NotImplementedException();
        }
    }
}
