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
            var grammarAnswer1 = new Answer
            {
                Id = 1,
                QuestionId = 1,
                IsCorrect = true,
                Text = "London"
            };

            var grammarAnswer2 = new Answer
            {
                Id = 2,
                QuestionId = 1,
                IsCorrect = false,
                Text = "Paris"
            };

            var grammarAnswer3 = new Answer
            {
                Id = 3,
                QuestionId = 1,
                IsCorrect = false,
                Text = "Moscow"
            };

            var grammarAnswer4 = new Answer
            {
                Id = 4,
                QuestionId = 1,
                IsCorrect = false,
                Text = "Minsk"
            };

            var listeningAnswer1 = new Answer
            {
                Id = 5,
                QuestionId = 2,
                IsCorrect = true,
                Text = "Cat"
            };

            var listeningAnswer2 = new Answer
            {
                Id = 6,
                QuestionId = 2,
                IsCorrect = false,
                Text = "Dog"
            };

            var listeningAnswer3 = new Answer
            {
                Id = 7,
                QuestionId = 2,
                IsCorrect = false,
                Text = "Cow"
            };

            var listeningAnswer4 = new Answer
            {
                Id = 8,
                QuestionId = 2,
                IsCorrect = false,
                Text = "Goat"
            };

            var grammarQuestion = new Question
            {
                Id = 1,
                AudioFile = null,
                AudioId = null,
                Type = QuestionType.Grammar,
                Text = "Capital of the England",
                Description = "Grammar Description",
                LevelType = LevelType.Beginner,
                Score = 2, //change according to requirements
            };

            var listeningQuestion = new Question
            {
                Id = 2,
                AudioFile = null,//some audio file
                AudioId = null,
                Type = QuestionType.Audition,
                Text = "The most common animal",
                Description = "Audition Description",
                LevelType = LevelType.Beginner,
                Score = 2, //change according to requirements
            };

            builder.Entity<Question>().HasData(grammarQuestion, listeningQuestion);

            builder.Entity<Answer>().HasData(grammarAnswer1, grammarAnswer2, grammarAnswer3, grammarAnswer4,
                listeningAnswer1, listeningAnswer2, listeningAnswer3, listeningAnswer4);
        }
    }
}
