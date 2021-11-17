namespace VKCommunity.DAL.Models.Base
{
    public interface IBaseEntity<TEntity>
    {
        TEntity Id { get; set; }
    }
}
