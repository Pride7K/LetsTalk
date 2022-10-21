using System;
using System.Threading;
using System.Threading.Tasks;
using LetsTalk.Data;
using LetsTalk.Dtos.ChatControllerDto;
using LetsTalk.Hubs;
using LetsTalk.Models;
using LetsTalk.Repositories.MessageService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace LetsTalk.Controllers
{
    [Authorize]
    [ApiController]
    [Route("Chat")]
    public class ChatController : Controller
    {
        private readonly AppDbContext _context;
        private IHubContext<ChatHub> _chatHub;
        private readonly IMessageRepository _messageRepository;

        public ChatController(
            AppDbContext _context,
            IHubContext<ChatHub> _chatHub,
            IMessageRepository _messageRepository)
        {
            this._context = _context;
            this._chatHub = _chatHub;
            this._messageRepository = _messageRepository;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> SendMessage([FromForm] [Bind("roomId,messageBody")]SendMessageRequestDto model )
        {
            var messageDb = await _messageRepository.CreateMessage(messageBody:model.messageBody,chatId:model.roomId ,UserName: User.Identity.Name,token: CancellationToken.None);

            await _chatHub.Clients.Group(model.roomId.ToString()).SendAsync("RecieveMessage", new
            {
                Text = messageDb.Text,
                Name = messageDb.Name,
                CreatedAt = messageDb.CreatedAt.ToString("dd/MM/yyyy hh:mm:ss")
            });

            return Ok();
        }
    }
}