using ExaLearn.Dal.Database;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;

namespace ExaLearn.Dal.Repositories
{
    public class PassedTestRepository : GenericRepository<PassedTest>, IPassedTestRepository
    {
        public PassedTestRepository(ExaLearnDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
