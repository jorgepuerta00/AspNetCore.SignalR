namespace SeekQ.Chat.Core.Client
{
    using Interfaces;
    using Entities;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.SignalR;

    public class ChatHub : Hub, IChatHub<ChatMessage>
    {
        public async Task SendMessage(ChatMessage message)
        {
            await Clients.All.SendAsync(
                    "ReceiveMessage",
                    message.SenderName,
                    message.Text,
                    message.SendAt
                );
        }
    }
}
