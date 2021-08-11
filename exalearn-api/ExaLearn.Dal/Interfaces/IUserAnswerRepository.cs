using ExaLearn.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Interfaces
{
    public interface IUserAnswerRepository : IGenericRepository<UserAnswer>
    {
        Task<List<Answer>> GetByExpressionAsync(Func<Question, bool> expression, int passedTestId);

        Task<List<Answer>> GetGrammarQuestionAnswers(int passedTestId);

        Task<List<Answer>> GetAuditionQuestionAnswers(int passedTestId);
    }
}
