using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace VKCommunity.RepositoryStorage.Repository
{
    public interface IRepository<T>
        where T : class
    {
        void Create(T item);

        IEnumerable<T> Get();
        T Get(int id);
        IEnumerable<T> Get(Func<T, bool> predicate);
        IEnumerable<T> Get(params Expression<Func<T, object>>[] includeProperties);

        void Update(T itemOld, T itemNew);

        void Delete(T item);


        bool SaveChanges();
    }
}
