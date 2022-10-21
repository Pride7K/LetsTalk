using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using LetsTalk.Data;
using LetsTalk.Dtos.HomeControllerDto;
using LetsTalk.Extension.Methods;
using LetsTalk.Hubs;
using LetsTalk.Models;
using LetsTalk.Repositories.ChatService;
using LetsTalk.Repositories.MessageService;
using LetsTalk.Repositories.UserService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace LetsTalk.Controllers
{
    [Authorize]
    [ApiController]
    [Route("Home")]
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IChatRepository _chatRepository;
        private readonly IMessageRepository _messageRepository;
        private readonly IUserRepository _userRepository;
        public HomeController(AppDbContext _context,
            IChatRepository _chatRepository,
            IMessageRepository _messageRepository,
            IUserRepository _userRepository)
        {
            this._context = _context;
            this._chatRepository = _chatRepository;
            this._messageRepository = _messageRepository;
            this._userRepository = _userRepository;
        }

        [HttpGet("Index")]
        public async Task<IActionResult> Index(CancellationToken token)
        {
            var chats = await _chatRepository.GetRoomsExceptRoomsThatSpecificUserHas(User.GetUserId(),token);

            return View(chats);
        }

        [HttpGet("Find")]
        public async Task<IActionResult> Find(CancellationToken token)
        {
            var users = await _userRepository.GetUsersExceptSpecificUser(User.GetUserId(),token);

            return View(users);
        }
        [HttpPost("Report")]
        public async Task<IActionResult> Report([FromForm] string startDateTimeCut,[FromForm] string endDateTimeCut)
        {
            var result = await _messageRepository.GetReport(DateTime.ParseExact(startDateTimeCut,"yyyy-MM-dd",CultureInfo.InvariantCulture),
                DateTime.ParseExact(endDateTimeCut,"yyyy-MM-dd",CultureInfo.InvariantCulture));

            return View(result);
        }
        
        [HttpGet("Report")]
        public async Task<IActionResult> Report()
        {
            return View();
        }
        

        [HttpGet("Private")]
        public async Task<IActionResult> Private(CancellationToken token)
        {
            var chats = await _chatRepository.GetPrivateRooms(User.GetUserId(),token);

            return View(chats);
        }
        [HttpGet("CreatePrivateRoom")]
        public async Task<IActionResult> CreatePrivateRoom(string userId, CancellationToken token)
        {
            var chat = await _chatRepository.CreatePrivateRoom(userId, User.GetUserId(),token);

            return RedirectToAction("Chat", new
            {
                id = chat.Id
            });
        }


        [HttpPost("CreateMessage")]
        public async Task<IActionResult> CreateMessage([FromForm] int chatId, [FromForm] string messageBody, CancellationToken token)
        {
            await _messageRepository.CreateMessage(chatId, messageBody, User.Identity.Name,token);

            return RedirectToAction("Chat", new { id = chatId });
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Chat(int id, CancellationToken token)
        {
            var chat = await _chatRepository.GetChatById(id,token);
            return View(chat);
        }

        [HttpPost("CreateRoom")]
        public async Task<IActionResult> CreateRoom([FromForm] string name, CancellationToken token)
        {
            await _chatRepository.CreateRoom(name, User.GetUserId(),token);

            return RedirectToAction("Index");
        }

        [HttpGet("JoinRoom")]
        public async Task<IActionResult> JoinRoom(int id, CancellationToken token)
        {
            await _chatRepository.JoinRoom(id, User.GetUserId(),token);

            return RedirectToAction("Chat", "Home", new { id = id });
        }
    }
}