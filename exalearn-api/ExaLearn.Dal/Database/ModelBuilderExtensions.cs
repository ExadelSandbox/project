using ExaLearn.Dal.Entities;
using Microsoft.EntityFrameworkCore;
using Shared.Enums;

namespace ExaLearn.Dal.Database
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.FillBeginnerLevelWithData()
                   .FillElementaryLevelWithData()
                   .FillIntermediateWithData();
        }

        public static ModelBuilder FillBeginnerLevelWithData(this ModelBuilder builder)
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
                Id = 41,
                QuestionType = QuestionType.Topic,
                Text = "Lets talk about Great Britain. What do you know about this country?",
            };
            var topic2 = new Question
            {
                Id = 42,
                QuestionType = QuestionType.Topic,
                Text = "Can you tell about nature?",
            };
            var topic3 = new Question
            {
                Id = 43,
                QuestionType = QuestionType.Topic,
                Text = "Can you tell about summer holidays?",
            };
            var topic4 = new Question
            {
                Id = 44,
                QuestionType = QuestionType.Topic,
                Text = "Can you tell about your first friend?",
            };
            var topic5 = new Question
            {
                Id = 45,
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

            return builder;
        }

        public static ModelBuilder FillIntermediateWithData(this ModelBuilder builder)
        {
            #region IntermediateGrammarQuestions
            var grammarQuestion1 = new Question
            {
                Id = 21,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "I ______ to that restaurant. The food is very good.",
                LevelType = LevelType.Intermediate
            };
            var grammarQuestion2 = new Question
            {
                Id = 22,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "Her parents didn't want ________ watch T.V.",
                LevelType = LevelType.Intermediate
            };
            var grammarQuestion3 = new Question
            {
                Id = 23,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "We knew that she ______ waiting for the the results of her English test.",
                LevelType = LevelType.Intermediate
            };
            var grammarQuestion4 = new Question
            {
                Id = 24,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "You can't pass your grammar test without ________.",
                LevelType = LevelType.Intermediate
            };
            var grammarQuestion5 = new Question
            {
                Id = 25,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "When the postman came, I _________ a shower.",
                LevelType = LevelType.Intermediate
            };
            var grammarQuestion6 = new Question
            {
                Id = 26,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "He didn't remember that we ________ before.",
                LevelType = LevelType.Intermediate
            };
            var grammarQuestion7 = new Question
            {
                Id = 27,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "Tomorrow is Saturday so she ________ work. It's her day off.",
                LevelType = LevelType.Intermediate
            };
            var grammarQuestion8 = new Question
            {
                Id = 28,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "He met her at school. They have been friends _____ years.",
                LevelType = LevelType.Intermediate
            };
            var grammarQuestion9 = new Question
            {
                Id = 29,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "She looks ______ a secretary.",
                LevelType = LevelType.Intermediate
            };
            var grammarQuestion10 = new Question
            {
                Id = 30,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "She asked if I would like ______ on a date with her.",
                LevelType = LevelType.Intermediate
            };
            #endregion

            #region IntermediateGrammarAnswers
            var grammarAnswer1 = new Answer
            {
                Id = 81,
                QuestionId = 21,
                IsCorrect = false,
                Text = "often have been"
            };
            var grammarAnswer2 = new Answer
            {
                Id = 82,
                QuestionId = 21,
                IsCorrect = false,
                Text = "have been often"
            };
            var grammarAnswer3 = new Answer
            {
                Id = 83,
                QuestionId = 21,
                IsCorrect = true,
                Text = "have often been"
            };
            var grammarAnswer4 = new Answer
            {
                Id = 84,
                QuestionId = 21,
                IsCorrect = false,
                Text = "has often been"
            };

            var grammarAnswer5 = new Answer
            {
                Id = 85,
                QuestionId = 22,
                IsCorrect = true,
                Text = "her to watch"
            };
            var grammarAnswer6 = new Answer
            {
                Id = 86,
                QuestionId = 22,
                IsCorrect = false,
                Text = "her watch"
            };
            var grammarAnswer7 = new Answer
            {
                Id = 87,
                QuestionId = 22,
                IsCorrect = false,
                Text = "that she watch"
            };
            var grammarAnswer8 = new Answer
            {
                Id = 88,
                QuestionId = 22,
                IsCorrect = false,
                Text = "so she watch"
            };

            var grammarAnswer9 = new Answer
            {
                Id = 89,
                QuestionId = 23,
                IsCorrect = false,
                Text = "is"
            };
            var grammarAnswer10 = new Answer
            {
                Id = 90,
                QuestionId = 23,
                IsCorrect = false,
                Text = "would"
            };
            var grammarAnswer11 = new Answer
            {
                Id = 91,
                QuestionId = 23,
                IsCorrect = false,
                Text = "had been"
            };
            var grammarAnswer12 = new Answer
            {
                Id = 92,
                QuestionId = 23,
                IsCorrect = true,
                Text = "was "
            };

            var grammarAnswer13 = new Answer
            {
                Id = 93,
                QuestionId = 24,
                IsCorrect = false,
                Text = "you study"
            };
            var grammarAnswer14 = new Answer
            {
                Id = 94,
                QuestionId = 24,
                IsCorrect = true,
                Text = "studying"
            };
            var grammarAnswer15 = new Answer
            {
                Id = 95,
                QuestionId = 24,
                IsCorrect = false,
                Text = "to study"
            };
            var grammarAnswer16 = new Answer
            {
                Id = 96,
                QuestionId = 24,
                IsCorrect = false,
                Text = "are studying"
            };

            var grammarAnswer17 = new Answer
            {
                Id = 97,
                QuestionId = 25,
                IsCorrect = true,
                Text = "was having"
            };
            var grammarAnswer18 = new Answer
            {
                Id = 98,
                QuestionId = 25,
                IsCorrect = false,
                Text = "had"
            };
            var grammarAnswer19 = new Answer
            {
                Id = 99,
                QuestionId = 25,
                IsCorrect = false,
                Text = "have been having"
            };
            var grammarAnswer20 = new Answer
            {
                Id = 100,
                QuestionId = 25,
                IsCorrect = false,
                Text = "had been having"
            };

            var grammarAnswer21 = new Answer
            {
                Id = 101,
                QuestionId = 26,
                IsCorrect = false,
                Text = "were meeting"
            };
            var grammarAnswer22 = new Answer
            {
                Id = 102,
                QuestionId = 26,
                IsCorrect = false,
                Text = "met"
            };
            var grammarAnswer23 = new Answer
            {
                Id = 103,
                QuestionId = 26,
                IsCorrect = false,
                Text = "meet"
            };
            var grammarAnswer24 = new Answer
            {
                Id = 104,
                QuestionId = 26,
                IsCorrect = true,
                Text = "had met"
            };

            var grammarAnswer25 = new Answer
            {
                Id = 105,
                QuestionId = 27,
                IsCorrect = false,
                Text = "wouldn't"
            };
            var grammarAnswer26 = new Answer
            {
                Id = 106,
                QuestionId = 27,
                IsCorrect = false,
                Text = "mustn't"
            };
            var grammarAnswer27 = new Answer
            {
                Id = 107,
                QuestionId = 27,
                IsCorrect = true,
                Text = "doesn't have to"
            };
            var grammarAnswer28 = new Answer
            {
                Id = 108,
                QuestionId = 27,
                IsCorrect = false,
                Text = "hasn't"
            };

            var grammarAnswer29 = new Answer
            {
                Id = 109,
                QuestionId = 28,
                IsCorrect = false,
                Text = "until"
            };
            var grammarAnswer30 = new Answer
            {
                Id = 110,
                QuestionId = 28,
                IsCorrect = true,
                Text = "for"
            };
            var grammarAnswer31 = new Answer
            {
                Id = 111,
                QuestionId = 28,
                IsCorrect = false,
                Text = "since"
            };
            var grammarAnswer32 = new Answer
            {
                Id = 112,
                QuestionId = 28,
                IsCorrect = false,
                Text = "many"
            };

            var grammarAnswer33 = new Answer
            {
                Id = 113,
                QuestionId = 29,
                IsCorrect = false,
                Text = "the same as"
            };
            var grammarAnswer34 = new Answer
            {
                Id = 114,
                QuestionId = 29,
                IsCorrect = false,
                Text = "the same like"
            };
            var grammarAnswer35 = new Answer
            {
                Id = 115,
                QuestionId = 29,
                IsCorrect = false,
                Text = "as"
            };
            var grammarAnswer36 = new Answer
            {
                Id = 116,
                QuestionId = 29,
                IsCorrect = true,
                Text = "like"
            };

            var grammarAnswer37 = new Answer
            {
                Id = 117,
                QuestionId = 30,
                IsCorrect = true,
                Text = "to go"
            };
            var grammarAnswer38 = new Answer
            {
                Id = 118,
                QuestionId = 30,
                IsCorrect = false,
                Text = "going"
            };
            var grammarAnswer39 = new Answer
            {
                Id = 119,
                QuestionId = 30,
                IsCorrect = false,
                Text = "go"
            };
            var grammarAnswer40 = new Answer
            {
                Id = 120,
                QuestionId = 30,
                IsCorrect = false,
                Text = "to went"
            };
            #endregion

            #region IntermediateListeningQuestions
            var listeningQuestion1 = new Question
            {
                Id = 31,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "We spend a lot of time _____ the internet.",
                LevelType = LevelType.Intermediate
            };
            var listeningQuestion2 = new Question
            {
                Id = 32,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "Have you heard the news? Jane ________ have a baby!",
                LevelType = LevelType.Intermediate
            };
            var listeningQuestion3 = new Question
            {
                Id = 33,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "She always listens _______ music on her phone",
                LevelType = LevelType.Intermediate
            };
            var listeningQuestion4 = new Question
            {
                Id = 34,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "He _____ the answers during his English test.",
                LevelType = LevelType.Intermediate
            };
            var listeningQuestion5 = new Question
            {
                Id = 35,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "You need a key ____ the box.",
                LevelType = LevelType.Intermediate
            };
            var listeningQuestion6 = new Question
            {
                Id = 36,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "I went to the supermarket _____ milk.",
                LevelType = LevelType.Intermediate
            };
            var listeningQuestion7 = new Question
            {
                Id = 37,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "I don't know ________.",
                LevelType = LevelType.Intermediate
            };
            var listeningQuestion8 = new Question
            {
                Id = 38,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "Try _____ forget.",
                LevelType = LevelType.Intermediate
            };
            var listeningQuestion9 = new Question
            {
                Id = 39,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "I enjoy _______ in the office.",
                LevelType = LevelType.Intermediate
            };
            var listeningQuestion10 = new Question
            {
                Id = 40,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "After ______, you should take a shower.",
                LevelType = LevelType.Intermediate
            };

            #endregion

            #region IntermediateListeningAnswers
            var listeningAnswer1 = new Answer
            {
                Id = 121,
                QuestionId = 31,
                IsCorrect = true,
                Text = "on"
            };
            var listeningAnswer2 = new Answer
            {
                Id = 122,
                QuestionId = 31,
                IsCorrect = false,
                Text = "to"
            };
            var listeningAnswer3 = new Answer
            {
                Id = 123,
                QuestionId = 31,
                IsCorrect = false,
                Text = "by"
            };
            var listeningAnswer4 = new Answer
            {
                Id = 124,
                QuestionId = 31,
                IsCorrect = false,
                Text = "for"
            };

            var listeningAnswer5 = new Answer
            {
                Id = 125,
                QuestionId = 32,
                IsCorrect = false,
                Text = "should"
            };
            var listeningAnswer6 = new Answer
            {
                Id = 126,
                QuestionId = 32,
                IsCorrect = false,
                Text = "would"
            };
            var listeningAnswer7 = new Answer
            {
                Id = 127,
                QuestionId = 32,
                IsCorrect = false,
                Text = "will"
            };
            var listeningAnswer8 = new Answer
            {
                Id = 128,
                QuestionId = 32,
                IsCorrect = true,
                Text = "is going to"
            };

            var listeningAnswer9 = new Answer
            {
                Id = 129,
                QuestionId = 33,
                IsCorrect = false,
                Text = "by"
            };
            var listeningAnswer10 = new Answer
            {
                Id = 130,
                QuestionId = 33,
                IsCorrect = false,
                Text = "for"
            };
            var listeningAnswer11 = new Answer
            {
                Id = 131,
                QuestionId = 33,
                IsCorrect = true,
                Text = "to"
            };
            var listeningAnswer12 = new Answer
            {
                Id = 132,
                QuestionId = 33,
                IsCorrect = false,
                Text = "the"
            };

            var listeningAnswer13 = new Answer
            {
                Id = 133,
                QuestionId = 34,
                IsCorrect = true,
                Text = "always forgets"
            };
            var listeningAnswer14 = new Answer
            {
                Id = 134,
                QuestionId = 34,
                IsCorrect = false,
                Text = "forgets always"
            };
            var listeningAnswer15 = new Answer
            {
                Id = 135,
                QuestionId = 34,
                IsCorrect = false,
                Text = "always forgetting"
            };
            var listeningAnswer16 = new Answer
            {
                Id = 136,
                QuestionId = 34,
                IsCorrect = false,
                Text = "always is forgetting"
            };

            var listeningAnswer17 = new Answer
            {
                Id = 137,
                QuestionId = 35,
                IsCorrect = false,
                Text = "for open"
            };
            var listeningAnswer18 = new Answer
            {
                Id = 138,
                QuestionId = 35,
                IsCorrect = true,
                Text = "to open"
            };
            var listeningAnswer19 = new Answer
            {
                Id = 139,
                QuestionId = 35,
                IsCorrect = false,
                Text = "for to open"
            };
            var listeningAnswer20 = new Answer
            {
                Id = 140,
                QuestionId = 35,
                IsCorrect = false,
                Text = "for oppening"
            };

            var listeningAnswer21 = new Answer
            {
                Id = 141,
                QuestionId = 36,
                IsCorrect = false,
                Text = "to buying"
            };
            var listeningAnswer22 = new Answer
            {
                Id = 142,
                QuestionId = 36,
                IsCorrect = false,
                Text = "for buying"
            };
            var listeningAnswer23 = new Answer
            {
                Id = 143,
                QuestionId = 36,
                IsCorrect = false,
                Text = "for to buy"
            };
            var listeningAnswer24 = new Answer
            {
                Id = 144,
                QuestionId = 36,
                IsCorrect = true,
                Text = "to buy"
            };

            var listeningAnswer25 = new Answer
            {
                Id = 145,
                QuestionId = 37,
                IsCorrect = false,
                Text = "they do want"
            };
            var listeningAnswer26 = new Answer
            {
                Id = 146,
                QuestionId = 37,
                IsCorrect = true,
                Text = "what they want"
            };
            var listeningAnswer27 = new Answer
            {
                Id = 147,
                QuestionId = 37,
                IsCorrect = false,
                Text = "what do they want"
            };
            var listeningAnswer28 = new Answer
            {
                Id = 148,
                QuestionId = 37,
                IsCorrect = false,
                Text = "what are they wanting"
            };

            var listeningAnswer29 = new Answer
            {
                Id = 149,
                QuestionId = 38,
                IsCorrect = true,
                Text = "not to"
            };
            var listeningAnswer30 = new Answer
            {
                Id = 150,
                QuestionId = 38,
                IsCorrect = false,
                Text = "don't to"
            };
            var listeningAnswer31 = new Answer
            {
                Id = 151,
                QuestionId = 38,
                IsCorrect = false,
                Text = "to don't"
            };
            var listeningAnswer32 = new Answer
            {
                Id = 152,
                QuestionId = 38,
                IsCorrect = false,
                Text = "aren't"
            };

            var listeningAnswer33 = new Answer
            {
                Id = 153,
                QuestionId = 39,
                IsCorrect = false,
                Text = "to working"
            };
            var listeningAnswer34 = new Answer
            {
                Id = 154,
                QuestionId = 39,
                IsCorrect = false,
                Text = "to work"
            };
            var listeningAnswer35 = new Answer
            {
                Id = 155,
                QuestionId = 39,
                IsCorrect = false,
                Text = "to working"
            };
            var listeningAnswer36 = new Answer
            {
                Id = 156,
                QuestionId = 39,
                IsCorrect = true,
                Text = "working"
            };

            var listeningAnswer37 = new Answer
            {
                Id = 157,
                QuestionId = 40,
                IsCorrect = false,
                Text = "swim"
            };
            var listeningAnswer38 = new Answer
            {
                Id = 158,
                QuestionId = 40,
                IsCorrect = true,
                Text = "swimming"
            };
            var listeningAnswer39 = new Answer
            {
                Id = 159,
                QuestionId = 40,
                IsCorrect = false,
                Text = "doing swim"
            };
            var listeningAnswer40 = new Answer
            {
                Id = 160,
                QuestionId = 40,
                IsCorrect = false,
                Text = "to swim"
            };

            #endregion

            #region IntermediateTopics
            var topic1 = new Question
            {
                Id = 46,
                QuestionType = QuestionType.Topic,
                Text = "Describe a famous person, such as an athlete, actor, or singer. Describe their appearance. ",
            };
            var topic2 = new Question
            {
                Id = 47,
                QuestionType = QuestionType.Topic,
                Text = "Describe your favorite place using as much detail as you can. ",
            };
            var topic3 = new Question
            {
                Id = 48,
                QuestionType = QuestionType.Topic,
                Text = "Talk about your happiest memory. ",
            };
            var topic4 = new Question
            {
                Id = 49,
                QuestionType = QuestionType.Topic,
                Text = "Describe your childhood pet.",
            };
            var topic5 = new Question
            {
                Id = 50,
                QuestionType = QuestionType.Topic,
                Text = "Discuss your favorite holiday.",
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

            return builder;
        }

        public static ModelBuilder FillElementaryLevelWithData(this ModelBuilder builder) {
            #region ElemntaryGrammarQuestions
            var grammarQuestion1 = new Question
            {
                Id = 51,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "What can I, as your teacher, do to help you this year?",
                LevelType = LevelType.Elementary
            };

            var grammarQuestion2 = new Question
            {
                Id = 52,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "What do you want me to know about you?",
                LevelType = LevelType.Elementary
            };

            var grammarQuestion3 = new Question
            {
                Id = 53,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "What does a typical day look like for you",
                LevelType = LevelType.Elementary
            };

            var grammarQuestion4 = new Question
            {
                Id = 54,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "If you could be invisible for a day, what would you do?",
                LevelType = LevelType.Elementary
            };

            var grammarQuestion5 = new Question
            {
                Id = 55,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "What is something that makes your family special?",
                LevelType = LevelType.Elementary
            };

            var grammarQuestion6 = new Question
            {
                Id = 56,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "What is your best quality or greatest strength?",
                LevelType = LevelType.Elementary
            };

            var grammarQuestion7 = new Question
            {
                Id = 57,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "What do you like best about school?",
                LevelType = LevelType.Elementary
            };

            var grammarQuestion8 = new Question
            {
                Id = 58,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "If you could change one rule that your family has, what would you change?",
                LevelType = LevelType.Elementary
            };

            var grammarQuestion9 = new Question
            {
                Id = 59,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "What do you enjoy doing with your family?",
                LevelType = LevelType.Elementary
            };

            var grammarQuestion10 = new Question
            {
                Id = 60,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "What is the best gift you have ever given?",
                LevelType = LevelType.Elementary
            };
            #endregion

            #region ElementaryGrammarAnswers
            var grammarAnswer1 = new Answer
            {
                Id = 161,
                QuestionId = 51,
                IsCorrect = true,
                Text = "Teach"
            };

            var grammarAnswer2 = new Answer
            {
                Id = 162,
                QuestionId = 51,
                IsCorrect = false,
                Text = "Brain"
            };

            var grammarAnswer3 = new Answer
            {
                Id = 163,
                QuestionId = 51,
                IsCorrect = false,
                Text = "Money"
            };

            var grammarAnswer4 = new Answer
            {
                Id = 164,
                QuestionId = 51,
                IsCorrect = false,
                Text = "Game"
            };

            var grammarAnswer5 = new Answer
            {
                Id = 165,
                QuestionId = 52,
                IsCorrect = false,
                Text = "Job"
            };

            var grammarAnswer6 = new Answer
            {
                Id = 166,
                QuestionId = 52,
                IsCorrect = true,
                Text = "Name"
            };

            var grammarAnswer7 = new Answer
            {
                Id = 167,
                QuestionId = 52,
                IsCorrect = false,
                Text = "Salary"
            };

            var grammarAnswer8 = new Answer
            {
                Id = 168,
                QuestionId = 52,
                IsCorrect = false,
                Text = "Location"
            };

            var grammarAnswer9 = new Answer
            {
                Id = 169,
                QuestionId = 53,
                IsCorrect = true,
                Text = "Funny"
            };

            var grammarAnswer10 = new Answer
            {
                Id = 170,
                QuestionId = 53,
                IsCorrect = false,
                Text = "Normal"
            };

            var grammarAnswer11 = new Answer
            {
                Id = 171,
                QuestionId = 53,
                IsCorrect = false,
                Text = "Ugly"
            };

            var grammarAnswer12 = new Answer
            {
                Id = 172,
                QuestionId = 53,
                IsCorrect = false,
                Text = "Bad"
            };

            var grammarAnswer13 = new Answer
            {
                Id = 173,
                QuestionId = 54,
                IsCorrect = false,
                Text = "Drink"
            };

            var grammarAnswer14 = new Answer
            {
                Id = 174,
                QuestionId = 54,
                IsCorrect = false,
                Text = "Snatch"
            };

            var grammarAnswer15 = new Answer
            {
                Id = 175,
                QuestionId = 54,
                IsCorrect = true,
                Text = "Relax"
            };

            var grammarAnswer16 = new Answer
            {
                Id = 176,
                QuestionId = 54,
                IsCorrect = false,
                Text = "Play"
            };

            var grammarAnswer17 = new Answer
            {
                Id = 177,
                QuestionId = 55,
                IsCorrect = false,
                Text = "Job"
            };

            var grammarAnswer18 = new Answer
            {
                Id = 178,
                QuestionId = 55,
                IsCorrect = true,
                Text = "Money"
            };

            var grammarAnswer19 = new Answer
            {
                Id = 179,
                QuestionId = 55,
                IsCorrect = false,
                Text = "Level"
            };

            var grammarAnswer20 = new Answer
            {
                Id = 180,
                QuestionId = 55,
                IsCorrect = false,
                Text = "Education"
            };

            var grammarAnswer21 = new Answer
            {
                Id = 181,
                QuestionId = 56,
                IsCorrect = true,
                Text = "Brain"
            };

            var grammarAnswer22 = new Answer
            {
                Id = 182,
                QuestionId = 56,
                IsCorrect = false,
                Text = "Opacity"
            };

            var grammarAnswer23 = new Answer
            {
                Id = 183,
                QuestionId = 56,
                IsCorrect = false,
                Text = "Lidership"
            };

            var grammarAnswer24 = new Answer
            {
                Id = 184,
                QuestionId = 56,
                IsCorrect = false,
                Text = "Hardwork"
            };

            var grammarAnswer25 = new Answer
            {
                Id = 185,
                QuestionId = 57,
                IsCorrect = false,
                Text = "Subjects"
            };

            var grammarAnswer26 = new Answer
            {
                Id = 186,
                QuestionId = 57,
                IsCorrect = false,
                Text = "Objects"
            };

            var grammarAnswer27 = new Answer
            {
                Id = 187,
                QuestionId = 57,
                IsCorrect = true,
                Text = "Lessons"
            };

            var grammarAnswer28 = new Answer
            {
                Id = 188,
                QuestionId = 57,
                IsCorrect = false,
                Text = "Relax time"
            };

            var grammarAnswer29 = new Answer
            {
                Id = 189,
                QuestionId = 58,
                IsCorrect = true,
                Text = "Location"
            };

            var grammarAnswer30 = new Answer
            {
                Id = 190,
                QuestionId = 58,
                IsCorrect = false,
                Text = "Future"
            };

            var grammarAnswer31 = new Answer
            {
                Id = 191,
                QuestionId = 58,
                IsCorrect = false,
                Text = "House"
            };

            var grammarAnswer32 = new Answer
            {
                Id = 192,
                QuestionId = 58,
                IsCorrect = false,
                Text = "Money"
            };

            var grammarAnswer33 = new Answer
            {
                Id = 193,
                QuestionId = 59,
                IsCorrect = false,
                Text = "Hunt"
            };

            var grammarAnswer34 = new Answer
            {
                Id = 194,
                QuestionId = 59,
                IsCorrect = false,
                Text = "Relax"
            };

            var grammarAnswer35 = new Answer
            {
                Id = 195,
                QuestionId = 59,
                IsCorrect = false,
                Text = "Make money"
            };

            var grammarAnswer36 = new Answer
            {
                Id = 196,
                QuestionId = 59,
                IsCorrect = true,
                Text = "Snatch"
            };

            var grammarAnswer37 = new Answer
            {
                Id = 197,
                QuestionId = 60,
                IsCorrect = true,
                Text = "Buy a new car"
            };

            var grammarAnswer38 = new Answer
            {
                Id = 198,
                QuestionId = 60,
                IsCorrect = false,
                Text = "Build a house"
            };

            var grammarAnswer39 = new Answer
            {
                Id = 199,
                QuestionId = 60,
                IsCorrect = false,
                Text = "Make money"
            };

            var grammarAnswer40 = new Answer
            {
                Id = 200,
                QuestionId = 60,
                IsCorrect = false,
                Text = "Run to Feature"
            };
            #endregion

            #region ElementaryListeningQuestions
            var listeningQuestion1 = new Question
            {
                Id = 61,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "What are three things that you do every day?",
                LevelType = LevelType.Elementary
            };

            var listeningQuestion2 = new Question
            {
                Id = 62,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "If you were a teacher, and the kids in your class would not listen to you, what would you do??",
                LevelType = LevelType.Elementary
            };

            var listeningQuestion3 = new Question
            {
                Id = 63,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "Are you a good friend? Why do you think so?",
                LevelType = LevelType.Elementary
            };

            var listeningQuestion4 = new Question
            {
                Id = 64,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "How would the world be different if animals could talk?",
                LevelType = LevelType.Elementary
            };

            var listeningQuestion5 = new Question
            {
                Id = 65,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "What is the hardest thing about being a kid?",
                LevelType = LevelType.Elementary
            };

            var listeningQuestion6 = new Question
            {
                Id = 66,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "What superpower would you like to have and why?",
                LevelType = LevelType.Elementary
            };

            var listeningQuestion7 = new Question
            {
                Id = 67,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "If you could make one rule that everyone in the world had to follow, what rule would you make? Why?",
                LevelType = LevelType.Elementary
            };

            var listeningQuestion8 = new Question
            {
                Id = 68,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "Where is your favorite place in the world?",
                LevelType = LevelType.Elementary
            };

            var listeningQuestion9 = new Question
            {
                Id = 69,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "If you could change your name, would you? If so, what name would you choose?",
                LevelType = LevelType.Elementary
            };

            var listeningQuestion10 = new Question
            {
                Id = 70,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "What do you want to be when you grow up?",
                LevelType = LevelType.Elementary
            };
            #endregion

            #region ElemntaryListeningAnswers
            var listeningAnswer1 = new Answer
            {
                Id = 281,
                QuestionId = 61,
                IsCorrect = true,
                Text = "Cat"
            };

            var listeningAnswer2 = new Answer
            {
                Id = 282,
                QuestionId = 61,
                IsCorrect = false,
                Text = "Dog"
            };

            var listeningAnswer3 = new Answer
            {
                Id = 283,
                QuestionId = 61,
                IsCorrect = false,
                Text = "Cow"
            };

            var listeningAnswer4 = new Answer
            {
                Id = 284,
                QuestionId = 61,
                IsCorrect = false,
                Text = "Goat"
            };

            var listeningAnswer5 = new Answer
            {
                Id = 285,
                QuestionId = 62,
                IsCorrect = true,
                Text = "2-16 years"
            };

            var listeningAnswer6 = new Answer
            {
                Id = 286,
                QuestionId = 62,
                IsCorrect = false,
                Text = "1-4 years"
            };

            var listeningAnswer7 = new Answer
            {
                Id = 287,
                QuestionId = 62,
                IsCorrect = false,
                Text = "16-24 years"
            };

            var listeningAnswer8 = new Answer
            {
                Id = 288,
                QuestionId = 62,
                IsCorrect = false,
                Text = "5-10 years"
            };

            var listeningAnswer9 = new Answer
            {
                Id = 289,
                QuestionId = 63,
                IsCorrect = true,
                Text = "10-13 years"
            };

            var listeningAnswer10 = new Answer
            {
                Id = 290,
                QuestionId = 63,
                IsCorrect = false,
                Text = "5-10 years"
            };

            var listeningAnswer11 = new Answer
            {
                Id = 291,
                QuestionId = 63,
                IsCorrect = false,
                Text = "2-16 years"
            };

            var listeningAnswer12 = new Answer
            {
                Id = 292,
                QuestionId = 63,
                IsCorrect = false,
                Text = "1-2 years"
            };

            var listeningAnswer13 = new Answer
            {
                Id = 293,
                QuestionId = 64,
                IsCorrect = true,
                Text = "Milk"
            };

            var listeningAnswer14 = new Answer
            {
                Id = 294,
                QuestionId = 64,
                IsCorrect = false,
                Text = "Sugar"
            };

            var listeningAnswer15 = new Answer
            {
                Id = 295,
                QuestionId = 64,
                IsCorrect = false,
                Text = "Salt"
            };

            var listeningAnswer16 = new Answer
            {
                Id = 296,
                QuestionId = 64,
                IsCorrect = false,
                Text = "Oil"
            };

            var listeningAnswer17 = new Answer
            {
                Id = 297,
                QuestionId = 65,
                IsCorrect = true,
                Text = "Carnivorous"
            };

            var listeningAnswer18 = new Answer
            {
                Id = 298,
                QuestionId = 65,
                IsCorrect = false,
                Text = "Herbivorous"
            };

            var listeningAnswer19 = new Answer
            {
                Id = 299,
                QuestionId = 65,
                IsCorrect = false,
                Text = "Omnivorous"
            };

            var listeningAnswer20 = new Answer
            {
                Id = 300,
                QuestionId = 65,
                IsCorrect = false,
                Text = "Vegeterian"
            };

            var listeningAnswer21 = new Answer
            {
                Id = 301,
                QuestionId = 66,
                IsCorrect = false,
                Text = "Carnivorous"
            };

            var listeningAnswer22 = new Answer
            {
                Id = 302,
                QuestionId = 66,
                IsCorrect = true,
                Text = "Herbivorous"
            };

            var listeningAnswer23 = new Answer
            {
                Id = 303,
                QuestionId = 66,
                IsCorrect = false,
                Text = "Omnivorous"
            };

            var listeningAnswer24 = new Answer
            {
                Id = 304,
                QuestionId = 66,
                IsCorrect = false,
                Text = "Vegeterian"
            };

            var listeningAnswer25 = new Answer
            {
                Id = 305,
                QuestionId = 67,
                IsCorrect = false,
                Text = "Carnivorous"
            };

            var listeningAnswer26 = new Answer
            {
                Id = 306,
                QuestionId = 67,
                IsCorrect = false,
                Text = "Herbivorous"
            };

            var listeningAnswer27 = new Answer
            {
                Id = 307,
                QuestionId = 67,
                IsCorrect = true,
                Text = "Omnivorous"
            };

            var listeningAnswer28 = new Answer
            {
                Id = 308,
                QuestionId = 67,
                IsCorrect = false,
                Text = "Vegeterian"
            };

            var listeningAnswer29 = new Answer
            {
                Id = 309,
                QuestionId = 68,
                IsCorrect = true,
                Text = "115.7 meters"
            };

            var listeningAnswer30 = new Answer
            {
                Id = 310,
                QuestionId = 68,
                IsCorrect = false,
                Text = "110 meters"
            };

            var listeningAnswer31 = new Answer
            {
                Id = 311,
                QuestionId = 68,
                IsCorrect = false,
                Text = "100 meters"
            };

            var listeningAnswer32 = new Answer
            {
                Id = 312,
                QuestionId = 68,
                IsCorrect = false,
                Text = "90 meters"
            };

            var listeningAnswer33 = new Answer
            {
                Id = 313,
                QuestionId = 69,
                IsCorrect = true,
                Text = "The Amazon"
            };

            var listeningAnswer34 = new Answer
            {
                Id = 314,
                QuestionId = 69,
                IsCorrect = false,
                Text = "Yakushima Forest"
            };

            var listeningAnswer35 = new Answer
            {
                Id = 315,
                QuestionId = 69,
                IsCorrect = false,
                Text = "Waipoua Forest"
            };

            var listeningAnswer36 = new Answer
            {
                Id = 316,
                QuestionId = 69,
                IsCorrect = false,
                Text = "The Araucaria Forest"
            };

            var listeningAnswer37 = new Answer
            {
                Id = 317,
                QuestionId = 70,
                IsCorrect = true,
                Text = "The Pacific Ocean"
            };

            var listeningAnswer38 = new Answer
            {
                Id = 318,
                QuestionId = 70,
                IsCorrect = false,
                Text = "The Atlantic Ocean"
            };

            var listeningAnswer39 = new Answer
            {
                Id = 319,
                QuestionId = 70,
                IsCorrect = false,
                Text = "The Indian Ocean"
            };

            var listeningAnswer40 = new Answer
            {
                Id = 320,
                QuestionId = 70,
                IsCorrect = false,
                Text = "The Arctic Ocean"
            };
            #endregion

            #region ElementaryTopics
            var topic1 = new Question
            {
                Id = 71,
                QuestionType = QuestionType.Topic,
                Text = "Icebreakers",
                LevelType = LevelType.Elementary
            };

            var topic2 = new Question
            {
                Id = 72,
                QuestionType = QuestionType.Topic,
                Text = "Describing people",
                LevelType = LevelType.Elementary
            };

            var topic3 = new Question
            {
                Id = 73,
                QuestionType = QuestionType.Topic,
                Text = "Greetings & introductions",
                LevelType = LevelType.Elementary
            };

            var topic4 = new Question
            {
                Id = 74,
                QuestionType = QuestionType.Topic,
                Text = "Money",
                LevelType = LevelType.Elementary
            };

            var topic5 = new Question
            {
                Id = 75,
                QuestionType = QuestionType.Topic,
                Text = "Past tense themes",
                LevelType = LevelType.Elementary
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

            return builder;
        }
    }
}
