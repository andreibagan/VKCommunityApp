namespace VKCommunity.Service.Models
{
    public class UserCommunityModel
    {
        public int UserId { get; set; }
        public UserModel User { get; set; }

        public int CommunityId { get; set; }
        public CommunityModel Community { get; set; }
    }
}
