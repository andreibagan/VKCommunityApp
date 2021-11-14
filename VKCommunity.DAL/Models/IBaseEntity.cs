namespace VKCommunity.DAL.Models
{
    public interface IBaseEntity<TEntity>
    {
        TEntity Id { get; set; }
    }
}
