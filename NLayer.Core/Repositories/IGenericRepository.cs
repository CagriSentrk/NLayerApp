using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
namespace NLayer.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);

        IQueryable<T> where(Expression<Func<T, bool>> expression);
        IQueryable<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entitiy);
        Task AddRangeAsync(IEnumerable<T> entities);
        void Update(T entitiy);
        void Remove(T entitiy);

        void RemoveRange(IEnumerable<T> entities);
    }
}
