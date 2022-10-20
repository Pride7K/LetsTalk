using Microsoft.AspNetCore.SignalR;

namespace LetsTalk.Hubs
{
    public class ChatHub : Hub
    {
        public string GetConnectionId()
        {
            return Context.ConnectionId;
        }
    }
}