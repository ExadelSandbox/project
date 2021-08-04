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
            #region BeginnerGrammarQuestions
            var grammarQuestion1 = new Question
            {
                Id = 1,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "Capital of the England?",
                LevelType = LevelType.Beginner
            };
            var grammarQuestion2 = new Question
            {
                Id = 2,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "How many major verb tenses are in english?",
                LevelType = LevelType.Beginner
            };
            var grammarQuestion3 = new Question
            {
                Id = 3,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "Second verb form of \"read\"?",
                LevelType = LevelType.Beginner
            };
            var grammarQuestion4 = new Question
            {
                Id = 4,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "Third verb form of \"swim\"?",
                LevelType = LevelType.Beginner
            };
            var grammarQuestion5 = new Question
            {
                Id = 5,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "Joe ___ a good driver",
                LevelType = LevelType.Beginner
            };
            var grammarQuestion6 = new Question
            {
                Id = 6,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "Look! The boys ___ running!",
                LevelType = LevelType.Beginner
            };
            var grammarQuestion7 = new Question
            {
                Id = 7,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "\"Be\" verb in past simple",
                LevelType = LevelType.Beginner
            };
            var grammarQuestion8 = new Question
            {
                Id = 8,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "I ___ at home yesterday",
                LevelType = LevelType.Beginner
            };
            var grammarQuestion9 = new Question
            {
                Id = 9,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "There ___ a one apple left",
                LevelType = LevelType.Beginner
            };
            var grammarQuestion10 = new Question
            {
                Id = 10,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "___ did she go?",
                LevelType = LevelType.Beginner
            };
            #endregion

            #region BeginnerGrammarAnswers
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

            var grammarAnswer5 = new Answer
            {
                Id = 5,
                QuestionId = 2,
                IsCorrect = false,
                Text = "14"
            };
            var grammarAnswer6 = new Answer
            {
                Id = 6,
                QuestionId = 2,
                IsCorrect = true,
                Text = "12"
            };
            var grammarAnswer7 = new Answer
            {
                Id = 7,
                QuestionId = 2,
                IsCorrect = false,
                Text = "16"
            };
            var grammarAnswer8 = new Answer
            {
                Id = 8,
                QuestionId = 2,
                IsCorrect = false,
                Text = "10"
            };

            var grammarAnswer9 = new Answer
            {
                Id = 9,
                QuestionId = 3,
                IsCorrect = true,
                Text = "Read"
            };
            var grammarAnswer10 = new Answer
            {
                Id = 10,
                QuestionId = 3,
                IsCorrect = false,
                Text = "Rat"
            };
            var grammarAnswer11 = new Answer
            {
                Id = 11,
                QuestionId = 3,
                IsCorrect = false,
                Text = "Red"
            };
            var grammarAnswer12 = new Answer
            {
                Id = 12,
                QuestionId = 3,
                IsCorrect = false,
                Text = "Road"
            };

            var grammarAnswer13 = new Answer
            {
                Id = 13,
                QuestionId = 4,
                IsCorrect = false,
                Text = "Swim"
            };
            var grammarAnswer14 = new Answer
            {
                Id = 14,
                QuestionId = 4,
                IsCorrect = false,
                Text = "Swam"
            };
            var grammarAnswer15 = new Answer
            {
                Id = 15,
                QuestionId = 4,
                IsCorrect = true,
                Text = "Swum"
            };
            var grammarAnswer16 = new Answer
            {
                Id = 16,
                QuestionId = 4,
                IsCorrect = false,
                Text = "Slim"
            };

            var grammarAnswer17 = new Answer
            {
                Id = 17,
                QuestionId = 5,
                IsCorrect = false,
                Text = "are"
            };
            var grammarAnswer18 = new Answer
            {
                Id = 18,
                QuestionId = 5,
                IsCorrect = true,
                Text = "is"
            };
            var grammarAnswer19 = new Answer
            {
                Id = 19,
                QuestionId = 5,
                IsCorrect = false,
                Text = "am"
            };
            var grammarAnswer20 = new Answer
            {
                Id = 20,
                QuestionId = 5,
                IsCorrect = false,
                Text = "he"
            };

            var grammarAnswer21 = new Answer
            {
                Id = 21,
                QuestionId = 6,
                IsCorrect = true,
                Text = "are"
            };
            var grammarAnswer22 = new Answer
            {
                Id = 22,
                QuestionId = 6,
                IsCorrect = false,
                Text = "am"
            };
            var grammarAnswer23 = new Answer
            {
                Id = 23,
                QuestionId = 6,
                IsCorrect = false,
                Text = "they"
            };
            var grammarAnswer24 = new Answer
            {
                Id = 24,
                QuestionId = 6,
                IsCorrect = false,
                Text = "is"
            };

            var grammarAnswer25 = new Answer
            {
                Id = 25,
                QuestionId = 7,
                IsCorrect = false,
                Text = "will be"
            };
            var grammarAnswer26 = new Answer
            {
                Id = 26,
                QuestionId = 7,
                IsCorrect = false,
                Text = "be"
            };
            var grammarAnswer27 = new Answer
            {
                Id = 27,
                QuestionId = 7,
                IsCorrect = true,
                Text = "was/were"
            };
            var grammarAnswer28 = new Answer
            {
                Id = 28,
                QuestionId = 7,
                IsCorrect = false,
                Text = "has"
            };

            var grammarAnswer29 = new Answer
            {
                Id = 29,
                QuestionId = 8,
                IsCorrect = true,
                Text = "was"
            };
            var grammarAnswer30 = new Answer
            {
                Id = 30,
                QuestionId = 8,
                IsCorrect = false,
                Text = "will be"
            };
            var grammarAnswer31 = new Answer
            {
                Id = 31,
                QuestionId = 8,
                IsCorrect = false,
                Text = "is"
            };
            var grammarAnswer32 = new Answer
            {
                Id = 32,
                QuestionId = 8,
                IsCorrect = false,
                Text = "were"
            };

            var grammarAnswer33 = new Answer
            {
                Id = 33,
                QuestionId = 9,
                IsCorrect = false,
                Text = "will be"
            };
            var grammarAnswer34 = new Answer
            {
                Id = 34,
                QuestionId = 9,
                IsCorrect = false,
                Text = "am"
            };
            var grammarAnswer35 = new Answer
            {
                Id = 35,
                QuestionId = 9,
                IsCorrect = false,
                Text = "are"
            };
            var grammarAnswer36 = new Answer
            {
                Id = 36,
                QuestionId = 9,
                IsCorrect = true,
                Text = "is"
            };

            var grammarAnswer37 = new Answer
            {
                Id = 37,
                QuestionId = 10,
                IsCorrect = true,
                Text = "Where"
            };
            var grammarAnswer38 = new Answer
            {
                Id = 38,
                QuestionId = 10,
                IsCorrect = false,
                Text = "Who"
            };
            var grammarAnswer39 = new Answer
            {
                Id = 39,
                QuestionId = 10,
                IsCorrect = false,
                Text = "Which"
            };
            var grammarAnswer40 = new Answer
            {
                Id = 40,
                QuestionId = 10,
                IsCorrect = false,
                Text = "How many"
            };
            #endregion

            #region BeginnerListeningQuestions
            var listeningQuestion1 = new Question
            {
                Id = 11,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "The most common animal?",
                LevelType = LevelType.Beginner
            };
            var listeningQuestion2 = new Question
            {
                Id = 12,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "Cats' lifespan?",
                LevelType = LevelType.Beginner
            };
            var listeningQuestion3 = new Question
            {
                Id = 13,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "Dogs' lifespan?",
                LevelType = LevelType.Beginner
            };
            var listeningQuestion4 = new Question
            {
                Id = 14,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "The main ingredient of the butter?",
                LevelType = LevelType.Beginner
            };
            var listeningQuestion5 = new Question
            {
                Id = 15,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "Wolfs are: ",
                LevelType = LevelType.Beginner
            };
            var listeningQuestion6 = new Question
            {
                Id = 16,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "Cows are: ",
                LevelType = LevelType.Beginner
            };
            var listeningQuestion7 = new Question
            {
                Id = 17,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "Humans are: ",
                LevelType = LevelType.Beginner
            };
            var listeningQuestion8 = new Question
            {
                Id = 18,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "How tall is the tallest tree?",
                LevelType = LevelType.Beginner
            };
            var listeningQuestion9 = new Question
            {
                Id = 19,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "The largest forest in the world?",
                LevelType = LevelType.Beginner
            };
            var listeningQuestion10 = new Question
            {
                Id = 20,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "The biggest ocean on the planet?",
                LevelType = LevelType.Beginner
            };
            #endregion

            #region BeginnerListeningAnswers
            var listeningAnswer1 = new Answer
            {
                Id = 41,
                QuestionId = 11,
                IsCorrect = true,
                Text = "Cat"
            };
            var listeningAnswer2 = new Answer
            {
                Id = 42,
                QuestionId = 11,
                IsCorrect = false,
                Text = "Dog"
            };
            var listeningAnswer3 = new Answer
            {
                Id = 43,
                QuestionId = 11,
                IsCorrect = false,
                Text = "Cow"
            };
            var listeningAnswer4 = new Answer
            {
                Id = 44,
                QuestionId = 11,
                IsCorrect = false,
                Text = "Goat"
            };

            var listeningAnswer5 = new Answer
            {
                Id = 45,
                QuestionId = 12,
                IsCorrect = true,
                Text = "2-16 years"
            };
            var listeningAnswer6 = new Answer
            {
                Id = 46,
                QuestionId = 12,
                IsCorrect = false,
                Text = "1-4 years"
            };
            var listeningAnswer7 = new Answer
            {
                Id = 47,
                QuestionId = 12,
                IsCorrect = false,
                Text = "16-24 years"
            };
            var listeningAnswer8 = new Answer
            {
                Id = 48,
                QuestionId = 12,
                IsCorrect = false,
                Text = "5-10 years"
            };

            var listeningAnswer9 = new Answer
            {
                Id = 49,
                QuestionId = 13,
                IsCorrect = true,
                Text = "10-13 years"
            };
            var listeningAnswer10 = new Answer
            {
                Id = 50,
                QuestionId = 13,
                IsCorrect = false,
                Text = "5-10 years"
            };
            var listeningAnswer11 = new Answer
            {
                Id = 51,
                QuestionId = 13,
                IsCorrect = false,
                Text = "2-16 years"
            };
            var listeningAnswer12 = new Answer
            {
                Id = 52,
                QuestionId = 13,
                IsCorrect = false,
                Text = "1-2 years"
            };

            var listeningAnswer13 = new Answer
            {
                Id = 53,
                QuestionId = 14,
                IsCorrect = true,
                Text = "Milk"
            };
            var listeningAnswer14 = new Answer
            {
                Id = 54,
                QuestionId = 14,
                IsCorrect = false,
                Text = "Sugar"
            };
            var listeningAnswer15 = new Answer
            {
                Id = 55,
                QuestionId = 14,
                IsCorrect = false,
                Text = "Salt"
            };
            var listeningAnswer16 = new Answer
            {
                Id = 56,
                QuestionId = 14,
                IsCorrect = false,
                Text = "Oil"
            };

            var listeningAnswer17 = new Answer
            {
                Id = 57,
                QuestionId = 15,
                IsCorrect = true,
                Text = "Carnivorous"
            };
            var listeningAnswer18 = new Answer
            {
                Id = 58,
                QuestionId = 15,
                IsCorrect = false,
                Text = "Herbivorous"
            };
            var listeningAnswer19 = new Answer
            {
                Id = 59,
                QuestionId = 15,
                IsCorrect = false,
                Text = "Omnivorous"
            };
            var listeningAnswer20 = new Answer
            {
                Id = 60,
                QuestionId = 15,
                IsCorrect = false,
                Text = "Vegeterian"
            };

            var listeningAnswer21 = new Answer
            {
                Id = 61,
                QuestionId = 16,
                IsCorrect = false,
                Text = "Carnivorous"
            };
            var listeningAnswer22 = new Answer
            {
                Id = 62,
                QuestionId = 16,
                IsCorrect = true,
                Text = "Herbivorous"
            };
            var listeningAnswer23 = new Answer
            {
                Id = 63,
                QuestionId = 16,
                IsCorrect = false,
                Text = "Omnivorous"
            };
            var listeningAnswer24 = new Answer
            {
                Id = 64,
                QuestionId = 16,
                IsCorrect = false,
                Text = "Vegeterian"
            };

            var listeningAnswer25 = new Answer
            {
                Id = 65,
                QuestionId = 17,
                IsCorrect = false,
                Text = "Carnivorous"
            };
            var listeningAnswer26 = new Answer
            {
                Id = 66,
                QuestionId = 17,
                IsCorrect = false,
                Text = "Herbivorous"
            };
            var listeningAnswer27 = new Answer
            {
                Id = 67,
                QuestionId = 17,
                IsCorrect = true,
                Text = "Omnivorous"
            };
            var listeningAnswer28 = new Answer
            {
                Id = 68,
                QuestionId = 17,
                IsCorrect = false,
                Text = "Vegeterian"
            };

            var listeningAnswer29 = new Answer
            {
                Id = 69,
                QuestionId = 18,
                IsCorrect = true,
                Text = "115.7 meters"
            };
            var listeningAnswer30 = new Answer
            {
                Id = 70,
                QuestionId = 18,
                IsCorrect = false,
                Text = "110 meters"
            };
            var listeningAnswer31 = new Answer
            {
                Id = 71,
                QuestionId = 18,
                IsCorrect = false,
                Text = "100 meters"
            };
            var listeningAnswer32 = new Answer
            {
                Id = 72,
                QuestionId = 18,
                IsCorrect = false,
                Text = "90 meters"
            };

            var listeningAnswer33 = new Answer
            {
                Id = 73,
                QuestionId = 19,
                IsCorrect = true,
                Text = "The Amazon"
            };
            var listeningAnswer34 = new Answer
            {
                Id = 74,
                QuestionId = 19,
                IsCorrect = false,
                Text = "Yakushima Forest"
            };
            var listeningAnswer35 = new Answer
            {
                Id = 75,
                QuestionId = 19,
                IsCorrect = false,
                Text = "Waipoua Forest"
            };
            var listeningAnswer36 = new Answer
            {
                Id = 76,
                QuestionId = 19,
                IsCorrect = false,
                Text = "The Araucaria Forest"
            };

            var listeningAnswer37 = new Answer
            {
                Id = 77,
                QuestionId = 20,
                IsCorrect = true,
                Text = "The Pacific Ocean"
            };
            var listeningAnswer38 = new Answer
            {
                Id = 78,
                QuestionId = 20,
                IsCorrect = false,
                Text = "The Atlantic Ocean"
            };
            var listeningAnswer39 = new Answer
            {
                Id = 79,
                QuestionId = 20,
                IsCorrect = false,
                Text = "The Indian Ocean"
            };
            var listeningAnswer40 = new Answer
            {
                Id = 80,
                QuestionId = 20,
                IsCorrect = false,
                Text = "The Arctic Ocean"
            };
            #endregion

            #region BeginnerTopics
            var topic1 = new Question
            {
                Id = 21,
                QuestionType = QuestionType.Topic,
                Text = "Lets talk about Great Britain. What do you know about this country?",
            };
            var topic2 = new Question
            {
                Id = 22,
                QuestionType = QuestionType.Topic,
                Text = "Can you tell about nature?",
            };
            var topic3 = new Question
            {
                Id = 23,
                QuestionType = QuestionType.Topic,
                Text = "Can you tell about summer holidays?",
            };
            var topic4 = new Question
            {
                Id = 24,
                QuestionType = QuestionType.Topic,
                Text = "Can you tell about your first friend?",
            };
            var topic5 = new Question
            {
                Id = 25,
                QuestionType = QuestionType.Topic,
                Text = "Can you tell about your favorite animal?",
            };
            #endregion

            builder.Entity<Question>().HasData(grammarQuestion1, grammarQuestion2, grammarQuestion3, grammarQuestion4, grammarQuestion5,
                grammarQuestion6, grammarQuestion7, grammarQuestion8, grammarQuestion9, grammarQuestion10);
            builder.Entity<Answer>().HasData(grammarAnswer1, grammarAnswer2, grammarAnswer3, grammarAnswer4,
                grammarAnswer5, grammarAnswer6, grammarAnswer7, grammarAnswer8, grammarAnswer9, grammarAnswer10,
                grammarAnswer11, grammarAnswer12, grammarAnswer13, grammarAnswer14, grammarAnswer15, grammarAnswer16,
                grammarAnswer17, grammarAnswer18, grammarAnswer19, grammarAnswer20, grammarAnswer21, grammarAnswer22,
                grammarAnswer23, grammarAnswer24, grammarAnswer25, grammarAnswer26, grammarAnswer27, grammarAnswer28,
                grammarAnswer29, grammarAnswer30, grammarAnswer31, grammarAnswer32, grammarAnswer33, grammarAnswer34,
                grammarAnswer35, grammarAnswer36, grammarAnswer37, grammarAnswer38, grammarAnswer39, grammarAnswer40);

            builder.Entity<Question>().HasData(listeningQuestion1, listeningQuestion2, listeningQuestion3, listeningQuestion4,
                listeningQuestion5, listeningQuestion6, listeningQuestion7, listeningQuestion8, listeningQuestion9, listeningQuestion10);
            builder.Entity<Answer>().HasData(listeningAnswer1, listeningAnswer2, listeningAnswer3, listeningAnswer4, listeningAnswer5,
                listeningAnswer6, listeningAnswer7, listeningAnswer8, listeningAnswer9, listeningAnswer10, listeningAnswer11,
                listeningAnswer12, listeningAnswer13, listeningAnswer14, listeningAnswer15, listeningAnswer16, listeningAnswer17,
                listeningAnswer18, listeningAnswer19, listeningAnswer20, listeningAnswer21, listeningAnswer22, listeningAnswer23,
                listeningAnswer24, listeningAnswer25, listeningAnswer26, listeningAnswer27, listeningAnswer28, listeningAnswer29,
                listeningAnswer30, listeningAnswer31, listeningAnswer32, listeningAnswer33, listeningAnswer34, listeningAnswer35,
                listeningAnswer36, listeningAnswer37, listeningAnswer38, listeningAnswer39, listeningAnswer40);

            builder.Entity<Question>().HasData(topic1, topic2, topic3, topic4, topic5);
        }

        public static void FillAdvancedLevelWithData(this ModelBuilder builder)
        {
            #region grammars
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

            #region grammar6
            var grammarQuestion6 = new Question
            {
                Id = 106,
                QuestionType = QuestionType.Grammar,
                Text = $"It is not unusual for advertising campaigns ------- even " +
                $"before the new products ------ - onto the market.",
                LevelType = LevelType.Advanced,
            };

            var answerGrammarQuestion61 = new Answer
            {
                Id = 221,
                QuestionId = 106,
                IsCorrect = false,
                Text = "to have been launched / have come"
            };

            var answerGrammarQuestion62 = new Answer
            {
                Id = 222,
                QuestionId = 106,
                IsCorrect = true,
                Text = "to be launched / come"
            };

            var answerGrammarQuestion63 = new Answer
            {
                Id = 223,
                QuestionId = 106,
                IsCorrect = false,
                Text = "being launched / will come"
            };

            var answerGrammarQuestion64 = new Answer
            {
                Id = 224,
                QuestionId = 106,
                IsCorrect = false,
                Text = "having been launched / are coming"
            };
            #endregion

            #region grammar7
            var grammarQuestion7 = new Question
            {
                Id = 107,
                QuestionType = QuestionType.Grammar,
                Text = $"Much health education in recent years ------- towards the view " +
                $"that heavy drinker------ - subject for amusement but for practical help.",
                LevelType = LevelType.Advanced,
            };

            var answerGrammarQuestion71 = new Answer
            {
                Id = 225,
                QuestionId = 107,
                IsCorrect = true,
                Text = "has been directed / is not"
            };

            var answerGrammarQuestion72 = new Answer
            {
                Id = 226,
                QuestionId = 107,
                IsCorrect = false,
                Text = "was being directed / wouldn't be"
            };

            var answerGrammarQuestion73 = new Answer
            {
                Id = 227,
                QuestionId = 107,
                IsCorrect = false,
                Text = "is directed / won't be"
            };

            var answerGrammarQuestion74 = new Answer
            {
                Id = 228,
                QuestionId = 107,
                IsCorrect = false,
                Text = "had been directed / was not"
            };
            #endregion

            #region grammar8
            var grammarQuestion8 = new Question
            {
                Id = 108,
                QuestionType = QuestionType.Grammar,
                Text = $"Galileo originated the method of controlled experiment------ " +
                $"- now forms the basis of scientific investigation.",
                LevelType = LevelType.Advanced,
            };

            var answerGrammarQuestion81 = new Answer
            {
                Id = 229,
                QuestionId = 108,
                IsCorrect = false,
                Text = "what"
            };

            var answerGrammarQuestion82 = new Answer
            {
                Id = 230,
                QuestionId = 108,
                IsCorrect = false,
                Text = "who"
            };

            var answerGrammarQuestion83 = new Answer
            {
                Id = 231,
                QuestionId = 108,
                IsCorrect = false,
                Text = "where"
            };

            var answerGrammarQuestion84 = new Answer
            {
                Id = 232,
                QuestionId = 108,
                IsCorrect = true,
                Text = "which"
            };
            #endregion

            #region grammar9
            var grammarQuestion9 = new Question
            {
                Id = 109,
                QuestionType = QuestionType.Grammar,
                Text = $"Unfortunately, the world's forest -------- at such a rate that the remaining tropical rainforests------ - by the middle of the century.",
                LevelType = LevelType.Advanced,
            };

            var answerGrammarQuestion91 = new Answer
            {
                Id = 233,
                QuestionId = 109,
                IsCorrect = false,
                Text = "will be logged / would have been destroyed"
            };

            var answerGrammarQuestion92 = new Answer
            {
                Id = 234,
                QuestionId = 109,
                IsCorrect = false,
                Text = "has been logged / is destroyed"
            };

            var answerGrammarQuestion93 = new Answer
            {
                Id = 235,
                QuestionId = 109,
                IsCorrect = true,
                Text = "is being logged / will have been destroyed"
            };

            var answerGrammarQuestion94 = new Answer
            {
                Id = 236,
                QuestionId = 109,
                IsCorrect = false,
                Text = "was being logged / is being destroyed"
            };
            #endregion

            #region grammar10
            var grammarQuestion10 = new Question
            {
                Id = 110,
                QuestionType = QuestionType.Grammar,
                Text = $"The continuing controversy -------- in 1924 by P. Hubble, " +
                $"who found that the great spiral nebula in Andromeda-------- Cepheld variables.",
                LevelType = LevelType.Advanced,
            };

            var answerGrammarQuestion101 = new Answer
            {
                Id = 237,
                QuestionId = 110,
                IsCorrect = false,
                Text = "was being settled / has contained"
            };

            var answerGrammarQuestion102 = new Answer
            {
                Id = 238,
                QuestionId = 110,
                IsCorrect = false,
                Text = "has been settled / contains"
            };

            var answerGrammarQuestion103 = new Answer
            {
                Id = 239,
                QuestionId = 110,
                IsCorrect = false,
                Text = "had been settled / contained"
            };

            var answerGrammarQuestion104 = new Answer
            {
                Id = 240,
                QuestionId = 110,
                IsCorrect = true,
                Text = "was settled / contained"
            };
            #endregion

            builder.Entity<Question>().HasData(
               grammarQuestion1, grammarQuestion2, grammarQuestion3, grammarQuestion4, grammarQuestion5,
               grammarQuestion6, grammarQuestion7, grammarQuestion8, grammarQuestion9, grammarQuestion10);

            builder.Entity<Answer>().HasData(
                answerGrammarQuestion11, answerGrammarQuestion12, answerGrammarQuestion13, answerGrammarQuestion14,
                answerGrammarQuestion21, answerGrammarQuestion22, answerGrammarQuestion23, answerGrammarQuestion24,
                answerGrammarQuestion31, answerGrammarQuestion32, answerGrammarQuestion33, answerGrammarQuestion34,
                answerGrammarQuestion41, answerGrammarQuestion42, answerGrammarQuestion43, answerGrammarQuestion44,
                answerGrammarQuestion51, answerGrammarQuestion52, answerGrammarQuestion53, answerGrammarQuestion54,
                answerGrammarQuestion61, answerGrammarQuestion62, answerGrammarQuestion63, answerGrammarQuestion64,
                answerGrammarQuestion71, answerGrammarQuestion72, answerGrammarQuestion73, answerGrammarQuestion74,
                answerGrammarQuestion81, answerGrammarQuestion82, answerGrammarQuestion83, answerGrammarQuestion84,
                answerGrammarQuestion91, answerGrammarQuestion92, answerGrammarQuestion93, answerGrammarQuestion94,
                answerGrammarQuestion101, answerGrammarQuestion102, answerGrammarQuestion103, answerGrammarQuestion104
               );
            #endregion

            #region topics
            var topic1 = new Question
            {
                Id = 111,
                QuestionType = QuestionType.Topic,
                Text = "Coronavirus",
            };

            var topic2 = new Question
            {
                Id = 112,
                QuestionType = QuestionType.Topic,
                Text = "Electric cars",
            };

            var topic3 = new Question
            {
                Id = 113,
                QuestionType = QuestionType.Topic,
                Text = "Rich world, poor world.",
            };

            var topic4 = new Question
            {
                Id = 114,
                QuestionType = QuestionType.Topic,
                Text = "Childhood trends",
            };

            var topic5 = new Question
            {
                Id = 115,
                QuestionType = QuestionType.Topic,
                Text = "Parenting",
            };

            builder.Entity<Question>().HasData(topic1, topic2, topic3, topic4, topic5);
            #endregion
        }
    }
}
