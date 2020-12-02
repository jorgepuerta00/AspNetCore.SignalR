namespace SeekQ.Chat.Entities
{
    using System;
    public abstract class AbstractModel : IModel
    {
        public DateTimeOffset SendAt { get; set; }
    }
}
