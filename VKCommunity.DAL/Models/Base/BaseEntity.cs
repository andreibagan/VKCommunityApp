namespace VKCommunity.DAL.Models.Base
{
    public class BaseEntity : IBaseEntity<int>
    {
        public int Id { get; set; }
    }
}
