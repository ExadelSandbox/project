using ExaLearn.Dal.Entities;
using Microsoft.EntityFrameworkCore;
using Shared.Enums;

namespace ExaLearn.Dal.Database
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.FillBeginnerLevelWithData();
            builder.FillAdvancedLevelWithData();
        }

        public static void FillBeginnerLevelWithData(this ModelBuilder builder)
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

        public static void FillAdvancedLevelWithData(this ModelBuilder builder)
        {
            #region grammar1
            var grammarQuestion1 = new Question
            {
                Id = 101,
                QuestionType = QuestionType.Grammar,
                Text = $"Until the eighteenth century comparative linguistic studies " +
                $"did not progress ------ - beyond the stage where ancient Greek and Roman " +
                $"grammarians had left them.",
                LevelType = LevelType.Advanced,
            };

            var answerGrammarQuestion11 = new Answer
            {
                Id = 201,
                QuestionId = 101,
                IsCorrect = false,
                Text = "so much as"
            };

            var answerGrammarQuestion12 = new Answer
            {
                Id = 202,
                QuestionId = 101,
                IsCorrect = false,
                Text = "too much"
            };

            var answerGrammarQuestion13 = new Answer
            {
                Id = 203,
                QuestionId = 101,
                IsCorrect = false,
                Text = "either"
            };

            var answerGrammarQuestion14 = new Answer
            {
                Id = 204,
                QuestionId = 101,
                IsCorrect = true,
                Text = "very much"
            };
            #endregion

            #region grammar2
            var grammarQuestion2 = new Question
            {
                Id = 102,
                QuestionType = QuestionType.Grammar,
                Text = $"Julius Caesar ------- a great historian if " +
                $"the making of history------ - him the time and the " +
                $"inclination to write it.",
                LevelType = LevelType.Advanced,
            };

            var answerGrammarQuestion21 = new Answer
            {
                Id = 205,
                QuestionId = 102,
                IsCorrect = false,
                Text = "could be / could have allowed"
            };

            var answerGrammarQuestion22 = new Answer
            {
                Id = 206,
                QuestionId = 102,
                IsCorrect = false,
                Text = "would be / allowed"
            };

            var answerGrammarQuestion23 = new Answer
            {
                Id = 207,
                QuestionId = 102,
                IsCorrect = false,
                Text = "had been / would have allowed"
            };

            var answerGrammarQuestion24 = new Answer
            {
                Id = 208,
                QuestionId = 102,
                IsCorrect = true,
                Text = "could have been / had allowed"
            };
            #endregion

            #region grammar3
            var grammarQuestion3 = new Question
            {
                Id = 103,
                QuestionType = QuestionType.Grammar,
                Text = $"Early in 1940, when Europe was already at war, " +
                $"Hitler ------ - the sale of uranium from the Czech mines he ------ - over.",
                LevelType = LevelType.Advanced,
            };

            var answerGrammarQuestion31 = new Answer
            {
                Id = 209,
                QuestionId = 103,
                IsCorrect = false,
                Text = "has banned / has taken"
            };

            var answerGrammarQuestion32 = new Answer
            {
                Id = 210,
                QuestionId = 103,
                IsCorrect = false,
                Text = "had banned / took"
            };

            var answerGrammarQuestion33 = new Answer
            {
                Id = 211,
                QuestionId = 103,
                IsCorrect = true,
                Text = "banned / had taken"
            };

            var answerGrammarQuestion34 = new Answer
            {
                Id = 212,
                QuestionId = 103,
                IsCorrect = false,
                Text = "bans / was taking"
            };
            #endregion

            #region grammar4
            var grammarQuestion4 = new Question
            {
                Id = 104,
                QuestionType = QuestionType.Grammar,
                Text = $"Physics, as it ------- at the end of the nineteenth " +
                $"century, -------to as classical physics.",
                LevelType = LevelType.Advanced,
            };

            var answerGrammarQuestion41 = new Answer
            {
                Id = 213,
                QuestionId = 104,
                IsCorrect = false,
                Text = "has been known / might be referred"
            };

            var answerGrammarQuestion42 = new Answer
            {
                Id = 214,
                QuestionId = 104,
                IsCorrect = false,
                Text = "is known / has been"
            };

            var answerGrammarQuestion43 = new Answer
            {
                Id = 215,
                QuestionId = 104,
                IsCorrect = false,
                Text = "had been known / had been referred"
            };

            var answerGrammarQuestion44 = new Answer
            {
                Id = 216,
                QuestionId = 104,
                IsCorrect = true,
                Text = "was known / is referred"
            };
            #endregion

            #region grammar5
            var grammarQuestion5 = new Question
            {
                Id = 105,
                QuestionType = QuestionType.Grammar,
                Text = $"Sometimes people select certain foods that they " +
                $"believe------ - their physical appearance and avoid those they " +
                $"believe------ - detrimental.",
                LevelType = LevelType.Advanced,
            };

            var answerGrammarQuestion51 = new Answer
            {
                Id = 217,
                QuestionId = 105,
                IsCorrect = false,
                Text = "have improved / would have been"
            };

            var answerGrammarQuestion52 = new Answer
            {
                Id = 218,
                QuestionId = 105,
                IsCorrect = false,
                Text = "are improving / were"
            };

            var answerGrammarQuestion53 = new Answer
            {
                Id = 219,
                QuestionId = 105,
                IsCorrect = true,
                Text = "improve / might be"
            };

            var answerGrammarQuestion54 = new Answer
            {
                Id = 220,
                QuestionId = 105,
                IsCorrect = false,
                Text = "improved / had been"
            };
            #endregion

            builder.Entity<Question>().HasData(grammarQuestion1, grammarQuestion2, grammarQuestion3, grammarQuestion4, grammarQuestion5);

            builder.Entity<Answer>().HasData(
                answerGrammarQuestion11, answerGrammarQuestion12, answerGrammarQuestion13, answerGrammarQuestion14,
                answerGrammarQuestion21, answerGrammarQuestion22, answerGrammarQuestion23, answerGrammarQuestion24,
                answerGrammarQuestion31, answerGrammarQuestion32, answerGrammarQuestion33, answerGrammarQuestion34,
                answerGrammarQuestion41, answerGrammarQuestion42, answerGrammarQuestion43, answerGrammarQuestion44,
                answerGrammarQuestion51, answerGrammarQuestion52, answerGrammarQuestion53, answerGrammarQuestion54
               );
        }
    }
}
