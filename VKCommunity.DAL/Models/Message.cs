using System;
using VKCommunity.DAL.Models.Base;

namespace VKCommunity.DAL.Models
{
    public class Message : BaseEntity
    {
        public string MessageContent { get; set; }
        public string PictureUrl { get; set; }
        public string Author { get; set; }
        public DateTime Created { get; } = DateTime.UtcNow;

        public Community Community { get; set; }
    }
}
