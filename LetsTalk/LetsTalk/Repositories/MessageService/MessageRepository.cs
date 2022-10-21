using System;
using System.Threading;
using System.Threading.Tasks;
using LetsTalk.Data;
using LetsTalk.Models;
using LetsTalk.Transaction;

namespace LetsTalk.Repositories.MessageService
{
    public class MessageRepository : IMessageRepository
    {
        private readonly AppDbContext _context;
        private readonly IUnitOfWork _uow;

        public MessageRepository(AppDbContext _context,IUnitOfWork uow)
        {
            this._context = _context;
            _uow = uow;
        }
        public async Task<Message> SendMessage(string messageBody, int roomId, string UserName, CancellationToken token)
        {
            var messageDb = new Message()
            {
                ChatId = roomId,
                Text = messageBody,
                Name = UserName,
                CreatedAt = DateTime.Now
            };

            _context.Message.Add(messageDb);

            await _uow.Commit(token);

            return messageDb;
        }

        public async Task<Message> CreateMessage(int chatId, string messageBody, string UserName, CancellationToken token)
        {
            var message = new Message()
            {
                ChatId = chatId,
                Text = messageBody,
                Name = UserName,
                CreatedAt = DateTime.Now
            };

            _context.Message.Add(message);

            await _uow.Commit(token);

            return message;
        }
    }
}