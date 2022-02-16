using surchatAPI.DTO;
using System.Threading.Tasks;

namespace surchatAPI.Hubs
{
    public interface IChatHub
    {
        Task MessageReceivedFromHub(ChatMessage message);

        Task NewUserConnected(string message);
    }
}
