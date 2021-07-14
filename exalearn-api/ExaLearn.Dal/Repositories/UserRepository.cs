using ExaLearn.Dal.Database;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;

namespace ExaLearn.Dal.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ExaLearnDbContext appDbContext) : base(appDbContext)
        {

        }
    }
}
