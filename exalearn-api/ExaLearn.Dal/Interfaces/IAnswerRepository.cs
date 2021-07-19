using ExaLearn.Dal.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Interfaces
{
    public interface IAnswerRepository : IGenericRepository<Answer>
    {
        public Task<List<Answer>> GetByQuestionId(int id);
    }
}
