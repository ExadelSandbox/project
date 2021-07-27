using ExaLearn.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Interfaces
{
    public interface IAssignTestRepository : IGenericRepository<AssignTest>
    {
        Task<IList<AssignTest>> GetUserAssignedTestByIdAsync(int userId);
    }
}
