using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace LetsTalk.Models
{
    public  class User : IdentityUser
    {
        public ICollection<ChatUser> ChatUser { get; set; }

        public bool IsOnline { get; set; }
    }
}