using Microsoft.EntityFrameworkCore;
using NLayer.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Repositories
{


    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(AppDbContext context)

        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task AddAsync(T entitiy)
        {
          await _dbSet.AddAsync(entitiy);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
           await _dbSet.AddRangeAsync(entities);
        }

        public async Task<bool> AnyAsync(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            return await _dbSet.AnyAsync(expression);
        }

        public IQueryable<T> GetAll(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            return _dbSet.AsNoTracking().AsQueryable();//AsNoTracking veriyi belleğe almasın ki daha optimize çalışsın.
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public void Remove(T entitiy)
        {
            _dbSet.Remove(entitiy);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
     _dbSet.RemoveRange(entities);
        }

        public void Update(T entitiy)
        {
            _dbSet.Update(entitiy);
        }

        public IQueryable<T> where(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression);
        }

       
    }
}
