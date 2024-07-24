using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatroomOnLAN
{
    public class Chatroom
    {
        public static Dictionary<int, Chatroom> OpenChatrooms = new Dictionary<int, Chatroom>();
        public int Port { get; set; }
        public string Owner { get; set; }

        public Chatroom(int Port, string Owner) {
            // Create the chatroom etc.
            this.Port = Port;
            this.Owner = Owner;

            // Add to OpenChatrooms list
            OpenChatrooms.Append(new KeyValuePair<int, Chatroom>(Port, this));
        }
    }
}
