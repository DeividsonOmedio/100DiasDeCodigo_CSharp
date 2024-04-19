using Microsoft.AspNetCore.SignalR;

namespace BlazorAppChat.API.Hubs
{
    public class ChatHub : Hub
    {
        public async Task Broadcast(string username ,string message)
        {
            await Clients.All.SendAsync("Broadcast", username, message);
        }
    }
}
