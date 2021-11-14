using System.Collections.Generic;

namespace VKCommunity.DAL.Models
{
    public class Community : BaseEntity
    {
        public string Name { get; set; }
        public string Url { get; set; }

        public List<PostMessage> PostMessages { get; set; }
    }
}
