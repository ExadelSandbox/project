using ExaLearn.Dal.Database;
using ExaLearn.Dal.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected ExaLearnDbContext _appDbContext;
        protected DbSet<T> _dbSet;

        public GenericRepository(ExaLearnDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            _dbSet = appDbContext.Set<T>();
        }
        public async Task<T> CreateAsync(T item)
        {
            await _dbSet.AddAsync(item);
            await _appDbContext.SaveChangesAsync();
            return item;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<T> DeleteAsync(T item)
        {
            _dbSet.Remove(item);
            await _appDbContext.SaveChangesAsync();
            return item;
        }

        public async Task<T> UpdateAsync(T item)
        {
            _appDbContext.Entry(item).State = EntityState.Modified;
            await _appDbContext.SaveChangesAsync();
            return item;
        }

        public async Task<IList<T>> AddRangeAsync(IList<T> item) 
        {
            await _dbSet.AddRangeAsync(item);
            await _appDbContext.SaveChangesAsync();
            return item;
        }

        public async Task SaveChangesAsync()
        {
            await _appDbContext.SaveChangesAsync();
        }
    }
}
