using ExaLearn.Dal.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Interfaces
{
    public interface IAssignTestRepository : IGenericRepository<AssignTest>
    {
        Task<IList<AssignTest>> GetUserAssignedTestByIdAsync(int userId);

        Task<IList<AssignTest>> GetHrExpiredAssignedTestByIdAsync(int hrId);

        Task<IList<AssignTest>> GetAllAssignedTests();

        Task ArchiveExpiredAssignTest();
    }
}
