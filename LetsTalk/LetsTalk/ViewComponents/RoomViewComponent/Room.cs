using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using LetsTalk.Data;
using LetsTalk.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LetsTalk.ViewComponents.Room
{
    
    public class Room : ViewComponent
    {
        private readonly AppDbContext _context;

        public Room(AppDbContext _context)
        {
            this._context = _context;
        }
        
        
        public IViewComponentResult Invoke()
        {
            var chats =  _context.ChatUser
                .Include(user => user.Chat)
                .Where(user => user.Chat.Type == ChatType.Room &&
                               user.UserId == HttpContext.User.FindFirst(ClaimTypes.NameIdentifier ).Value)
                .Select(user => user.Chat).ToList();
            return View(chats);
        }
    }
}