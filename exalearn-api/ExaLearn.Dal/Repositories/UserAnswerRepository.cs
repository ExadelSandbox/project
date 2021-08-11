using ExaLearn.Dal.Database;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Repositories
{
    public class UserAnswerRepository : GenericRepository<UserAnswer>, IUserAnswerRepository
    {
        public UserAnswerRepository(ExaLearnDbContext appDbContext) : base(appDbContext)
        {
        }

        //public async Task<List<UserTest>> UserAnswerScore(int passedTestId)
        //{
        //    var userAnswers = _appDbContext.PassedTests.Select(x => x.UserAnswers.Where(u => u.Answer == "f"));

        //    var answers = _appDbContext.PassedTests
        //         .Where(x => x.Id == passedTestId)
        //         .Select(x => x.UserTest)
        //         .Select(x => x.Questions.Select(u => u.Answers.Where(u => u.Text == "f")));  //answers == userAnswers


        //    //select "QuestionsId", "Text" from public."QuestionUserTest" 
        //    //join public."Answers" 
        //    //on "QuestionUserTest"."QuestionsId" = "Answers"."QuestionId"
        //    //where public."QuestionUserTest"."UserTestId" = 1

        //    return userTest;
        //}
    }
}
