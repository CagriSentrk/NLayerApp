using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Services
{
    public interface IService<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        IQueryable<T> where(Expression<Func<T, bool>> expression);
        IQueryable<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entitiy);
        Task AddRangeAsync(IEnumerable<T> entities);
        Task UpdateAsync(T entitiy);
        Task RemoveAsync(T entitiy);
        Task RemoveRangeAsync(IEnumerable<T> entities);

    }
}
