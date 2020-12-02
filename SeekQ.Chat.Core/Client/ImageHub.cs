namespace SeekQ.Chat.Core.Client
{
    using Interfaces;
    using Entities;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.SignalR;

    public class ImageHub : Hub, IChatHub<ImageMessage>
    {
        public Task SendMessage(ImageMessage imageMessage)
        {
            return Clients.All.SendAsync("ImageMessage", imageMessage);
        }
    }
}
