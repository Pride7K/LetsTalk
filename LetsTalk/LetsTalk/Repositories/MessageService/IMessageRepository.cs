using System;
using System.Threading;
using System.Threading.Tasks;
using LetsTalk.Dtos.HomeControllerDto;
using LetsTalk.Models;

namespace LetsTalk.Repositories.MessageService
{
    public interface IMessageRepository
    {
        Task<Message> CreateMessage(int chatId, string messageBody, string UserName, CancellationToken token);
        Task<ReportResponseDto> GetReport(DateTime startDateTimeCut, DateTime endDateTimeCut);
    }
}