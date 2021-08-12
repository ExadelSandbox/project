﻿using ExaLearn.Dal.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Interfaces
{
    public interface IPassedTestRepository : IGenericRepository<PassedTest>
    {
        Task<PassedTest> GetUserTestByPassedTestIdAsync(int passedTestId);
    }
}
