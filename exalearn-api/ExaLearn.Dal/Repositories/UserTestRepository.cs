using ExaLearn.Dal.Database;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;

namespace ExaLearn.Dal.Repositories
{
    public class UserTestRepository : GenericRepository<UserTest>, IUserTestRepository
    {
        public UserTestRepository(ExaLearnDbContext appDbContext) : base(appDbContext)
        {

        }
    }
}
