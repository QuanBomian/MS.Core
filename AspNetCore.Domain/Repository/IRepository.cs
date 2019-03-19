using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AspNetCore.Entity;

namespace AspNetCore.Domain.Repository
{
    public interface IRepository<TEntity, TKey>
    where  TEntity :class
    {
        #region Query

        TEntity GetByKey(TKey key);
        Task<TEntity> GetByKeyAsync(TKey key);
        IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> expression);

        List<TEntity> GetAll();
        Task<List<TEntity>> GetAllAsync();

        #endregion

        #region Insert

        void Insert(TEntity entity);
        void Insert(IEnumerable<TEntity> entities);
        Task InsertAsync(TEntity entity);
        Task InsertAsync(IEnumerable<TEntity> entities);


        #endregion

        #region Update

        void Update(TEntity entity);
        void Update(IEnumerable<TEntity> entities);
        #endregion

        #region Remove

        void Remove(TEntity entity);
        void Remove(TKey key);
        void Remove(Expression<Func<TEntity, bool>> expression);

        #endregion
    }
}
