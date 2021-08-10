using ExaLearn.Dal.Database;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using ExaLearn.Shared.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace ExaLearn.Dal.Repositories
{
    public class PassedTestRepository : GenericRepository<PassedTest>, IPassedTestRepository
    {
        public PassedTestRepository(ExaLearnDbContext appDbContext) : base(appDbContext)
        {
        }

        public void ChangeStatus()
        {
            var expiredTests = _appDbContext.PassedTests
                .Where(x => DateTime.Compare(x.AssignTest.ExpirationDate, DateTime.Now) < 0).Select(x => x).ToList();

            expiredTests.ForEach(x => x.Status = StatusType.Expired);

            _appDbContext.PassedTests.UpdateRange(expiredTests);
            _appDbContext.SaveChanges();
        }
    }
}