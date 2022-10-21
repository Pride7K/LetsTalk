using System.Threading;
using System.Threading.Tasks;
using LetsTalk.Models;

namespace LetsTalk.Repositories.MessageService
{
    public interface IMessageRepository
    {
        Task<Message> SendMessage(string messageBody, int roomId, string UserName, CancellationToken token);

        Task<Message> CreateMessage(int chatId, string messageBody, string UserName, CancellationToken token);
    }
}