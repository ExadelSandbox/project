using ExaLearn.Dal.Entities;
using Microsoft.EntityFrameworkCore;
using Shared.Enums;
using System.Collections.Generic;

namespace ExaLearn.Dal
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder builder)
        {
            var grammarAnswers = new List<Answer>
            {
                new Answer
                {
                    Id = 1,
                    QuestionId = 1,
                    IsCorrect = true,
                    Text = "London"
                },
                new Answer
                {
                    Id = 2,
                    QuestionId = 1,
                    IsCorrect = false,
                    Text = "Paris"
                },
                new Answer
                {
                    Id = 3,
                    QuestionId = 1,
                    IsCorrect = false,
                    Text = "Moscow"
                },
                new Answer
                {
                    Id = 4,
                    QuestionId = 1,
                    IsCorrect = false,
                    Text = "Minsk"
                }
            };

            var listeningAnswers = new List<Answer>
            {
                new Answer
                {
                    Id = 5,
                    QuestionId = 2,
                    IsCorrect = true,
                    Text = "Cat"
                },
                new Answer
                {
                    Id = 6,
                    QuestionId = 2,
                    IsCorrect = false,
                    Text = "Dog"
                },
                new Answer
                {
                    Id = 7,
                    QuestionId = 2,
                    IsCorrect = false,
                    Text = "Cow"
                },
                new Answer
                {
                    Id = 8,
                    QuestionId = 2,
                    IsCorrect = false,
                    Text = "Goat"
                }
            };

            var grammarQuestion = new Question
            {
                Id = 1,
                AudioFile = null,
                AudioId = null,
                Type = QuestionType.Grammar,
                Text = "Capital of the England",
                Description = "Grammar Description",
                Level = LevelType.Beginner,
                Score = 2,
            };

            var listeningQuestion = new Question
            {
                Id = 1,
                AudioFile = null,//some audio file
                AudioId = null,
                Type = QuestionType.Audition,
                Text = "The most common animal",
                Description = "Audition Description",
                Level = LevelType.Beginner,
                Score = 2,
            };

            builder.Entity<Answer>().HasData(grammarAnswers, listeningAnswers);
            builder.Entity<Question>().HasData(grammarQuestion, listeningQuestion);

        }
    }
}
