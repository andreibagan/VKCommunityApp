using System.Collections.Generic;
using VKCommunity.DAL.Models.Base;

namespace VKCommunity.DAL.Models
{
    public class Community : BaseEntity
    {
        public string Name { get; set; }
        public string Url { get; set; }

        public List<Message> Messages { get; set; }
    }
}
