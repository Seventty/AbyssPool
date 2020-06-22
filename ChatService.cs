using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AbyssPoolCH
{
    public class ChatService : ICharServices
    {
        public ChatUser ClientConnect(string userName)
        {
            throw new NotImplementedException();
        }

        public List<ChatUser> GetAllusers()
        {
            throw new NotImplementedException();
        }

        public List<ChatMessage> GetNewMessages(ChatUser user)
        {
            throw new NotImplementedException();
        }

        public void RemoveChatUser(ChatUser user)
        {
            throw new NotImplementedException();
        }

        public void SendNewMessage(ChatMessage Newmessage)
        {
            throw new NotImplementedException();
        }
    }
}
