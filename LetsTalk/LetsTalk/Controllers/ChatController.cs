using System;
using System.Threading.Tasks;
using LetsTalk.Data;
using LetsTalk.Hubs;
using LetsTalk.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace LetsTalk.Controllers
{
    [Authorize]
    [Route("[controller]")]
    public class ChatController : Controller
    {
        private readonly AppDbContext _context;
        private IHubContext<ChatHub> _chatHub;

        public ChatController(
            AppDbContext _context,
            IHubContext<ChatHub> _chatHub)
        {
            this._context = _context;
            this._chatHub = _chatHub;
        }

        [HttpPost]
        [Route("[action]/{connectionId}/{roomId}")]

        public async Task<IActionResult> JoinRoom(string connectionId, string roomId)
        {
            await _chatHub.Groups.AddToGroupAsync(connectionId, roomId);
            return Ok();
        }

        [HttpPost]
        [Route("[action]/{connectionId}/{roomId}")]
        public async Task<IActionResult> LeaveRoom(string connectionId, string roomId)
        {
            await _chatHub.Groups.RemoveFromGroupAsync(connectionId, roomId);
            return Ok();
        }
        
        [HttpPost("[action]")]
        public async Task<IActionResult> SendMessage(string messageBody,int roomId)
        {
            var messageDb = new Message()
            {
                ChatId = roomId,
                Text = messageBody,
                Name = User.Identity.Name,
                CreatedAt = DateTime.Now
            };

            _context.Message.Add(messageDb);

            await _context.SaveChangesAsync();
            
            await _chatHub.Clients.Group(roomId.ToString()).SendAsync("RecieveMessage",new
            {
                Text = messageDb.Text,
                Name = messageDb.Name,
                CreatedAt = messageDb.CreatedAt.ToString("dd/MM/yyyy hh:mm:ss")
            });
            
            return Ok();
        }
    }
}