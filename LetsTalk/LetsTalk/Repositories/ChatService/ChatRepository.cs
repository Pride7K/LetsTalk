using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using LetsTalk.Data;
using LetsTalk.Models;
using LetsTalk.Transaction;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LetsTalk.Repositories.ChatService
{
    public class ChatRepository : IChatRepository
    {
        private readonly IUnitOfWork _uow;
        private readonly AppDbContext _context;

        public ChatRepository(AppDbContext _context, IUnitOfWork uow)
        {
            _uow = uow;
            this._context = _context;
        }

        public async Task<Chat> CreateRoom(string name, string userId, CancellationToken token)
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
                UserId = userId
            });

            await _uow.Commit(token);

            return chat;
        }

        public async Task JoinRoom(int id, string userId, CancellationToken token)
        {
            var chatUser = new ChatUser()
            {
                ChatId = id,
                Role = UserRole.Member,
                UserId = userId
            };

            _context.ChatUser.Add(chatUser);

            await _uow.Commit(token);
        }

        public async Task<Chat> GetChatById(int id, CancellationToken token)
        {
            return await _context.Chat.Include(chat1 => chat1.Messages)
                .FirstOrDefaultAsync(chat1 => chat1.Id == id, cancellationToken: token);
        }

        public async Task<Chat> CreatePrivateRoom(string userIdTargetAdd, string currentUserId, CancellationToken token)
        {
            var chat = new Chat()
            {
                Type = ChatType.Private
            };

            chat.ChatUser.Add(new ChatUser()
            {
                UserId = userIdTargetAdd
            });

            chat.ChatUser.Add(new ChatUser()
            {
                UserId = currentUserId
            });

            _context.Chat.Add(chat);

            await _uow.Commit(token);

            return chat;
        }

        public async Task<List<Chat>> GetPrivateRooms(string userId, CancellationToken token)
        {
            return await _context.Chat
                .Include(chat => chat.ChatUser)
                .ThenInclude(user => user.User)
                .Where(chat => chat.Type == ChatType.Private
                               && chat.ChatUser.Any(user => user.UserId == userId))
                .ToListAsync(cancellationToken: token);
        }

        public async Task<List<Chat>> GetRoomsExceptRoomsThatSpecificUserHas(string userIdToNotMatch,
            CancellationToken token)
        {
            return await _context.Chat
                .Include(chat => chat.ChatUser)
                .Where(chat => !chat.ChatUser
                    .Any(user => user.UserId == userIdToNotMatch)).ToListAsync(cancellationToken: token);
        }
    }
}