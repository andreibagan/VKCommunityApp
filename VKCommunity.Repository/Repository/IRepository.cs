using System.Collections.Generic;

namespace VKCommunity.RepositoryStorage.Repository
{
    public interface IRepository<T>
        where T : class
    {
        void Create(T item);

        IEnumerable<T> Get();
        T Get(int id);

        void Update(T item);

        void Delete(T item);


        bool SaveChanges();
    }
}
