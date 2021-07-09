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

        private ExaLearnDbContext appDbContext;
        private DbSet<T> dbSet;
        public GenericRepository(ExaLearnDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
            dbSet = appDbContext.Set<T>();
        }
        public async Task<T> AddAsync(T item)
        {
            await dbSet.AddAsync(item);
            await appDbContext.SaveChangesAsync();
            return item;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }

        public async Task<T> GetAsync(T id)
        {
            return await dbSet.FindAsync(id);
        }

        public async Task<T> Remove(T item)
        {
            dbSet.Remove(item);
            appDbContext.SaveChanges();
            return item;

        }

        public async Task<T> Update(T item)
        {
            appDbContext.Entry(item).State = EntityState.Modified;
            appDbContext.SaveChanges();
            return item;
        }
    }
}
