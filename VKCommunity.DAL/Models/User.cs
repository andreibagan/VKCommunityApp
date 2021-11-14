using System.Collections.Generic;

namespace VKCommunity.DAL.Models
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public List<UserCommunity> UserCommunities { get; set; }
    }
}
