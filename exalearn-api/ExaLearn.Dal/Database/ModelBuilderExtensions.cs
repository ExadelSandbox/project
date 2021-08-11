using ExaLearn.Dal.Entities;
using ExaLearn.Shared.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Portal.Core.Constants;
using Shared.Enums;
using System;

namespace ExaLearn.Dal.Database
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.FillUsers()
                   .FillBeginnerLevelWithData()
                   .FillElementaryLevelWithData()
                   .FillIntermediateWithData()
                   .FillUpperIntermediateLevelWithData()
                   .FillAdvancedLevelWithData()
                   .FillProficiencyLevelWithData()
                   .FillPassedTest();
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
                Text = "Joe ---- a good driver",
                LevelType = LevelType.Beginner
            };
            var grammarQuestion6 = new Question
            {
                Id = 6,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "Look! The boys ---- running!",
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
                Text = "I ---- at home yesterday",
                LevelType = LevelType.Beginner
            };
            var grammarQuestion9 = new Question
            {
                Id = 9,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "There ---- a one apple left",
                LevelType = LevelType.Beginner
            };
            var grammarQuestion10 = new Question
            {
                Id = 10,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "---- did she go?",
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
                Text = "Cats lifespan?",
                LevelType = LevelType.Beginner
            };
            var listeningQuestion3 = new Question
            {
                Id = 13,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "Dogs lifespan?",
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
                Text = "2 to 16 years"
            };
            var listeningAnswer6 = new Answer
            {
                Id = 46,
                QuestionId = 12,
                IsCorrect = false,
                Text = "1 to 4 years"
            };
            var listeningAnswer7 = new Answer
            {
                Id = 47,
                QuestionId = 12,
                IsCorrect = false,
                Text = "16 to 24 years"
            };
            var listeningAnswer8 = new Answer
            {
                Id = 48,
                QuestionId = 12,
                IsCorrect = false,
                Text = "5 to 10 years"
            };

            var listeningAnswer9 = new Answer
            {
                Id = 49,
                QuestionId = 13,
                IsCorrect = true,
                Text = "10 to 13 years"
            };
            var listeningAnswer10 = new Answer
            {
                Id = 50,
                QuestionId = 13,
                IsCorrect = false,
                Text = "5 to 10 years"
            };
            var listeningAnswer11 = new Answer
            {
                Id = 51,
                QuestionId = 13,
                IsCorrect = false,
                Text = "2 to 16 years"
            };
            var listeningAnswer12 = new Answer
            {
                Id = 52,
                QuestionId = 13,
                IsCorrect = false,
                Text = "1 to 2 years"
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
                Text = "I ---- to that restaurant. The food is very good.",
                LevelType = LevelType.Intermediate
            };
            var grammarQuestion2 = new Question
            {
                Id = 22,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "Her parents didnt want ---- watch T.V.",
                LevelType = LevelType.Intermediate
            };
            var grammarQuestion3 = new Question
            {
                Id = 23,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "We knew that she ---- waiting for the the results of her English test.",
                LevelType = LevelType.Intermediate
            };
            var grammarQuestion4 = new Question
            {
                Id = 24,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "You cant pass your grammar test without ----.",
                LevelType = LevelType.Intermediate
            };
            var grammarQuestion5 = new Question
            {
                Id = 25,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "When the postman came, I ---- a shower.",
                LevelType = LevelType.Intermediate
            };
            var grammarQuestion6 = new Question
            {
                Id = 26,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "He didnt remember that we ---- before.",
                LevelType = LevelType.Intermediate
            };
            var grammarQuestion7 = new Question
            {
                Id = 27,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "Tomorrow is Saturday so she ---- work. Its her day off.",
                LevelType = LevelType.Intermediate
            };
            var grammarQuestion8 = new Question
            {
                Id = 28,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "He met her at school. They have been friends ---- years.",
                LevelType = LevelType.Intermediate
            };
            var grammarQuestion9 = new Question
            {
                Id = 29,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "She looks ---- a secretary.",
                LevelType = LevelType.Intermediate
            };
            var grammarQuestion10 = new Question
            {
                Id = 30,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "She asked if I would like ---- on a date with her.",
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
                Text = "wouldnt"
            };
            var grammarAnswer26 = new Answer
            {
                Id = 106,
                QuestionId = 27,
                IsCorrect = false,
                Text = "mustnt"
            };
            var grammarAnswer27 = new Answer
            {
                Id = 107,
                QuestionId = 27,
                IsCorrect = true,
                Text = "doesnt have to"
            };
            var grammarAnswer28 = new Answer
            {
                Id = 108,
                QuestionId = 27,
                IsCorrect = false,
                Text = "hasnt"
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
                Text = "We spend a lot of time ---- the internet.",
                LevelType = LevelType.Intermediate
            };
            var listeningQuestion2 = new Question
            {
                Id = 32,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "Have you heard the news? Jane ---- have a baby!",
                LevelType = LevelType.Intermediate
            };
            var listeningQuestion3 = new Question
            {
                Id = 33,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "She always listens ---- music on her phone",
                LevelType = LevelType.Intermediate
            };
            var listeningQuestion4 = new Question
            {
                Id = 34,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "He ---- the answers during his English test.",
                LevelType = LevelType.Intermediate
            };
            var listeningQuestion5 = new Question
            {
                Id = 35,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "You need a key ---- the box.",
                LevelType = LevelType.Intermediate
            };
            var listeningQuestion6 = new Question
            {
                Id = 36,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "I went to the supermarket ---- milk.",
                LevelType = LevelType.Intermediate
            };
            var listeningQuestion7 = new Question
            {
                Id = 37,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "I dont know ------.",
                LevelType = LevelType.Intermediate
            };
            var listeningQuestion8 = new Question
            {
                Id = 38,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "Try ------ forget.",
                LevelType = LevelType.Intermediate
            };
            var listeningQuestion9 = new Question
            {
                Id = 39,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "I enjoy ------ in the office.",
                LevelType = LevelType.Intermediate
            };
            var listeningQuestion10 = new Question
            {
                Id = 40,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "After ------, you should take a shower.",
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
                Text = "dont to"
            };
            var listeningAnswer31 = new Answer
            {
                Id = 151,
                QuestionId = 38,
                IsCorrect = false,
                Text = "to dont"
            };
            var listeningAnswer32 = new Answer
            {
                Id = 152,
                QuestionId = 38,
                IsCorrect = false,
                Text = "arent"
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

        public static ModelBuilder FillElementaryLevelWithData(this ModelBuilder builder)
        {
            #region ElementaryGrammarQuestions
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


        public static ModelBuilder FillUpperIntermediateLevelWithData(this ModelBuilder builder)
        {
            #region UpperIntermediateQuestions
            var grammarQuestion1 = new Question
            {
                Id = 76,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "The taxi will be here in a couple of minutes. We ------ get ready to go.",
                LevelType = LevelType.UpperIntermediate
            };

            var grammarQuestion2 = new Question
            {
                Id = 77,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "The interviewer started off ------ me why I wanted the job.",
                LevelType = LevelType.UpperIntermediate
            };

            var grammarQuestion3 = new Question
            {
                Id = 78,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "The stairs ------ quite steep, so be careful how you go down.",
                LevelType = LevelType.UpperIntermediate
            };

            var grammarQuestion4 = new Question
            {
                Id = 79,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "Dad wont mind us borrowing the car, will he? No, I ------",
                LevelType = LevelType.UpperIntermediate
            };

            var grammarQuestion5 = new Question
            {
                Id = 80,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "We ------ to the tennis club since we moved here.",
                LevelType = LevelType.UpperIntermediate
            };

            var grammarQuestion6 = new Question
            {
                Id = 81,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "Your eyes are red ------?",
                LevelType = LevelType.UpperIntermediate
            };

            var grammarQuestion7 = new Question
            {
                Id = 82,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "I dont know when Helen ------ back.",
                LevelType = LevelType.UpperIntermediate
            };

            var grammarQuestion8 = new Question
            {
                Id = 83,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "I ------ an interview because Id worked there before.",
                LevelType = LevelType.UpperIntermediate
            };

            var grammarQuestion9 = new Question
            {
                Id = 84,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "When I asked what was wrong, ------",
                LevelType = LevelType.UpperIntermediate
            };

            var grammarQuestion10 = new Question
            {
                Id = 85,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "Steven ------ the wallet.",
                LevelType = LevelType.UpperIntermediate
            };
            #endregion

            #region UpperIntermediateQuestionsAnswers
            var grammarAnswer1 = new Answer
            {
                Id = 321,
                QuestionId = 76,
                IsCorrect = true,
                Text = "had better"
            };

            var grammarAnswer2 = new Answer
            {
                Id = 322,
                QuestionId = 76,
                IsCorrect = false,
                Text = "would better"
            };

            var grammarAnswer3 = new Answer
            {
                Id = 323,
                QuestionId = 76,
                IsCorrect = false,
                Text = "should better"
            };

            var grammarAnswer4 = new Answer
            {
                Id = 324,
                QuestionId = 76,
                IsCorrect = false,
                Text = "better"
            };

            var grammarAnswer5 = new Answer
            {
                Id = 325,
                QuestionId = 77,
                IsCorrect = false,
                Text = "in asking"
            };

            var grammarAnswer6 = new Answer
            {
                Id = 326,
                QuestionId = 77,
                IsCorrect = true,
                Text = "by asking"
            };

            var grammarAnswer7 = new Answer
            {
                Id = 327,
                QuestionId = 77,
                IsCorrect = false,
                Text = "to ask"
            };

            var grammarAnswer8 = new Answer
            {
                Id = 328,
                QuestionId = 77,
                IsCorrect = false,
                Text = "ask"
            };

            var grammarAnswer9 = new Answer
            {
                Id = 329,
                QuestionId = 78,
                IsCorrect = true,
                Text = "are"
            };

            var grammarAnswer10 = new Answer
            {
                Id = 330,
                QuestionId = 78,
                IsCorrect = false,
                Text = "be"
            };

            var grammarAnswer11 = new Answer
            {
                Id = 331,
                QuestionId = 78,
                IsCorrect = false,
                Text = "is"
            };

            var grammarAnswer12 = new Answer
            {
                Id = 332,
                QuestionId = 78,
                IsCorrect = false,
                Text = "isnt"
            };

            var grammarAnswer13 = new Answer
            {
                Id = 333,
                QuestionId = 79,
                IsCorrect = false,
                Text = "dont suppose it"
            };

            var grammarAnswer14 = new Answer
            {
                Id = 334,
                QuestionId = 79,
                IsCorrect = true,
                Text = "suppose not"
            };

            var grammarAnswer15 = new Answer
            {
                Id = 335,
                QuestionId = 79,
                IsCorrect = false,
                Text = "suppose"
            };

            var grammarAnswer16 = new Answer
            {
                Id = 336,
                QuestionId = 79,
                IsCorrect = false,
                Text = "not"
            };

            var grammarAnswer17 = new Answer
            {
                Id = 337,
                QuestionId = 80,
                IsCorrect = true,
                Text = "have belonged"
            };

            var grammarAnswer18 = new Answer
            {
                Id = 338,
                QuestionId = 80,
                IsCorrect = false,
                Text = "are belonging"
            };

            var grammarAnswer19 = new Answer
            {
                Id = 339,
                QuestionId = 80,
                IsCorrect = false,
                Text = "belong"
            };

            var grammarAnswer20 = new Answer
            {
                Id = 340,
                QuestionId = 80,
                IsCorrect = false,
                Text = "is belong"
            };

            var grammarAnswer21 = new Answer
            {
                Id = 341,
                QuestionId = 81,
                IsCorrect = false,
                Text = "did you cry"
            };

            var grammarAnswer22 = new Answer
            {
                Id = 342,
                QuestionId = 81,
                IsCorrect = false,
                Text = "have you cried"
            };

            var grammarAnswer23 = new Answer
            {
                Id = 343,
                QuestionId = 81,
                IsCorrect = true,
                Text = "have you been crying"
            };

            var grammarAnswer24 = new Answer
            {
                Id = 344,
                QuestionId = 81,
                IsCorrect = false,
                Text = "you been crying"
            };

            var grammarAnswer25 = new Answer
            {
                Id = 345,
                QuestionId = 82,
                IsCorrect = true,
                Text = "will be"
            };

            var grammarAnswer26 = new Answer
            {
                Id = 346,
                QuestionId = 82,
                IsCorrect = false,
                Text = "is"
            };

            var grammarAnswer27 = new Answer
            {
                Id = 347,
                QuestionId = 82,
                IsCorrect = false,
                Text = "can"
            };

            var grammarAnswer28 = new Answer
            {
                Id = 348,
                QuestionId = 82,
                IsCorrect = false,
                Text = "will"
            };

            var grammarAnswer29 = new Answer
            {
                Id = 349,
                QuestionId = 83,
                IsCorrect = false,
                Text = "neednt have"
            };

            var grammarAnswer30 = new Answer
            {
                Id = 350,
                QuestionId = 83,
                IsCorrect = true,
                Text = "didnt need to have"
            };

            var grammarAnswer31 = new Answer
            {
                Id = 351,
                QuestionId = 83,
                IsCorrect = false,
                Text = "neednt have had"
            };

            var grammarAnswer32 = new Answer
            {
                Id = 352,
                QuestionId = 83,
                IsCorrect = false,
                Text = "neednt had"
            };

            var grammarAnswer33 = new Answer
            {
                Id = 353,
                QuestionId = 84,
                IsCorrect = false,
                Text = "I was explained the problem"
            };

            var grammarAnswer34 = new Answer
            {
                Id = 354,
                QuestionId = 84,
                IsCorrect = true,
                Text = "the problem was explained to me"
            };

            var grammarAnswer35 = new Answer
            {
                Id = 355,
                QuestionId = 84,
                IsCorrect = false,
                Text = "he explained me the problem"
            };

            var grammarAnswer36 = new Answer
            {
                Id = 356,
                QuestionId = 84,
                IsCorrect = false,
                Text = "she explained me the problem"
            };

            var grammarAnswer37 = new Answer
            {
                Id = 357,
                QuestionId = 85,
                IsCorrect = false,
                Text = "admitted to steal"
            };

            var grammarAnswer38 = new Answer
            {
                Id = 358,
                QuestionId = 85,
                IsCorrect = false,
                Text = "admitted steal"
            };

            var grammarAnswer39 = new Answer
            {
                Id = 359,
                QuestionId = 85,
                IsCorrect = true,
                Text = "admitted stealing"
            };

            var grammarAnswer40 = new Answer
            {
                Id = 360,
                QuestionId = 85,
                IsCorrect = false,
                Text = "admitted stealed"
            };
            #endregion

            #region UpperIntermediateListeningQuestions
            var listeningQuestion1 = new Question
            {
                Id = 86,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "What are the people discussing?",
                LevelType = LevelType.UpperIntermediate
            };

            var listeningQuestion2 = new Question
            {
                Id = 87,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "What is the woman referring to when she states, that sounds like fun?",
                LevelType = LevelType.UpperIntermediate
            };

            var listeningQuestion3 = new Question
            {
                Id = 88,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "Which duty does the man like the least?",
                LevelType = LevelType.UpperIntermediate
            };

            var listeningQuestion4 = new Question
            {
                Id = 89,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "What is the talk mainly about?",
                LevelType = LevelType.UpperIntermediate
            };

            var listeningQuestion5 = new Question
            {
                Id = 90,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "What is the woman referring to when she states, That was in 1883?",
                LevelType = LevelType.UpperIntermediate
            };

            var listeningQuestion6 = new Question
            {
                Id = 91,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "In addition to Annie Oakley, which other famous person traveled with Buffalo Bill?",
                LevelType = LevelType.UpperIntermediate
            };

            var listeningQuestion7 = new Question
            {
                Id = 92,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "What does the speaker mainly discuss?",
                LevelType = LevelType.UpperIntermediate
            };

            var listeningQuestion8 = new Question
            {
                Id = 93,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "According to the professor, what is ragtime?",
                LevelType = LevelType.UpperIntermediate
            };

            var listeningQuestion9 = new Question
            {
                Id = 94,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "What does the professor contrast in his lecture?",
                LevelType = LevelType.UpperIntermediate
            };

            var listeningQuestion10 = new Question
            {
                Id = 95,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "What are the people discussing?",
                LevelType = LevelType.UpperIntermediate
            };
            #endregion

            #region UpperIntermediateListeningAnswers
            var listeningAnswer1 = new Answer
            {
                Id = 361,
                QuestionId = 86,
                IsCorrect = true,
                Text = "Getting presents"
            };

            var listeningAnswer2 = new Answer
            {
                Id = 362,
                QuestionId = 86,
                IsCorrect = false,
                Text = "Purchasing books"
            };

            var listeningAnswer3 = new Answer
            {
                Id = 363,
                QuestionId = 86,
                IsCorrect = false,
                Text = "Attaching bar codes"
            };

            var listeningAnswer4 = new Answer
            {
                Id = 364,
                QuestionId = 86,
                IsCorrect = false,
                Text = "Working in a library"
            };

            var listeningAnswer5 = new Answer
            {
                Id = 365,
                QuestionId = 87,
                IsCorrect = true,
                Text = "Unwrapping presents"
            };

            var listeningAnswer6 = new Answer
            {
                Id = 366,
                QuestionId = 87,
                IsCorrect = false,
                Text = "Unpacking books"
            };

            var listeningAnswer7 = new Answer
            {
                Id = 367,
                QuestionId = 87,
                IsCorrect = false,
                Text = "Having a birthday"
            };

            var listeningAnswer8 = new Answer
            {
                Id = 368,
                QuestionId = 87,
                IsCorrect = false,
                Text = "Logging in books"
            };

            var listeningAnswer9 = new Answer
            {
                Id = 369,
                QuestionId = 88,
                IsCorrect = true,
                Text = "Logging in books"
            };

            var listeningAnswer10 = new Answer
            {
                Id = 370,
                QuestionId = 88,
                IsCorrect = false,
                Text = "Attaching the bar code"
            };

            var listeningAnswer11 = new Answer
            {
                Id = 371,
                QuestionId = 88,
                IsCorrect = false,
                Text = "Opening boxes of purchased books"
            };

            var listeningAnswer12 = new Answer
            {
                Id = 372,
                QuestionId = 88,
                IsCorrect = false,
                Text = "Entering the data into the computer"
            };

            var listeningAnswer13 = new Answer
            {
                Id = 373,
                QuestionId = 89,
                IsCorrect = true,
                Text = "American sharpshooters"
            };

            var listeningAnswer14 = new Answer
            {
                Id = 374,
                QuestionId = 89,
                IsCorrect = false,
                Text = "The czar of Russia"
            };

            var listeningAnswer15 = new Answer
            {
                Id = 375,
                QuestionId = 89,
                IsCorrect = false,
                Text = "Buffalo Bills Wild West Show"
            };

            var listeningAnswer16 = new Answer
            {
                Id = 376,
                QuestionId = 89,
                IsCorrect = false,
                Text = "European heads of state"
            };

            var listeningAnswer17 = new Answer
            {
                Id = 377,
                QuestionId = 90,
                IsCorrect = true,
                Text = "When the Wild West Show performed for heads of state"
            };

            var listeningAnswer18 = new Answer
            {
                Id = 378,
                QuestionId = 90,
                IsCorrect = false,
                Text = "The year Cody started the Wild West Show"
            };

            var listeningAnswer19 = new Answer
            {
                Id = 379,
                QuestionId = 90,
                IsCorrect = false,
                Text = "When Cody became known as Buffalo Bill"
            };

            var listeningAnswer20 = new Answer
            {
                Id = 380,
                QuestionId = 90,
                IsCorrect = false,
                Text = "The date William Cody was more widely known"
            };

            var listeningAnswer21 = new Answer
            {
                Id = 381,
                QuestionId = 91,
                IsCorrect = false,
                Text = "William Cody"
            };

            var listeningAnswer22 = new Answer
            {
                Id = 382,
                QuestionId = 91,
                IsCorrect = true,
                Text = "Queen Victoria"
            };

            var listeningAnswer23 = new Answer
            {
                Id = 383,
                QuestionId = 91,
                IsCorrect = false,
                Text = "Chief Sitting Bull"
            };

            var listeningAnswer24 = new Answer
            {
                Id = 384,
                QuestionId = 91,
                IsCorrect = false,
                Text = "Czar Alexander the II"
            };

            var listeningAnswer25 = new Answer
            {
                Id = 385,
                QuestionId = 92,
                IsCorrect = false,
                Text = "The turn of the century"
            };

            var listeningAnswer26 = new Answer
            {
                Id = 386,
                QuestionId = 92,
                IsCorrect = false,
                Text = "Ragtime in America"
            };

            var listeningAnswer27 = new Answer
            {
                Id = 387,
                QuestionId = 92,
                IsCorrect = true,
                Text = "Band concerts in America and Europe"
            };

            var listeningAnswer28 = new Answer
            {
                Id = 388,
                QuestionId = 92,
                IsCorrect = false,
                Text = "Early American musical forms"
            };

            var listeningAnswer29 = new Answer
            {
                Id = 389,
                QuestionId = 93,
                IsCorrect = true,
                Text = "A type of traditional music with regular beats"
            };

            var listeningAnswer30 = new Answer
            {
                Id = 390,
                QuestionId = 93,
                IsCorrect = false,
                Text = "One of John Philip"
            };

            var listeningAnswer31 = new Answer
            {
                Id = 391,
                QuestionId = 93,
                IsCorrect = false,
                Text = "A musical form that became popular around 1900"
            };

            var listeningAnswer32 = new Answer
            {
                Id = 392,
                QuestionId = 93,
                IsCorrect = false,
                Text = "A particular piece of music composed by William Krell"
            };

            var listeningAnswer33 = new Answer
            {
                Id = 393,
                QuestionId = 94,
                IsCorrect = true,
                Text = "Regular beats and syncopation in music"
            };

            var listeningAnswer34 = new Answer
            {
                Id = 394,
                QuestionId = 94,
                IsCorrect = false,
                Text = "The different beats in waltzes and polkas"
            };

            var listeningAnswer35 = new Answer
            {
                Id = 395,
                QuestionId = 94,
                IsCorrect = false,
                Text = "Popular musical forms in America and Europe"
            };

            var listeningAnswer36 = new Answer
            {
                Id = 396,
                QuestionId = 94,
                IsCorrect = false,
                Text = "Mississippi Rag and Joplins Maple Leaf Rag"
            };

            var listeningAnswer37 = new Answer
            {
                Id = 397,
                QuestionId = 95,
                IsCorrect = true,
                Text = "Security precautions at a museum"
            };

            var listeningAnswer38 = new Answer
            {
                Id = 398,
                QuestionId = 95,
                IsCorrect = false,
                Text = "A painting that thieves favor"
            };

            var listeningAnswer39 = new Answer
            {
                Id = 399,
                QuestionId = 95,
                IsCorrect = false,
                Text = "A popular painting among the public"
            };

            var listeningAnswer40 = new Answer
            {
                Id = 400,
                QuestionId = 95,
                IsCorrect = false,
                Text = "The most valuable painting in the museum"
            };
            #endregion

            #region UpperIntermediateTopics
            var topic1 = new Question
            {
                Id = 401,
                QuestionType = QuestionType.Topic,
                Text = "What do you think about happiness",
                LevelType = LevelType.UpperIntermediate
            };

            var topic2 = new Question
            {
                Id = 402,
                QuestionType = QuestionType.Topic,
                Text = "Life after death",
                LevelType = LevelType.UpperIntermediate
            };

            var topic3 = new Question
            {
                Id = 403,
                QuestionType = QuestionType.Topic,
                Text = "Why we live on this earth?",
                LevelType = LevelType.UpperIntermediate
            };

            var topic4 = new Question
            {
                Id = 404,
                QuestionType = QuestionType.Topic,
                Text = "tell us about Platos cave",
                LevelType = LevelType.UpperIntermediate
            };

            var topic5 = new Question
            {
                Id = 405,
                QuestionType = QuestionType.Topic,
                Text = "Meaning of life",
                LevelType = LevelType.UpperIntermediate
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

        public static ModelBuilder FillAdvancedLevelWithData(this ModelBuilder builder)
        {
            #region grammars
            #region grammar1
            var grammarQuestion1 = new Question
            {
                Id = 101,
                QuestionType = QuestionType.Grammar,
                Text = "Until the eighteenth century comparative linguistic studies " +
                "did not progress ------ beyond the stage where ancient Greek and Roman " +
                "grammarians had left them.",
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
                Text = "Julius Caesar ------ a great historian if " +
                "the making of history ------ him the time and the " +
                "inclination to write it.",
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
                Text = "Early in 1940, when Europe was already at war, " +
                "Hitler ------  the sale of uranium from the Czech mines he ------ over.",
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
                Text = "Physics, as it ------ at the end of the nineteenth " +
                "century, ------ to as classical physics.",
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
                Text = "Sometimes people select certain foods that they " +
                "believe ------ their physical appearance and avoid those they " +
                "believe ------ detrimental.",
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
                Text = "It is not unusual for advertising campaigns ------ even " +
                "before the new products ------ onto the market.",
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
                Text = "Much health education in recent years ------ towards the view " +
                "that heavy drinker ------  subject for amusement but for practical help.",
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
                Text = "was being directed / wouldnt be"
            };

            var answerGrammarQuestion73 = new Answer
            {
                Id = 227,
                QuestionId = 107,
                IsCorrect = false,
                Text = "is directed / wont be"
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
                Text = "Galileo originated the method of controlled experiment ------ " +
                "now forms the basis of scientific investigation.",
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
                Text = "Unfortunately, the worlds forest ------ at such a rate that the " +
                "remaining tropical rainforests ------ by the middle of the century.",
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
                Text = "The continuing controversy ------ in 1924 by P. Hubble, " +
                "who found that the great spiral nebula in Andromeda ------ Cepheld variables.",
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
                LevelType = LevelType.Advanced
            };

            var topic2 = new Question
            {
                Id = 112,
                QuestionType = QuestionType.Topic,
                Text = "Electric cars",
                LevelType = LevelType.Advanced
            };

            var topic3 = new Question
            {
                Id = 113,
                QuestionType = QuestionType.Topic,
                Text = "Rich world, poor world.",
                LevelType = LevelType.Advanced
            };

            var topic4 = new Question
            {
                Id = 114,
                QuestionType = QuestionType.Topic,
                Text = "Childhood trends",
                LevelType = LevelType.Advanced
            };

            var topic5 = new Question
            {
                Id = 115,
                QuestionType = QuestionType.Topic,
                Text = "Parenting",
                LevelType = LevelType.Advanced
            };

            builder.Entity<Question>().HasData(topic1, topic2, topic3, topic4, topic5);
            #endregion

            #region audition

            #region audition1
            var auditionQuestion1 = new Question
            {
                Id = 116,
                QuestionType = QuestionType.Audition,
                FileUrl = "https://6a63fca904fd268f15f7-d5770ffdd579eb31eaa89faeffc55fe7.ssl.cf1.rackcdn.com/Audio_zone-Music_in_Manchester.mp3",
                LevelType = LevelType.Advanced,
                Text = "What was the Hacienda?"
            };

            var answerAuditionQuestion11 = new Answer
            {
                Id = 241,
                QuestionId = 116,
                Text = "A mill",
                IsCorrect = false
            };

            var answerAuditionQuestion12 = new Answer
            {
                Id = 242,
                QuestionId = 116,
                Text = "A club",
                IsCorrect = true
            };

            var answerAuditionQuestion13 = new Answer
            {
                Id = 243,
                QuestionId = 116,
                Text = "A restaurant",
                IsCorrect = false
            };

            var answerAuditionQuestion14 = new Answer
            {
                Id = 244,
                QuestionId = 116,
                Text = "A pub",
                IsCorrect = false
            };
            #endregion

            #region audition2
            var auditionQuestion2 = new Question
            {
                Id = 117,
                QuestionType = QuestionType.Audition,
                FileUrl = "https://6a63fca904fd268f15f7-d5770ffdd579eb31eaa89faeffc55fe7.ssl.cf1.rackcdn.com/Audio_zone-Music_in_Manchester.mp3",
                LevelType = LevelType.Advanced,
                Text = "What was the Hacienda2?"
            };

            var answerAuditionQuestion21 = new Answer
            {
                Id = 245,
                QuestionId = 117,
                Text = "A mill",
                IsCorrect = false
            };

            var answerAuditionQuestion22 = new Answer
            {
                Id = 246,
                QuestionId = 117,
                Text = "A club",
                IsCorrect = true
            };

            var answerAuditionQuestion23 = new Answer
            {
                Id = 247,
                QuestionId = 117,
                Text = "A restaurant",
                IsCorrect = false
            };

            var answerAuditionQuestion24 = new Answer
            {
                Id = 248,
                QuestionId = 117,
                Text = "A pub",
                IsCorrect = false
            };
            #endregion

            #region audition3
            var auditionQuestion3 = new Question
            {
                Id = 118,
                QuestionType = QuestionType.Audition,
                FileUrl = "https://6a63fca904fd268f15f7-d5770ffdd579eb31eaa89faeffc55fe7.ssl.cf1.rackcdn.com/Audio_zone-Music_in_Manchester.mp3",
                LevelType = LevelType.Advanced,
                Text = "The Northern Quarter had mills in the industrial era, but what is there now?"
            };

            var answerAuditionQuestion31 = new Answer
            {
                Id = 249,
                QuestionId = 118,
                Text = "Coffee shops, clubs and restaurants",
                IsCorrect = true
            };

            var answerAuditionQuestion32 = new Answer
            {
                Id = 250,
                QuestionId = 118,
                Text = "Parks and green spaces",
                IsCorrect = false
            };

            var answerAuditionQuestion33 = new Answer
            {
                Id = 251,
                QuestionId = 118,
                Text = "Houses and schools",
                IsCorrect = false
            };

            var answerAuditionQuestion34 = new Answer
            {
                Id = 252,
                QuestionId = 118,
                Text = "Museums",
                IsCorrect = false
            };
            #endregion

            #region audition4
            var auditionQuestion4 = new Question
            {
                Id = 119,
                QuestionType = QuestionType.Audition,
                FileUrl = "https://6a63fca904fd268f15f7-d5770ffdd579eb31eaa89faeffc55fe7.ssl.cf1.rackcdn.com/Audio_zone-Music_in_Manchester.mp3",
                LevelType = LevelType.Advanced,
                Text = "What does Ella play?"
            };

            var answerAuditionQuestion41 = new Answer
            {
                Id = 253,
                QuestionId = 119,
                Text = "Violin and saxophone",
                IsCorrect = false
            };

            var answerAuditionQuestion42 = new Answer
            {
                Id = 254,
                QuestionId = 119,
                Text = "Guitar, piano and electronic instruments",
                IsCorrect = true
            };

            var answerAuditionQuestion43 = new Answer
            {
                Id = 255,
                QuestionId = 119,
                Text = "She doesnt play any instruments.",
                IsCorrect = false
            };

            var answerAuditionQuestion44 = new Answer
            {
                Id = 256,
                QuestionId = 119,
                Text = "She  plays the flute.",
                IsCorrect = false
            };

            #endregion

            #region audition5
            var auditionQuestion5 = new Question
            {
                Id = 120,
                QuestionType = QuestionType.Audition,
                FileUrl = "https://6a63fca904fd268f15f7-d5770ffdd579eb31eaa89faeffc55fe7.ssl.cf1.rackcdn.com/Audio_zone-Music_in_Manchester.mp3",
                LevelType = LevelType.Advanced,
                Text = "According to Ella, who spends more time in the studio?"
            };

            var answerAuditionQuestion51 = new Answer
            {
                Id = 257,
                QuestionId = 120,
                Text = "Manchester people",
                IsCorrect = true
            };

            var answerAuditionQuestion52 = new Answer
            {
                Id = 258,
                QuestionId = 120,
                Text = "London people",
                IsCorrect = false
            };

            var answerAuditionQuestion53 = new Answer
            {
                Id = 259,
                QuestionId = 120,
                Text = "Canadian people",
                IsCorrect = false
            };

            var answerAuditionQuestion54 = new Answer
            {
                Id = 260,
                QuestionId = 120,
                Text = "Russian people",
                IsCorrect = false
            };
            #endregion

            #region audition6

            var auditionQuestion6 = new Question
            {
                Id = 121,
                QuestionType = QuestionType.Audition,
                FileUrl = "https://6a63fca904fd268f15f7-d5770ffdd579eb31eaa89faeffc55fe7.ssl.cf1.rackcdn.com/Audio_zone-Music_in_Manchester.mp3",
                LevelType = LevelType.Advanced,
                Text = "Where was Ella born?"
            };

            var answerAuditionQuestion61 = new Answer
            {
                Id = 261,
                QuestionId = 120,
                Text = "Manchester",
                IsCorrect = false
            };

            var answerAuditionQuestion62 = new Answer
            {
                Id = 262,
                QuestionId = 120,
                Text = "London",
                IsCorrect = true
            };

            var answerAuditionQuestion63 = new Answer
            {
                Id = 263,
                QuestionId = 120,
                Text = "Canada",
                IsCorrect = false
            };

            var answerAuditionQuestion64 = new Answer
            {
                Id = 264,
                QuestionId = 120,
                Text = "Moscow",
                IsCorrect = false
            };
            #endregion

            #region audition7
            var auditionQuestion7 = new Question
            {
                Id = 122,
                QuestionType = QuestionType.Audition,
                FileUrl = "https://6a63fca904fd268f15f7-d5770ffdd579eb31eaa89faeffc55fe7.ssl.cf1.rackcdn.com/Audio_zone-Music_in_Manchester.mp3",
                LevelType = LevelType.Advanced,
                Text = "The Northern Quarter had mills in the industrial era, but what is there now2?"
            };

            var answerAuditionQuestion71 = new Answer
            {
                Id = 265,
                QuestionId = 122,
                Text = "Coffee shops, clubs and restaurants",
                IsCorrect = true
            };

            var answerAuditionQuestion72 = new Answer
            {
                Id = 266,
                QuestionId = 122,
                Text = "Parks and green spaces",
                IsCorrect = false
            };

            var answerAuditionQuestion73 = new Answer
            {
                Id = 267,
                QuestionId = 122,
                Text = "Houses and schools",
                IsCorrect = false
            };

            var answerAuditionQuestion74 = new Answer
            {
                Id = 268,
                QuestionId = 118,
                Text = "Museums",
                IsCorrect = false
            };
            #endregion

            #region audition8
            var auditionQuestion8 = new Question
            {
                Id = 123,
                QuestionType = QuestionType.Audition,
                FileUrl = "https://6a63fca904fd268f15f7-d5770ffdd579eb31eaa89faeffc55fe7.ssl.cf1.rackcdn.com/Audio_zone-Music_in_Manchester.mp3",
                LevelType = LevelType.Advanced,
                Text = "What does Ella play2?"
            };

            var answerAuditionQuestion81 = new Answer
            {
                Id = 269,
                QuestionId = 123,
                Text = "Violin and saxophone",
                IsCorrect = false
            };

            var answerAuditionQuestion82 = new Answer
            {
                Id = 270,
                QuestionId = 123,
                Text = "Guitar, piano and electronic instruments",
                IsCorrect = true
            };

            var answerAuditionQuestion83 = new Answer
            {
                Id = 271,
                QuestionId = 123,
                Text = "She doesnt play any instruments.",
                IsCorrect = false
            };

            var answerAuditionQuestion84 = new Answer
            {
                Id = 272,
                QuestionId = 123,
                Text = "She plays the flute.",
                IsCorrect = false
            };
            #endregion

            #region audition9
            var auditionQuestion9 = new Question
            {
                Id = 124,
                QuestionType = QuestionType.Audition,
                FileUrl = "https://6a63fca904fd268f15f7-d5770ffdd579eb31eaa89faeffc55fe7.ssl.cf1.rackcdn.com/Audio_zone-Music_in_Manchester.mp3",
                LevelType = LevelType.Advanced,
                Text = "According to Ella, who spends more time in the studio2?"
            };

            var answerAuditionQuestion91 = new Answer
            {
                Id = 273,
                QuestionId = 124,
                Text = "Manchester people",
                IsCorrect = true
            };

            var answerAuditionQuestion92 = new Answer
            {
                Id = 274,
                QuestionId = 124,
                Text = "London people",
                IsCorrect = false
            };

            var answerAuditionQuestion93 = new Answer
            {
                Id = 275,
                QuestionId = 124,
                Text = "Canadian people",
                IsCorrect = false
            };

            var answerAuditionQuestion94 = new Answer
            {
                Id = 276,
                QuestionId = 124,
                Text = "Russian people",
                IsCorrect = false
            };
            #endregion

            #region audition10

            var auditionQuestion10 = new Question
            {
                Id = 125,
                QuestionType = QuestionType.Audition,
                FileUrl = "https://6a63fca904fd268f15f7-d5770ffdd579eb31eaa89faeffc55fe7.ssl.cf1.rackcdn.com/Audio_zone-Music_in_Manchester.mp3",
                LevelType = LevelType.Advanced,
                Text = "Where was Ella born2?"
            };

            var answerAuditionQuestion101 = new Answer
            {
                Id = 277,
                QuestionId = 125,
                Text = "Manchester",
                IsCorrect = false
            };

            var answerAuditionQuestion102 = new Answer
            {
                Id = 278,
                QuestionId = 125,
                Text = "London",
                IsCorrect = true
            };

            var answerAuditionQuestion103 = new Answer
            {
                Id = 279,
                QuestionId = 125,
                Text = "Canada",
                IsCorrect = false
            };

            var answerAuditionQuestion104 = new Answer
            {
                Id = 280,
                QuestionId = 125,
                Text = "Moscow",
                IsCorrect = false
            };
            #endregion

            builder.Entity<Question>().HasData(
               auditionQuestion1, auditionQuestion2, auditionQuestion3, auditionQuestion4, auditionQuestion5,
               auditionQuestion6, auditionQuestion7, auditionQuestion8, auditionQuestion9, auditionQuestion10);

            builder.Entity<Answer>().HasData(
                answerAuditionQuestion11, answerAuditionQuestion12, answerAuditionQuestion13, answerAuditionQuestion14,
                answerAuditionQuestion21, answerAuditionQuestion22, answerAuditionQuestion23, answerAuditionQuestion24,
                answerAuditionQuestion31, answerAuditionQuestion32, answerAuditionQuestion33, answerAuditionQuestion34,
                answerAuditionQuestion41, answerAuditionQuestion42, answerAuditionQuestion43, answerAuditionQuestion44,
                answerAuditionQuestion51, answerAuditionQuestion52, answerAuditionQuestion53, answerAuditionQuestion54,
                answerAuditionQuestion61, answerAuditionQuestion62, answerAuditionQuestion63, answerAuditionQuestion64,
                answerAuditionQuestion71, answerAuditionQuestion72, answerAuditionQuestion73, answerAuditionQuestion74,
                answerAuditionQuestion81, answerAuditionQuestion82, answerAuditionQuestion83, answerAuditionQuestion84,
                answerAuditionQuestion91, answerAuditionQuestion92, answerAuditionQuestion93, answerAuditionQuestion94,
                answerAuditionQuestion101, answerAuditionQuestion102, answerAuditionQuestion103, answerAuditionQuestion104
                );
            #endregion

            return builder;
        }

        public static ModelBuilder FillProficiencyLevelWithData(this ModelBuilder builder)
        {
            #region ProficiencyGrammarQuestions
            var grammarQuestion1 = new Question
            {
                Id = 126,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "Tourists -------- when large numbers of middle class people ------- to join the more wealthy aristocratic travellers.",
                LevelType = LevelType.Proficiency
            };
            var grammarQuestion2 = new Question
            {
                Id = 127,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "The wounded hunter -------- on the ground for almost an hour when, coincidentally, he -------- by another hunter, who must have keen eyes",
                LevelType = LevelType.Proficiency
            };
            var grammarQuestion3 = new Question
            {
                Id = 128,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "As the tree was too high to climb, the mischievous boys ---------- their ball down only by throwing sticks at it.",
                LevelType = LevelType.Proficiency
            };
            var grammarQuestion4 = new Question
            {
                Id = 129,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "Certain serious diseases can be successfully treated -------- detected in an initial stage.",
                LevelType = LevelType.Proficiency
            };
            var grammarQuestion5 = new Question
            {
                Id = 130,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "---------- you have made minimal progress, it is by no means the kind of progress that you need to make.",
                LevelType = LevelType.Proficiency
            };
            var grammarQuestion6 = new Question
            {
                Id = 131,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "Soils are the result of -------- interacting processes -------- bring different materials together.",
                LevelType = LevelType.Proficiency
            };
            var grammarQuestion7 = new Question
            {
                Id = 132,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "Im ready to do ---------- I can do to help you - ------- your hardship.",
                LevelType = LevelType.Proficiency
            };
            var grammarQuestion8 = new Question
            {
                Id = 133,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "Despite my insistence, Adam didnt tell me -------- he didnt like me and my family.",
                LevelType = LevelType.Proficiency
            };
            var grammarQuestion9 = new Question
            {
                Id = 134,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "She keeps saying that she has got -------- patience with kids, but forgets that she didnt have -------- before she gave birth to her own kids.",
                LevelType = LevelType.Proficiency
            };
            var grammarQuestion10 = new Question
            {
                Id = 135,
                FileUrl = null,
                QuestionType = QuestionType.Grammar,
                Text = "If I -------- the choice of making either an oral or a written report, I -------- the second alternative.",
                LevelType = LevelType.Proficiency
            };
            #endregion

            #region ProficiencyGrammarAnswers
            var grammarAnswer1 = new Answer
            {
                Id = 406,
                QuestionId = 126,
                IsCorrect = false,
                Text = "have originated / had begun"
            };
            var grammarAnswer2 = new Answer
            {
                Id = 407,
                QuestionId = 126,
                IsCorrect = false,
                Text = "had originated / began"
            };
            var grammarAnswer3 = new Answer
            {
                Id = 408,
                QuestionId = 126,
                IsCorrect = false,
                Text = "could have originated / have begun"
            };
            var grammarAnswer4 = new Answer
            {
                Id = 409,
                QuestionId = 126,
                IsCorrect = true,
                Text = "originated / began"
            };

            var grammarAnswer5 = new Answer
            {
                Id = 410,
                QuestionId = 127,
                IsCorrect = false,
                Text = "has been lying / is spotting"
            };
            var grammarAnswer6 = new Answer
            {
                Id = 411,
                QuestionId = 127,
                IsCorrect = false,
                Text = "has lain / will be spotted"
            };
            var grammarAnswer7 = new Answer
            {
                Id = 412,
                QuestionId = 127,
                IsCorrect = false,
                Text = "will have lain / had been spotted"
            };
            var grammarAnswer8 = new Answer
            {
                Id = 413,
                QuestionId = 127,
                IsCorrect = true,
                Text = "had been lying / was spotted"
            };

            var grammarAnswer9 = new Answer
            {
                Id = 414,
                QuestionId = 128,
                IsCorrect = false,
                Text = "would have knocked"
            };
            var grammarAnswer10 = new Answer
            {
                Id = 415,
                QuestionId = 128,
                IsCorrect = true,
                Text = "were able to knock"
            };
            var grammarAnswer11 = new Answer
            {
                Id = 416,
                QuestionId = 128,
                IsCorrect = false,
                Text = "will have to knock"
            };
            var grammarAnswer12 = new Answer
            {
                Id = 417,
                QuestionId = 128,
                IsCorrect = false,
                Text = "may have knocked"
            };

            var grammarAnswer13 = new Answer
            {
                Id = 418,
                QuestionId = 129,
                IsCorrect = false,
                Text = "unless"
            };
            var grammarAnswer14 = new Answer
            {
                Id = 419,
                QuestionId = 129,
                IsCorrect = true,
                Text = "if"
            };
            var grammarAnswer15 = new Answer
            {
                Id = 420,
                QuestionId = 129,
                IsCorrect = false,
                Text = "even when"
            };
            var grammarAnswer16 = new Answer
            {
                Id = 421,
                QuestionId = 129,
                IsCorrect = false,
                Text = "before"
            };

            var grammarAnswer17 = new Answer
            {
                Id = 422,
                QuestionId = 130,
                IsCorrect = false,
                Text = "What"
            };
            var grammarAnswer18 = new Answer
            {
                Id = 423,
                QuestionId = 130,
                IsCorrect = false,
                Text = "Despite"
            };
            var grammarAnswer19 = new Answer
            {
                Id = 424,
                QuestionId = 130,
                IsCorrect = false,
                Text = "In addition to"
            };
            var grammarAnswer20 = new Answer
            {
                Id = 425,
                QuestionId = 130,
                IsCorrect = true,
                Text = "While"
            };

            var grammarAnswer21 = new Answer
            {
                Id = 426,
                QuestionId = 131,
                IsCorrect = false,
                Text = " a few / by which"
            };
            var grammarAnswer22 = new Answer
            {
                Id = 427,
                QuestionId = 131,
                IsCorrect = false,
                Text = "such / as"
            };
            var grammarAnswer23 = new Answer
            {
                Id = 428,
                QuestionId = 131,
                IsCorrect = true,
                Text = "some / that"
            };
            var grammarAnswer24 = new Answer
            {
                Id = 429,
                QuestionId = 131,
                IsCorrect = false,
                Text = "most of / which"
            };

            var grammarAnswer25 = new Answer
            {
                Id = 430,
                QuestionId = 132,
                IsCorrect = true,
                Text = "anything / overcome"
            };
            var grammarAnswer26 = new Answer
            {
                Id = 431,
                QuestionId = 132,
                IsCorrect = false,
                Text = "whatever / overcoming"
            };
            var grammarAnswer27 = new Answer
            {
                Id = 432,
                QuestionId = 132,
                IsCorrect = false,
                Text = "what / to be overcoming"
            };
            var grammarAnswer28 = new Answer
            {
                Id = 433,
                QuestionId = 132,
                IsCorrect = false,
                Text = "that / to have overcome"
            };

            var grammarAnswer29 = new Answer
            {
                Id = 434,
                QuestionId = 133,
                IsCorrect = true,
                Text = "why"
            };
            var grammarAnswer30 = new Answer
            {
                Id = 435,
                QuestionId = 133,
                IsCorrect = false,
                Text = "even if"
            };
            var grammarAnswer31 = new Answer
            {
                Id = 436,
                QuestionId = 133,
                IsCorrect = false,
                Text = "whose"
            };
            var grammarAnswer32 = new Answer
            {
                Id = 437,
                QuestionId = 133,
                IsCorrect = false,
                Text = "the reason"
            };

            var grammarAnswer33 = new Answer
            {
                Id = 438,
                QuestionId = 134,
                IsCorrect = true,
                Text = "enough / as much"
            };
            var grammarAnswer34 = new Answer
            {
                Id = 439,
                QuestionId = 134,
                IsCorrect = false,
                Text = "too many / any"
            };
            var grammarAnswer35 = new Answer
            {
                Id = 440,
                QuestionId = 134,
                IsCorrect = false,
                Text = "such / none"
            };
            var grammarAnswer36 = new Answer
            {
                Id = 441,
                QuestionId = 134,
                IsCorrect = false,
                Text = "so / some"
            };

            var grammarAnswer37 = new Answer
            {
                Id = 442,
                QuestionId = 135,
                IsCorrect = false,
                Text = "gave / could pick"
            };
            var grammarAnswer38 = new Answer
            {
                Id = 443,
                QuestionId = 135,
                IsCorrect = false,
                Text = "had been given / might pick"
            };
            var grammarAnswer39 = new Answer
            {
                Id = 444,
                QuestionId = 135,
                IsCorrect = false,
                Text = "would have given / had picked"
            };
            var grammarAnswer40 = new Answer
            {
                Id = 445,
                QuestionId = 135,
                IsCorrect = true,
                Text = "were given / would pick"
            };
            #endregion

            #region ProficiencyListeningQuestions
            var listeningQuestion1 = new Question
            {
                Id = 136,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "A combination of imagination and determination -------- Peter -------- entirely new lines of research concerned with the way animals survive extreme environmental conditions",
                LevelType = LevelType.Proficiency
            };
            var listeningQuestion2 = new Question
            {
                Id = 137,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "The scientist who -------- Dolly the sheep, the worlds first cloned mammal, -------- a licence on Tuesday to clone human embryos for medical research.",
                LevelType = LevelType.Proficiency
            };
            var listeningQuestion3 = new Question
            {
                Id = 138,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "My mother is making a steady recovery from flu and ------- hospital by next week.",
                LevelType = LevelType.Proficiency
            };
            var listeningQuestion4 = new Question
            {
                Id = 139,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "-------- a celebrity arrives in Istanbul, the first question reporters ask them is ------- they like Istanbul.",
                LevelType = LevelType.Proficiency
            };
            var listeningQuestion5 = new Question
            {
                Id = 140,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "The results of last weekends poll have ------- to be announced and officials say it could be -------- week before they are.",
                LevelType = LevelType.Proficiency
            };
            var listeningQuestion6 = new Question
            {
                Id = 141,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "She failed to get anyone to repair the taps for her at the weekend, -------- could she do it on her own.",
                LevelType = LevelType.Proficiency
            };
            var listeningQuestion7 = new Question
            {
                Id = 142,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "The neutral mutation rate is known -------- widely along human chromosomes, -------- to mutational hot and cold regions.",
                LevelType = LevelType.Proficiency
            };
            var listeningQuestion8 = new Question
            {
                Id = 143,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "You would not expect anyone -------- intelligent to make ------ stupid mistake, but he did so.",
                LevelType = LevelType.Proficiency
            };
            var listeningQuestion9 = new Question
            {
                Id = 144,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "I dont suppose you are telling us the true version of the story, ----------?",
                LevelType = LevelType.Proficiency
            };
            var listeningQuestion10 = new Question
            {
                Id = 145,
                FileUrl = null,
                QuestionType = QuestionType.Audition,
                Text = "Some people argue that certain oriental relaxation techniques ------- yoga and meditation are extremely effective in the treatment of high blood pressure.",
                LevelType = LevelType.Proficiency
            };
            #endregion

            #region  ProficiencyListeningAnswers
            var listeningAnswer1 = new Answer
            {
                Id = 446,
                QuestionId = 136,
                IsCorrect = false,
                Text = "allow / developing"
            };
            var listeningAnswer2 = new Answer
            {
                Id = 447,
                QuestionId = 136,
                IsCorrect = false,
                Text = "have allowed / being developed"
            };
            var listeningAnswer3 = new Answer
            {
                Id = 448,
                QuestionId = 136,
                IsCorrect = false,
                Text = "were allowed / to have developed"
            };
            var listeningAnswer4 = new Answer
            {
                Id = 449,
                QuestionId = 136,
                IsCorrect = true,
                Text = "allowed / to develop"
            };

            var listeningAnswer5 = new Answer
            {
                Id = 450,
                QuestionId = 137,
                IsCorrect = false,
                Text = "has created / has been granted"
            };
            var listeningAnswer6 = new Answer
            {
                Id = 451,
                QuestionId = 137,
                IsCorrect = false,
                Text = " had created / granted"
            };
            var listeningAnswer7 = new Answer
            {
                Id = 452,
                QuestionId = 137,
                IsCorrect = true,
                Text = "created / was granted"
            };
            var listeningAnswer8 = new Answer
            {
                Id = 453,
                QuestionId = 137,
                IsCorrect = false,
                Text = "will be creating / has granted"
            };

            var listeningAnswer9 = new Answer
            {
                Id = 454,
                QuestionId = 138,
                IsCorrect = false,
                Text = "could have left"
            };
            var listeningAnswer10 = new Answer
            {
                Id = 455,
                QuestionId = 138,
                IsCorrect = false,
                Text = "is leaving"
            };
            var listeningAnswer11 = new Answer
            {
                Id = 456,
                QuestionId = 138,
                IsCorrect = false,
                Text = "has left"
            };
            var listeningAnswer12 = new Answer
            {
                Id = 457,
                QuestionId = 138,
                IsCorrect = true,
                Text = "will have left"
            };

            var listeningAnswer13 = new Answer
            {
                Id = 458,
                QuestionId = 139,
                IsCorrect = false,
                Text = "During / whether"
            };
            var listeningAnswer14 = new Answer
            {
                Id = 459,
                QuestionId = 139,
                IsCorrect = true,
                Text = "Every time / how"
            };
            var listeningAnswer15 = new Answer
            {
                Id = 460,
                QuestionId = 139,
                IsCorrect = false,
                Text = "Whenever / what"
            };
            var listeningAnswer16 = new Answer
            {
                Id = 461,
                QuestionId = 139,
                IsCorrect = false,
                Text = "Until / if"
            };

            var listeningAnswer17 = new Answer
            {
                Id = 462,
                QuestionId = 140,
                IsCorrect = false,
                Text = "so far / every"
            };
            var listeningAnswer18 = new Answer
            {
                Id = 463,
                QuestionId = 140,
                IsCorrect = false,
                Text = "still / each"
            };
            var listeningAnswer19 = new Answer
            {
                Id = 464,
                QuestionId = 140,
                IsCorrect = false,
                Text = "already / every other"
            };
            var listeningAnswer20 = new Answer
            {
                Id = 465,
                QuestionId = 140,
                IsCorrect = true,
                Text = "yet / another"
            };

            var listeningAnswer21 = new Answer
            {
                Id = 466,
                QuestionId = 141,
                IsCorrect = false,
                Text = "as"
            };
            var listeningAnswer22 = new Answer
            {
                Id = 467,
                QuestionId = 141,
                IsCorrect = true,
                Text = "nor"
            };
            var listeningAnswer23 = new Answer
            {
                Id = 468,
                QuestionId = 141,
                IsCorrect = false,
                Text = "only"
            };
            var listeningAnswer24 = new Answer
            {
                Id = 469,
                QuestionId = 141,
                IsCorrect = false,
                Text = "so"
            };

            var listeningAnswer25 = new Answer
            {
                Id = 470,
                QuestionId = 141,
                IsCorrect = false,
                Text = "to be varying / to lead"
            };
            var listeningAnswer26 = new Answer
            {
                Id = 471,
                QuestionId = 141,
                IsCorrect = false,
                Text = "varying / led"
            };
            var listeningAnswer27 = new Answer
            {
                Id = 472,
                QuestionId = 141,
                IsCorrect = false,
                Text = "to have varied / being led"
            };
            var listeningAnswer28 = new Answer
            {
                Id = 473,
                QuestionId = 141,
                IsCorrect = true,
                Text = "to vary / leading"
            };

            var listeningAnswer29 = new Answer
            {
                Id = 474,
                QuestionId = 142,
                IsCorrect = true,
                Text = "so / that"
            };
            var listeningAnswer30 = new Answer
            {
                Id = 475,
                QuestionId = 142,
                IsCorrect = false,
                Text = "too / such"
            };
            var listeningAnswer31 = new Answer
            {
                Id = 476,
                QuestionId = 142,
                IsCorrect = false,
                Text = "as / as"
            };
            var listeningAnswer32 = new Answer
            {
                Id = 477,
                QuestionId = 142,
                IsCorrect = false,
                Text = "more / than"
            };

            var listeningAnswer33 = new Answer
            {
                Id = 478,
                QuestionId = 143,
                IsCorrect = false,
                Text = " do I"
            };
            var listeningAnswer34 = new Answer
            {
                Id = 479,
                QuestionId = 143,
                IsCorrect = true,
                Text = "are you"
            };
            var listeningAnswer35 = new Answer
            {
                Id = 480,
                QuestionId = 143,
                IsCorrect = false,
                Text = "can you"
            };
            var listeningAnswer36 = new Answer
            {
                Id = 481,
                QuestionId = 143,
                IsCorrect = false,
                Text = "will you"
            };

            var listeningAnswer37 = new Answer
            {
                Id = 482,
                QuestionId = 144,
                IsCorrect = false,
                Text = "so"
            };
            var listeningAnswer38 = new Answer
            {
                Id = 483,
                QuestionId = 144,
                IsCorrect = false,
                Text = "just as"
            };
            var listeningAnswer39 = new Answer
            {
                Id = 484,
                QuestionId = 144,
                IsCorrect = true,
                Text = "such as"
            };
            var listeningAnswer40 = new Answer
            {
                Id = 485,
                QuestionId = 144,
                IsCorrect = false,
                Text = "both"
            };
            #endregion

            #region ProficiencyTopics
            var topic1 = new Question
            {
                Id = 146,
                QuestionType = QuestionType.Topic,
                Text = "Are electric cars better for the environment?",
            };
            var topic2 = new Question
            {
                Id = 147,
                QuestionType = QuestionType.Topic,
                Text = "Do you think all citizens should be encouraged to do voluntary service overseas so as to understand the problems of poorer countries?",
            };
            var topic3 = new Question
            {
                Id = 148,
                QuestionType = QuestionType.Topic,
                Text = "What is the purpose of the misinformation?",
            };
            var topic4 = new Question
            {
                Id = 149,
                QuestionType = QuestionType.Topic,
                Text = "Do people tend to be more violent when they group together? (gangs / mobs / crowds)",
            };
            var topic5 = new Question
            {
                Id = 150,
                QuestionType = QuestionType.Topic,
                Text = "What are the worst consequences of a natural disaster?",
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

        public static ModelBuilder FillPassedTest(this ModelBuilder builder)
        {
            var userAnswer = new UserAnswer()
            {
                Id = 1,
                PassedTestId = 1,
                QuestionId = 1,
                Answer = "true",
                Assessment = 50
            };

            var userAnswer1 = new UserAnswer()
            {
                Id = 2,
                PassedTestId = 1,
                QuestionId = 1,
                Answer = "true",
                Assessment = 50
            };

            var passedTest = new PassedTest
            {
                Id = 1,
                UserId = 1,
                CheckerId = 2,
                UserTestId = null,
                LevelType = LevelType.Elementary,
                Assessment = 50,
                Status = StatusType.Active,
                PassedTestDate = DateTime.Now.AddHours(3)
            };

            var userAnswer2 = new UserAnswer()
            {
                Id = 3,
                PassedTestId = 2,
                QuestionId = 2,
                Answer = "true",
                Assessment = 50,
                ReportId = null
            };

            var userAnswer3 = new UserAnswer()
            {
                Id = 4,
                PassedTestId = 2,
                QuestionId = 2,
                Answer = "true",
                Assessment = 50,
                ReportId = null
            };

            var passedTest1 = new PassedTest
            {
                Id = 2,
                UserId = 2,
                CheckerId = 3,
                UserTestId = null,
                LevelType = LevelType.Beginner,
                Assessment = 50,
                Status = StatusType.Active,
                PassedTestDate = DateTime.Now.AddHours(3)
            };

            var userAnswer4 = new UserAnswer()
            {
                Id = 5,
                PassedTestId = 3,
                QuestionId = 1,
                Answer = "true",
                Assessment = 50,
                ReportId = null
            };

            var userAnswer5 = new UserAnswer()
            {
                Id = 6,
                PassedTestId = 3,
                QuestionId = 3,
                Answer = "true",
                Assessment = 50,
                ReportId = null
            };

            var passedTest2 = new PassedTest
            {
                Id = 3,
                UserId = 1,
                CheckerId = 2,
                UserTestId = null,
                LevelType = LevelType.Intermediate,
                Assessment = 50,
                Status = StatusType.Active,
                PassedTestDate = DateTime.Now.AddHours(3)
            };

            builder.Entity<PassedTest>()
                 .HasData(passedTest, passedTest1, passedTest2);

            builder.Entity<UserAnswer>()
                .HasData(userAnswer, userAnswer1, userAnswer2, userAnswer3, userAnswer4, userAnswer5);

            return builder;
        }

        public static ModelBuilder FillUsers(this ModelBuilder builder)
        {

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

            return builder;
        }
    }
}
