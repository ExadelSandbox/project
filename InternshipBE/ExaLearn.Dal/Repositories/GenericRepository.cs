using ExaLearn.Dal.Database;
using ExaLearn.Dal.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private ExaLearnDbContext _appDbContext;
        private DbSet<T> _dbSet;
        public GenericRepository(ExaLearnDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            _dbSet = appDbContext.Set<T>();
        }
        public async Task<T> AddAsync(T item)
        {
            await _dbSet.AddAsync(item);
            await _appDbContext.SaveChangesAsync();
            return item;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<T> Remove(T item)
        {
            _dbSet.Remove(item);
            await _appDbContext.SaveChangesAsync();
            return item;

        }

        public async Task<T> Update(T item)
        {
            _appDbContext.Entry(item).State = EntityState.Modified;
            await _appDbContext.SaveChangesAsync();
            return item;
        }
    }
}
