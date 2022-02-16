using Microsoft.AspNetCore.SignalR;
using surchatAPI.DTO;
using System.Threading.Tasks;

namespace surchatAPI.Hubs
{
    public class ChatHub:Hub<IChatHub>
    {
        public async Task BroadcastAsync(ChatMessage message)
        {
            await Clients.All.MessageReceivedFromHub(message);
        }
        public override async Task OnConnectedAsync()
        {
            await Clients.All.NewUserConnected("a new user connectd");
        }
    }
}
