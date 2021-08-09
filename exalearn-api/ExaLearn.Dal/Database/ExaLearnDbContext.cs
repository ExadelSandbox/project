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

        public DbSet<History> Histories { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<UserAnswer> UserAnswers { get; set; }

        public DbSet<PassedTest> PassedTests { get; set; }

        public DbSet<Report> Reports { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var password = "_Test1234";

            var userHasher = new PasswordHasher<User>();
            var userName = "userexa@mailnesia.com";

            var hrUserHasher = new PasswordHasher<User>();
            var hrUserUserName = "hrexa@mailnesia.com";

            var coachUserHasher = new PasswordHasher<User>();
            var coachUserName = "coachexa@mailnesia.com";

            var user = new User
            {
                Id = 1,
                FirstName = "Gordon",
                LastName = "Banks",
                IsActive = false,
                LevelType = null,
                UserName = userName,
                NormalizedUserName = userName.ToUpper(),
                Email = userName,
                NormalizedEmail = userName.ToUpper(),
                EmailConfirmed = false,
                PasswordHash = userHasher.HashPassword(null, password),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                PhoneNumber = null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0
            };

            var hrUser = new User()
            {
                Id = 2,
                FirstName = "David",
                LastName = "Seama",
                IsActive = false,
                LevelType = null,
                UserName = hrUserUserName,
                NormalizedUserName = hrUserUserName.ToUpper(),
                Email = userName,
                NormalizedEmail = hrUserUserName.ToUpper(),
                EmailConfirmed = false,
                PasswordHash = hrUserHasher.HashPassword(null, password),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                PhoneNumber = null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0
            };

            var coachUser = new User()
            {
                Id = 3,
                FirstName = "Joe",
                LastName = "Hart",
                IsActive = false,
                LevelType = null,
                UserName = coachUserName,
                NormalizedUserName = coachUserName.ToUpper(),
                Email = coachUserName,
                NormalizedEmail = coachUserName.ToUpper(),
                EmailConfirmed = false,
                PasswordHash = coachUserHasher.HashPassword(null, password),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                PhoneNumber = null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0
            };

            builder.Entity<User>()
                   .HasData(user, hrUser, coachUser);

            var userRole = new Role
            {
                Id = 1,
                Name = RoleNames.User,
                NormalizedName = RoleNames.User.ToUpper(),
                ConcurrencyStamp = Guid.NewGuid().ToString()
            };

            var hrRole = new Role
            {
                Id = 2,
                Name = RoleNames.Hr,
                NormalizedName = RoleNames.Hr.ToUpper(),
                ConcurrencyStamp = Guid.NewGuid().ToString()
            };

            var coachRole = new Role
            {
                Id = 3,
                Name = RoleNames.Coach,
                NormalizedName = RoleNames.Coach.ToUpper(),
                ConcurrencyStamp = Guid.NewGuid().ToString()
            };

            builder.Entity<Role>()
                   .HasData(userRole, hrRole, coachRole);

            var identityUserRole = new UserRole
            {
                RoleId = userRole.Id,
                UserId = user.Id
            };

            var identityHrRole = new UserRole
            {
                RoleId = hrRole.Id,
                UserId = hrUser.Id
            };

            var identityCoachRole = new UserRole
            {
                RoleId = coachRole.Id,
                UserId = coachUser.Id
            };

            builder.Entity<UserRole>()
                   .HasData(identityUserRole, identityHrRole, identityCoachRole);

            builder.Seed();
        }
    }
}
