using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using LetsTalk.Models;
using Microsoft.AspNetCore.Mvc;

namespace LetsTalk.Repositories.ChatService
{
    public interface IChatRepository
    {
        Task<Chat> CreateRoom(string name, string userId, CancellationToken token);
        Task JoinRoom(int id, string userId, CancellationToken token);
        Task<Chat> GetChatById(int id, CancellationToken token);

        Task<Chat> CreatePrivateRoom(string userIdTargetAdd, string currentUserId, CancellationToken token);
        Task<List<Chat>>  GetPrivateRooms(string userId, CancellationToken token);
        
        Task<List<Chat>> GetRoomsExceptRoomsThatSpecificUserHas(string userIdToNotMatch, CancellationToken token);

    }
}