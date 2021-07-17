﻿using ExaLearn.Dal.Database;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;

namespace ExaLearn.Dal.Repositories
{
    public class QuestionAnswerRepository : GenericRepository<UserAnswer>, IQuestionAnswerRepository
    {
        public QuestionAnswerRepository(ExaLearnDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
