﻿using ExaLearn.Dal.Database;
using Microsoft.EntityFrameworkCore;

namespace ExaLearn.Dal
{
    public static class DbInitializer
    {
        public static void DbInitialize(ExaLearnDbContext dbContext)
        {
            dbContext.Database.EnsureCreated();
            //dbContext.Database.Migrate();
        }
    }
}
