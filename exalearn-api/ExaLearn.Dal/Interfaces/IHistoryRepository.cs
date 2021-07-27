using ExaLearn.Dal.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Interfaces
{
    public interface IHistoryRepository : IGenericRepository<History>
    {
        Task<IList<History>> GetUserHistoryByIdAsync(int userId);

        Task<IList<PassedTest>> GetHRUserHistoryByIdAsync(int userId);
    }
}
