using ExaLearn.Dal.Database;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Repositories
{
    public class AssignTestRepository : GenericRepository<AssignTest>, IAssignTestRepository
    {
        public AssignTestRepository(ExaLearnDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<IList<AssignTest>> GetHRAssignedTestByIdAsync(int hrId)
        {
            return await _appDbContext.AssignTests.Include(x => x.Assigner).Where(x => x.AssignerId == hrId).ToListAsync();
        }

        public async Task<IList<AssignTest>> GetUserAssignedTestByIdAsync(int userId)
        {
            return await _appDbContext.AssignTests.Include(x => x.User).Where(x => x.UserId == userId).ToListAsync();
        }
    }
}
