using ExaLearn.Dal.Database;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;

namespace ExaLearn.Dal.Repositories
{
    public class HistoryRepository : GenericRepository<History>, IHistoryRepository
    {
        public HistoryRepository(ExaLearnDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
