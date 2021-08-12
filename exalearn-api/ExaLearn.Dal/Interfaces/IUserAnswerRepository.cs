using ExaLearn.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Interfaces
{
    public interface IUserAnswerRepository : IGenericRepository<UserAnswer>
    {
        Task<List<Answer>> GetCorrectQuestionsAnswers(int passedTestId);
    }
}
