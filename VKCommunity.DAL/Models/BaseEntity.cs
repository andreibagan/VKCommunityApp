namespace VKCommunity.DAL.Models
{
    public class BaseEntity : IBaseEntity<int>
    {
        public int Id { get; set; }
    }
}
