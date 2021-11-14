namespace VKCommunity.DAL.Models
{
    public class UserCommunity : BaseEntity
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int CommunityId { get; set; }
        public virtual Community Community { get; set; }
    }
}
