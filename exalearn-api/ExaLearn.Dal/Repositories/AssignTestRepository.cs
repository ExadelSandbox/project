using ExaLearn.Dal.Database;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using ExaLearn.Shared.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Repositories
{
    public class AssignTestRepository : GenericRepository<AssignTest>, IAssignTestRepository
    {
        public AssignTestRepository(ExaLearnDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<IList<AssignTest>> GetHrAssignedTestByIdAsync(int hrId)
        {
            return await _appDbContext.AssignTests.Include(x => x.User).Where(x => x.AssignerId == hrId).ToListAsync();
        }

        public async Task<IList<AssignTest>> GetUserAssignedTestByIdAsync(int userId)
        {
            return await _appDbContext.AssignTests.Include(x => x.Assigner).Where(x => x.UserId == userId).ToListAsync();
        }

        public async Task<IList<AssignTest>> GetHrExpiredAssignedTestByIdAsync(int hrId)
        {
            return await _appDbContext.AssignTests.Include(x => x.User).Where(x => (x.AssignerId == hrId) && x.IsExpired).ToListAsync();
        }

        public async Task<IList<AssignTest>> GetAllAssignedTests()
        {
            return await _appDbContext.AssignTests.Include(x => x.User).ToListAsync();
        }

        public async Task ArchiveExpiredAssignTest()
        {
            var expiredTests = await _appDbContext.PassedTests.Include(x => x.AssignTest)
                .Where(x => x.AssignTestId != null)
                .Where(x => DateTime.Compare(x.AssignTest.ExpirationDate, DateTime.UtcNow) < 0)
                .ToListAsync();

            expiredTests.ForEach(x => x.Status = StatusType.Expired);
            expiredTests.ForEach(x => x.AssignTest.IsExpired = true);

            await _appDbContext.SaveChangesAsync();
        }
    }
}
