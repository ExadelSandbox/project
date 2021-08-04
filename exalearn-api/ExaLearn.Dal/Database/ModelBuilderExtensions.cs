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
            builder.FillElementaryLevelWithData();
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

        public static void FillElementaryLevelWithData(this ModelBuilder builder) {
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
            };

            var topic2 = new Question
            {
                Id = 72,
                QuestionType = QuestionType.Topic,
                Text = "Describing people",
            };

            var topic3 = new Question
            {
                Id = 73,
                QuestionType = QuestionType.Topic,
                Text = "Greetings & introductions",
            };

            var topic4 = new Question
            {
                Id = 74,
                QuestionType = QuestionType.Topic,
                Text = "Money",
            };

            var topic5 = new Question
            {
                Id = 75,
                QuestionType = QuestionType.Topic,
                Text = "Past tense themes",
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
    }
}
