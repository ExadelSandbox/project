using ExaLearn.Dal.Database;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using Hangfire;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Repositories
{
    public class AssignTestRepository : GenericRepository<AssignTest>, IAssignTestRepository
    {
        private readonly IConfiguration _configuration;
        public AssignTestRepository(ExaLearnDbContext appDbContext, IConfiguration configuration) : base(appDbContext)
        {
            _configuration = configuration;
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

        public void ArchiveExpiredAssignTest()
        {
            using (var con = new NpgsqlConnection(_configuration.GetConnectionString("DbContext")))
            {
                var cmd = new NpgsqlCommand("call archiveexpiredassigntest(:dateNow)", con);
                cmd.Parameters.AddWithValue("dateNow", DateTime.UtcNow);
                cmd.CommandType = CommandType.Text;
                con.Open();
                using var reader = cmd.ExecuteReader();
            }
        }
    }
}
