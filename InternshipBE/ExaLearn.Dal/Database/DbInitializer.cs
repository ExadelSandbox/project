using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using Microsoft.AspNetCore.Identity;
using Portal.Core.Constants;
using Shared.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaLearn.Dal
{
    public static class DbInitializer
    {
        public static async Task Seed(UserManager<User> userManager, RoleManager<IdentityRole<int>> roleManager,
            IGenericRepository<Question> questionRepository, IGenericRepository<Answer> answerRepository)
        {
            if (!roleManager.Roles.Any())
                await SeedRoles(roleManager);

            if (!userManager.Users.Any())
                await SeedUsers(userManager);

            await SeedQuestions(questionRepository);

            await SeedAnswers(answerRepository);
        }

        public static async Task SeedAnswers(IGenericRepository<Answer> answerRepository)
        {
            var grammarAnswers = new List<Answer>
            {
                new Answer //Grammar answers
                {
                    QuestionId = 2,
                    Text = "Paris",
                    IsCorrect = false
                },

                new Answer
                {
                    QuestionId = 2,
                    Text = "London",
                    IsCorrect = true
                },

                new Answer
                {
                    QuestionId = 2,
                    Text = "Rome",
                    IsCorrect = false
                },

                new Answer
                {
                    QuestionId = 2,
                    Text = "Moscow",
                    IsCorrect = false
                }
            };

            var listeningAnswers = new List<Answer>
            {
                new Answer //Listening answers
                {
                    QuestionId = 3,
                    Text = "Soccer",
                    IsCorrect = false
                },

                new Answer
                {
                    QuestionId = 3,
                    Text = "Ancient Greece",
                    IsCorrect = false
                },

                new Answer
                {
                    QuestionId = 3,
                    Text = "Weather",
                    IsCorrect = true
                },

                new Answer
                {
                    QuestionId = 3,
                    Text = "Sale",
                    IsCorrect = false
                }
            };

            await answerRepository.AddRangeAsync(grammarAnswers);
            await answerRepository.AddRangeAsync(listeningAnswers);
        }

        public static async Task SeedQuestions(IGenericRepository<Question> questionRepository)
        {
            var questions = new List<Question>
            {
            new Question
            {
                Type = QuestionType.Essay,
                Level = LevelType.Beginner,
                Description = "Essay description",
                Score = 10, //change according to requirements
                Text = "Theme: Global warming",
                AudioId = null,
                //Answer // to be considered
            },

            new Question
            {
                Type = QuestionType.Grammar,
                Level = LevelType.Beginner,
                Description = "Grammar description",
                Score = 2, //change according to requirements
                Text = "What is the capital of England",
                AudioId = null,
                //Answer = new List<Answer>{} // to be considered
            },

            new Question
            {
                Type = QuestionType.Listening,
                Level = LevelType.Beginner,
                Description = "Listening description",
                Score = 3, //change according to requirements
                Text = "Listen to the dialogue, what are they talking about?",
                AudioId = null,
                //Answer = new List<Answer>{} // to be considered
            },

            new Question
            {
                Type = QuestionType.Speaking,
                Level = LevelType.Beginner,
                Description = "Speaking description",
                Score = 20, //change according to requirements
                Text = "Speak for 5-10 minutes",
                AudioId = null,
                //Answer = new List<Answer>{} // to be considered
            },
            };

            await questionRepository.AddRangeAsync(questions);
        }

        public static async Task SeedUsers(UserManager<User> userManager)
        {
            var adminEmail = "adminexa@mailnesia.com";
            await userManager.CreateAsync(new User { UserName = adminEmail, Email = adminEmail, FirstName = "Peter", LastName = "Shilton" }, "_Test1234");
            await userManager.AddToRoleAsync(await userManager.FindByNameAsync(adminEmail), RoleNames.Admin);

            var coachEmail = "coachexa@mailnesia.com";
            await userManager.CreateAsync(new User { UserName = coachEmail, Email = coachEmail, FirstName = "Joe", LastName = "Hart" }, "_Test1234");
            await userManager.AddToRoleAsync(await userManager.FindByNameAsync(coachEmail), RoleNames.Coach);

            var hrEmail = "hrexa@mailnesia.com";
            await userManager.CreateAsync(new User { UserName = hrEmail, Email = hrEmail, FirstName = "David", LastName = "Seama" }, "_Test1234");
            await userManager.AddToRoleAsync(await userManager.FindByNameAsync(hrEmail), RoleNames.Hr);

            var userEmail = "userexa@mailnesia.com";
            await userManager.CreateAsync(new User { UserName = userEmail, Email = userEmail, FirstName = "Gordon", LastName = "Banks" }, "_Test1234");
            await userManager.AddToRoleAsync(await userManager.FindByNameAsync(userEmail), RoleNames.User);
        }

        public static async Task SeedRoles(RoleManager<IdentityRole<int>> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole<int>(RoleNames.Admin));
            await roleManager.CreateAsync(new IdentityRole<int>(RoleNames.Coach));
            await roleManager.CreateAsync(new IdentityRole<int>(RoleNames.Hr));
            await roleManager.CreateAsync(new IdentityRole<int>(RoleNames.User));
        }
    }
}
