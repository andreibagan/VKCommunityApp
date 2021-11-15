using System;

namespace VKCommunity.DAL.Models
{
    public class PostMessage : BaseEntity
    {
        public string Message { get; set; }
        public string PictureUrl { get; set; }
        public string Author { get; set; }
        public DateTime Created { get; } = DateTime.UtcNow;
    }
}
