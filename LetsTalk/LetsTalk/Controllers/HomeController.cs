using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using LetsTalk.Data;
using LetsTalk.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LetsTalk.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext _context)
        {
            this._context = _context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var chats = _context.Chat
                .Include(chat => chat.ChatUser)
                .Where(chat => !chat.ChatUser
                    .Any(user => user.UserId == User.FindFirst(ClaimTypes.NameIdentifier).Value)).ToList();

            return View(chats);
        }

        public IActionResult Find()
        {
            var users =  _context.User.Where(user => user.Id != User.FindFirst(ClaimTypes.NameIdentifier).Value)
                .ToList();

            return View(users);
        }
        
        public IActionResult Private()
        {
            var chats = _context.Chat
                .Include(chat => chat.ChatUser)
                .ThenInclude(user =>user.User)
                .Where(chat => chat.Type == ChatType.Private
                && chat.ChatUser.Any(user => user.UserId == User.FindFirst(ClaimTypes.NameIdentifier).Value))
                .ToList();

            return View(chats);
        }
        
        public async Task<IActionResult> CreatePrivateRoom(string userId)
        {
            var chat = new Chat()
            {
                Type = ChatType.Private
            };
            
            chat.ChatUser.Add(new ChatUser()
            {
                UserId = userId
            });
            
            chat.ChatUser.Add(new ChatUser()
            {
                UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value
            });

            _context.Chat.Add(chat);

            await _context.SaveChangesAsync();

            return RedirectToAction("Chat", new
            {
                id = chat.Id
            });
        }


        [HttpPost]
        public async Task<IActionResult> CreateMessage(int chatId, string messageBody)
        {
            var message = new Message()
            {
                ChatId = chatId,
                Text = messageBody,
                Name = User.Identity.Name,
                CreatedAt = DateTime.Now
            };

            _context.Message.Add(message);

            await _context.SaveChangesAsync();

            return RedirectToAction("Chat", new { id = chatId });
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Chat(int id)
        {
            var chat = await _context.Chat.Include(chat1 => chat1.Messages)
                .FirstOrDefaultAsync(chat1 => chat1.Id == id);
            return View(chat);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRoom(string name)
        {
            var chat = new Chat()
            {
                Name = name,
                Type = ChatType.Room,
            };

            _context.Chat.Add(chat);

            chat.ChatUser.Add(new ChatUser()
            {
                Role = UserRole.Admin,
                UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value
            });

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> JoinRoom(int id)
        {
            var chatUser = new ChatUser()
            {
                ChatId = id,
                Role = UserRole.Member,
                UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value
            };

            _context.ChatUser.Add(chatUser);

            await _context.SaveChangesAsync();

            return RedirectToAction("Chat", "Home", new { id = id });
        }
    }
}