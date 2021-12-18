using System.Collections.Generic;

namespace VKCommunity.Service.Models
{
    public class CommunityModel
    {
        public string Name { get; set; }
        public string Url { get; set; }

        public List<MessageModel> Messages { get; set; }
    }
}
