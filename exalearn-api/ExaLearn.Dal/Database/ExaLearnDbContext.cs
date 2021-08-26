using ExaLearn.Dal.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Portal.Core.Constants;
using System;

namespace ExaLearn.Dal.Database
{
    public class ExaLearnDbContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public ExaLearnDbContext(DbContextOptions<ExaLearnDbContext> options) : base(options) 
        { 
        }

        public DbSet<Answer> Answers { get; set; }
        
        public DbSet<AssignTest> AssignTests { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<UserAnswer> UserAnswers { get; set; }

        public DbSet<PassedTest> PassedTests { get; set; }        

        public DbSet<UserTest> UserTests { get; set; }

        public DbSet<Assessment> Assessments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.HasPostgresExtension("uuid-ossp");
            builder.Seed();
        }
    }
}
