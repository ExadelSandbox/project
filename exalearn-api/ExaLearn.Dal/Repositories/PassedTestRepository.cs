﻿using ExaLearn.Dal.Database;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Repositories
{
    public class PassedTestRepository : GenericRepository<PassedTest>, IPassedTestRepository
    {
        public PassedTestRepository(ExaLearnDbContext appDbContext) : base(appDbContext)
        {         
        }

        public async Task<IList<PassedTest>> MyTestHistoryAsync(int userId)
        {
            return await _appDbContext.PassedTests.Where(x => x.UserId == userId).ToListAsync();
        }
    }
}
