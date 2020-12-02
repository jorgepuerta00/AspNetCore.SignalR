namespace SeekQ.Chat.Entities
{
    public class ChatMessage : AbstractModel
    {
        public string SenderName { get; set; }
        public string Text { get; set; }
    }
}
