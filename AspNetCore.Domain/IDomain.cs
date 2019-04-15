using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AspNetCore.Domain
{
    public interface IDomain<T,TKey>
    {
        Task<List<T>> Get();
        T GetById(TKey id);
        void Update(T entity);
        void Delete(TKey id);
        void Add(T entity);
        IQueryable<T> Query();
        IQueryable<T> Query(Expression<Func<T, bool>> expression);
    }
}
