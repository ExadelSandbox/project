using ExaLearn.Dal.Database;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Repositories
{
    public class HistoryRepository : GenericRepository<History>, IHistoryRepository
    {
        public HistoryRepository(ExaLearnDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<IList<History>> GetUserHistoryByIdAsync(int userId)
        {
            return await _appDbContext.Histories.Include(x => x.PassedTest).Where(x => x.UserId == userId).ToListAsync();
        }

        public async Task<IList<PassedTest>> GetHRUserHistoryByIdAsync(int userId)
        {
            return await _appDbContext.PassedTests.Include(x => x.User).Where(x => x.UserId == userId).ToListAsync();
        }
    }
}
