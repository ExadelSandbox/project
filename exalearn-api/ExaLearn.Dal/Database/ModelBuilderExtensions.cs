using ExaLearn.Dal.Entities;
using Microsoft.EntityFrameworkCore;
using Shared.Enums;

namespace ExaLearn.Dal.Database
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
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "Capital of the England?",
                LevelType = LevelType.Beginner
            };

            var listeningQuestion = new Question
            {
                Id = 2,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "The most common animal?",
                LevelType = LevelType.Beginner
            };

            var topic1 = new Question
            {
                Id = 3,
                QuestionType = QuestionType.Topic,
                Text = "Lets talk about Great Britain. What do you know about this country?",
            };

            var topic2 = new Question
            {
                Id = 4,
                QuestionType = QuestionType.Topic,
                Text = "Can you speak in your micro about nature?",
            };

            builder.Entity<Question>().HasData(grammarQuestion, listeningQuestion, topic1, topic2);

            builder.Entity<Answer>().HasData(grammarAnswer1, grammarAnswer2, grammarAnswer3, grammarAnswer4,
                listeningAnswer1, listeningAnswer2, listeningAnswer3, listeningAnswer4);
        }
    }
}
