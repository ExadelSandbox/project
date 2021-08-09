using ExaLearn.Dal.Database;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;

namespace ExaLearn.Dal.Repositories
{
    public class UserAnswerRepository : GenericRepository<UserAnswer>, IUserAnswerRepository
    {
        public UserAnswerRepository(ExaLearnDbContext appDbContext) : base(appDbContext)
        {
        }

        //public async Task<List<UserAnswer>> GetUserAnswersAssesment()
        //{
        //   var kek = await _appDbContext.Answers.Where(x => x.IsCorrect == true).ToListAsync();
        //   return kek;
        //}
    }
}
