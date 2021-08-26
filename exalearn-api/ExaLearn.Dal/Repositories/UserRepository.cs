using ExaLearn.Dal.Database;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ExaLearnDbContext appDbContext) : base(appDbContext)
        {

        }

        public async Task<string> GetUserRole(int id)
        {
            var userRole = await _appDbContext.UserRoles.SingleOrDefaultAsync(u => u.UserId == id);
            var role = await _appDbContext.Roles.SingleOrDefaultAsync(u => u.Id == userRole.RoleId);

            return role.Name;
        }        
    }
}
