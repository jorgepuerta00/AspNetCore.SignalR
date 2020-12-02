namespace SeekQ.Chat.Entities
{
    public class ImageMessage : AbstractModel
    {
        public byte[] ImageBinary { get; set; }
        public string ImageHeaders { get; set; }
    }
}
