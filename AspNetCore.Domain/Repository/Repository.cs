using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AspNetCore.Entity;
using AspNetCore.Entity.Context;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore.Domain.Repository
{
    public class Repository<TEntity,TKey>:IRepository<TEntity,TKey>
    where TEntity:class
    {
        #region fields

        protected readonly DbContext _db;
        protected readonly DbSet<TEntity> _set;
        #endregion
        public Repository(MsContext context)
        {
            _db = context;
            _set = _db.Set<TEntity>();
        }

        public List<TEntity> GetAll()
        {
            return _set.AsNoTracking().ToList<TEntity>();
        }

        public Task<List<TEntity>> GetAllAsync()
        {
            return _set.AsNoTracking().ToListAsync<TEntity>();
        }

        public TEntity GetByKey(TKey key)
        {
            return _set.Find(key);
        }

        public Task<TEntity> GetByKeyAsync(TKey key)
        {
            return _set.FindAsync(key);
        }

        public void Insert(TEntity entity)
        {
           _set.Add(entity);
            _db.SaveChanges();
        }

        public void Insert(IEnumerable<TEntity> entities)
        {
           _set.AddRange(entities);
            _db.SaveChanges();
        }

        public Task InsertAsync(TEntity entity)
        {
           return  _set.AddAsync(entity);
       
        }

        public Task InsertAsync(IEnumerable<TEntity> entities)
        {
            return _set.AddRangeAsync(entities);
        }

        public IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> expression)
        {
            return _set.Where(expression);
        }

        public IQueryable<TEntity> Query()
        {
            return _set.AsQueryable();
        }

        public void Remove(TEntity entity)
        {
            _set.Remove(entity);
            _db.SaveChanges();
        }

        public void Remove(TKey key)
        {
            var entity = _set.Find(key);
            _set.Remove(entity);
            _db.SaveChanges();
        }

        public void Remove(Expression<Func<TEntity, bool>> expression)
        {
            var entities = _set.AsNoTracking().Where(expression).ToList();
            _set.RemoveRange(entities);
            _db.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _set.Update(entity);
            _db.SaveChanges();
        }

        public void Update(IEnumerable<TEntity> entities)
        {
            _set.UpdateRange(entities);
            _db.SaveChanges();
        }
    }
}
