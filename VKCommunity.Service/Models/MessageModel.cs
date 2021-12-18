using System;

namespace VKCommunity.Service.Models
{
    public class MessageModel
    {
        public string MessageContent { get; set; }
        public string PictureUrl { get; set; }
        public string Author { get; set; }
        public DateTime Created { get; } = DateTime.UtcNow;

        public CommunityModel Community { get; set; }
    }
}
