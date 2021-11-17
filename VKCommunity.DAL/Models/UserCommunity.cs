using VKCommunity.DAL.Models.Base;

namespace VKCommunity.DAL.Models
{
    public class UserCommunity : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int CommunityId { get; set; }
        public Community Community { get; set; }
    }
}
