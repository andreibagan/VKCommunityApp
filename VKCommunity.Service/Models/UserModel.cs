using System.Collections.Generic;

namespace VKCommunity.Service.Models
{
    public class UserModel
    {
        public string UserName { get; set; }
        public List<UserCommunityModel> UserCommunities { get; set; }
    }
}
