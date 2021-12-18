namespace VKCommunity.DAL.Models.Base
{
    public abstract class BaseEntity : IBaseEntity<int>
    {
        public int Id { get; set; }
    }
}
