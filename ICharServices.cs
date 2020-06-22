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
        [OperationContract]
        ChatUser ClientConnect(string userName);

        [OperationContract]
        List<ChatMessage> GetNewMessages(ChatUser user);

        [OperationContract]
        void SendNewMessage(ChatMessage Newmessage);

        [OperationContract]
        List<ChatUser> GetAllusers();

        [OperationContract]
        void RemoveChatUser(ChatUser user);
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

    public class ChatMessage
    {
        private ChatUser user;
        private string message;
        private DateTime date;

        public ChatUser User { get => user; set => user = value; }
        public string Message { get => message; set => message = value; }
        public DateTime Date { get => date; set => date = value; }
    }

}
