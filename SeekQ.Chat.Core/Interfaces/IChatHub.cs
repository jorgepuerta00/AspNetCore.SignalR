namespace SeekQ.Chat.Core.Interfaces
{
    using Entities;
    using System.Threading.Tasks;
    public interface IChatHub<T> where T : IModel
    {
        Task SendMessage(T entity);
    }
}
