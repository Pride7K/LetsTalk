using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using LetsTalk.Data;
using LetsTalk.Dtos.HomeControllerDto;
using LetsTalk.Errors;
using LetsTalk.Models;
using LetsTalk.Repositories.ChatService;
using LetsTalk.Repositories.UserService;
using LetsTalk.Transaction;
using Microsoft.EntityFrameworkCore;
using MoreLinq;

namespace LetsTalk.Repositories.MessageService
{
    public class MessageRepository : IMessageRepository
    {
        private readonly AppDbContext _context;
        private readonly IChatRepository _chatRepository;
        private readonly IUnitOfWork _uow;

        public MessageRepository(AppDbContext _context,IChatRepository _chatRepository, IUnitOfWork uow)
        {
            this._context = _context;
            this._chatRepository = _chatRepository;
            _uow = uow;
        }

        public async Task<Message> CreateMessage(int chatId, string messageBody, string UserName, CancellationToken token)
        {
            var chat = await _chatRepository.GetChatById(chatId,token);
            if (chat == null)
                throw new NotFoundException("Room not Found!");
            
            var message = new Message()
            {
                ChatId = chatId,
                Text = messageBody,
                Name = UserName,
                TextLength = messageBody.Length,
                CreatedAt = DateTime.Now
            };

            _context.Message.Add(message);

            await _uow.Commit(token);

            return message;
        }

        public async Task<ReportResponseDto> GetReport(DateTime startDateTimeCut, DateTime endDateTimeCut)
        {
            var rooms = (await _context.Chat
                .Include(message => message.ChatUser)
                .ThenInclude(chat => chat.User)
                .Include(message => message.Messages)
                .ToListAsync());

            rooms = rooms.Where(room => room.Messages.Any(message =>
                        message.CreatedAt.Date >= startDateTimeCut.Date && message.CreatedAt.Date <= endDateTimeCut.Date)).ToList();

            var messages = rooms.SelectMany(chat => chat.Messages).ToList();

            var totalMessages = messages.Count();

            var totalUsers = messages.SelectMany(message => message.Chat.ChatUser).Select(users => users.User).DistinctBy(user => user.Id).Count();

            var longestLength = messages.Max(message => message.TextLength);
            
            var shortestLength = messages.Min(message => message.TextLength);

            var teste = rooms.SelectMany(chat => chat.ChatUser).GroupBy(user => user.User.Id)
                .Select(user => new
                {
                    userProp = user.Key,
                    numberOfMessages = user.Select(chatUser => chatUser.Chat).SelectMany(chatUser => chatUser.Messages)
                        .Count()
                }).ToList();

            var mostActiveUserByNumberOfMessages = rooms.SelectMany(chat => chat.ChatUser).GroupBy(user => user.User.Id)
                .Select(user => new
                    { userProp = user.First().User, numberOfMessages = user.Select(chatUser => chatUser.Chat).SelectMany(chatUser => chatUser.Messages).Count() })
                .OrderByDescending(arg => arg.numberOfMessages).FirstOrDefault();

            var averageContentLength = rooms.SelectMany(chat => chat.Messages).Sum(message => message.TextLength) /
                                       rooms.Sum(chat => chat.Messages.Count());
            
            return new ReportResponseDto()
            {
                MostActiveUserByNumberOfMessages = mostActiveUserByNumberOfMessages.userProp,
                longestMessage = longestLength,
                shotestMessage = shortestLength,
                averageContentLength = averageContentLength,
                totalMessages = totalMessages,
                totalUsers = totalUsers,
            };
        }
    }
}