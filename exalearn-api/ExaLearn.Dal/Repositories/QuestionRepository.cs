﻿using ExaLearn.Dal.Database;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using Microsoft.EntityFrameworkCore;
using Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Repositories
{
    public class QuestionRepository : GenericRepository<Question>, IQuestionRepository
    {
        public QuestionRepository(ExaLearnDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<List<Question>> GetByExpressionAsync(Expression<Func<Question, bool>> expression, int take = 0)
        {
            var questions = _appDbContext.Questions.Where(expression);

            if (take != 0)
                questions.OrderBy(g => Guid.NewGuid()).Take(take);

            return await questions.ToListAsync();
        }

        public async Task<List<Question>> GetGrammarQuestionAsync(LevelType levelType)
        {
            Expression<Func<Question, bool>> takeGrammerQuestions = q => q.Type == QuestionType.Grammar && q.LevelType == levelType;
            return await GetByExpressionAsync(takeGrammerQuestions, 10);
        }

        public async Task<List<Question>> GetAuditionQuestionAsync(LevelType levelType)
        {
            Expression<Func<Question, bool>> takeAuditionQuestions = q => q.Type == QuestionType.Audition && q.LevelType == levelType;
            return await GetByExpressionAsync(takeAuditionQuestions, 10);
        }

        public async Task<List<Question>> GetEssayTopicAsync(LevelType levelType)
        {
            Expression<Func<Question, bool>> takeEssayTopic = q => q.Type == QuestionType.Essay && q.LevelType == levelType;
            return await GetByExpressionAsync(takeEssayTopic, 10);
        }

        public async Task<List<Question>> GetSpeakingTopicAsync(LevelType levelType)
        {
            Expression<Func<Question, bool>> takeSpeakingTopic = q => q.Type == QuestionType.Speaking && q.LevelType == levelType;
            return await GetByExpressionAsync(takeSpeakingTopic, 1);
        }
    }
}