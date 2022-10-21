using System;

namespace LetsTalk.Models
{
    public sealed class Message
    {
        public int Id { get; set; }

        public string Name { get; set; }    
        
        public string Text { get; set; }
        
        public long TextLength { get; set; }

        public int ChatId { get; set; }
        public Chat Chat { get; set; }
        
        public DateTime CreatedAt { get; set; }      
    }
}