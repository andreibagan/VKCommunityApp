using System.Collections.Generic;
using VKCommunity.DAL.Models.Base;

namespace VKCommunity.DAL.Models
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public List<UserCommunity> UserCommunities { get; set; }
    }
}
