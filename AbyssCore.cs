using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbyssPoolCH
{
   
    public class AbyssCore
    {
        private Dictionary<string, List<ChatMessage>> incomingMessages = new Dictionary<string, List<ChatMessage>>();
        private List<ChatUser> connectedUsers = new List<ChatUser>();

        public List<ChatUser> ConnectedUsers { get => connectedUsers; set => connectedUsers = value; }

        public ChatUser addNewChatUser(ChatUser newUser)
        {
            var exists = from ChatUser e in this.connectedUsers where e.UserName == newUser.UserName select e;

            if(exists.Count() == 0)
            {

            }
        }
    }
}
