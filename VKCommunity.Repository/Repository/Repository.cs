using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using VKCommunity.DAL;

namespace VKCommunity.RepositoryStorage.Repository
{
    public class Repository<T> : IRepository<T>
        where T : class
    {
        private readonly VKCommunityContext _vKCommunityContext;


        public Repository(VKCommunityContext vKCommunityContext)
        {
            _vKCommunityContext = vKCommunityContext;
        }

        public void Create(T item)
        {
            _vKCommunityContext.Add<T>(item);
        }

        public void Delete(T item)
        {
            _vKCommunityContext.Remove<T>(item);
        }

        public IEnumerable<T> Get()
        {
            return _vKCommunityContext.Set<T>().AsNoTracking().ToList();
        }

        public T Get(int id)
        {
            return _vKCommunityContext.Set<T>().Find(id);
        }

        public IEnumerable<T> Get(Func<T, bool> predicate)
        {
            return _vKCommunityContext.Set<T>().AsNoTracking().Where(predicate).ToList();
        }

        public IEnumerable<T> Get(params Expression<Func<T, object>>[] includeProperties)
        {
            return Include(includeProperties).ToList();
        }

        public IEnumerable<T> Get(Func<T, bool> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            var query = Include(includeProperties);
            return query.Where(predicate).ToList();
        }

        private IQueryable<T> Include(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _vKCommunityContext.Set<T>().AsNoTracking();
            return includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }

        public void Update(T item)
        {
            _vKCommunityContext.Entry<T>(item).State = EntityState.Modified;
        }

        public bool SaveChanges()
        {
            return (_vKCommunityContext.SaveChanges() >= 0);
        }
    }
}
