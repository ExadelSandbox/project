﻿using ExaLearn.Dal.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Interfaces
{
    public interface IUserAnswerRepository : IGenericRepository<UserAnswer>
    {
        //Task<List<UserTest>> UserAnswerScore(int passedTestId);
    }
}
