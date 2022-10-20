using System.Collections;
using System.Collections.Generic;

namespace LetsTalk.Models
{
    public sealed class Chat
    {

        public Chat()
        {
            ChatUser = new List<ChatUser>();
            Messages = new List<Message>();
        }
        public int Id { get; set; }
        public ICollection<Message> Messages  { get; set; }
        public ICollection<ChatUser> ChatUser  { get; set; }

        public ChatType Type { get; set; }

        public string Name { get; set; }
    }
    
}