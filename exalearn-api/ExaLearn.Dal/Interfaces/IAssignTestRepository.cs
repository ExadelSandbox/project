using ExaLearn.Dal.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Interfaces
{
    public interface IAssignTestRepository : IGenericRepository<AssignTest>
    {
        Task<IList<AssignTest>> GetHrAssignedTestByIdAsync(int hrId);

        Task<IList<AssignTest>> GetUserAssignedTestByIdAsync(int userId);
    }
}
