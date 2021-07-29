using ExaLearn.Dal.Entities;
using Microsoft.EntityFrameworkCore;
using Shared.Enums;

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

            var topicAnswer1 = new Answer
            {
                Id = 9,
                QuestionId = 3,
                IsCorrect = true,
                Text = "The official name of the country is the United Kingdom of Great Britain and Northern Ireland" +
                "It is situated on the British Isles and includes England, Scotland, Wales and Northern Ireland" +
                "The climate of the country is mild and changeable."
            };

            var topicAnswer2 = new Answer
            {
                Id = 10,
                QuestionId = 3,
                IsCorrect = true,
                Text = "domain.com/audiofile" //need to implement link to file in Answer
            };

            var grammarQuestion = new Question
            {
                Id = 1,
                AudioFile = null,
                AudioId = null,
                QuestionType = QuestionType.Grammar,
                Text = "Capital of the England",
                LevelType = LevelType.Beginner
            };

            var listeningQuestion = new Question
            {
                Id = 2,
                AudioFile = null, 
                AudioId = null,
                QuestionType = QuestionType.Audition,
                Text = "The most common animal",
                LevelType = LevelType.Beginner
            };

            var topicQuestion1 = new Question
            {
                Id = 3,
                AudioFile = null,
                AudioId = null,
                QuestionType = QuestionType.Topic,
                Text = "Let’s talk about Great Britain. What do you know about this country?",
                LevelType = LevelType.Beginner
            };

            var topicQuestion2 = new Question
            {
                Id = 4,
                AudioFile = null,
                AudioId = null,
                QuestionType = QuestionType.Topic,
                Text = "Can you speak in your micro about nature (2 minutes)?",
                LevelType = LevelType.Beginner
            };

            builder.Entity<Question>().HasData(grammarQuestion, listeningQuestion, topicQuestion1, topicQuestion2);

            builder.Entity<Answer>().HasData(grammarAnswer1, grammarAnswer2, grammarAnswer3, grammarAnswer4,
                listeningAnswer1, listeningAnswer2, listeningAnswer3, listeningAnswer4, 
                topicAnswer1, topicAnswer2);
        }
    }
}
