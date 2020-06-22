using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AbyssPoolCH
{
    [ServiceContract]
    public interface ICharServices
    {

    }

    [DataContract]
    public class ChatUser
    {
        private string userName, hostName, ipAddress;

        [DataMember]
        public string IpAddress { get => ipAddress; set => ipAddress = value; }
        [DataMember]
        public string HostName { get => hostName; set => hostName = value; }
        [DataMember]
        public string UserName { get => userName; set => userName = value; }
    }

}
