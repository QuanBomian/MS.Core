using AspNetCore.Domain.Repository;
using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Domain
{
     public class Domain<TEntity,TKey>: IDomain<TEntity,TKey>
        where TEntity:EntityBase<TKey>
        
    {
        protected readonly IRepository<TEntity, TKey> _repository;

        public Domain(IRepository<TEntity,TKey> repository) {
            _repository = repository;
        }
        public void Add(TEntity entity)
        {
 
          _repository.Insert(entity);
        }

        public void Delete(TKey id)
        {
            _repository.Remove(id);
        }

        public Task<List<TEntity>> Get()
        {
            return _repository.GetAllAsync();
        }

        public TEntity GetById(TKey id)
        {
            return _repository.GetByKey(id);
        }

        public IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> expression)
        {
            return _repository.Query(expression);
        }

        public IQueryable<TEntity> Query()
        {
            return _repository.Query();
        }

        public void Update(TEntity entity)
        {
            _repository.Update(entity);
        }

     
    }
}
