using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using ExaLearn.Bl.Mapping;
using ExaLearn.Bl.Services;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using ExaLearn.Shared.Enums;
using Moq;
using Shared.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace ExaLearn.Tests.Services
{
    public class QuestionServiceTests
    {
        private readonly Mock<IQuestionRepository> _mockQuestionRepository;
        private readonly Mock<IPassedTestRepository> _mockPassedTestRepository;
        private readonly Mock<IUserTestRepository> _mockUserTestRepository;
        private readonly Mock<IAssignTestRepository> _mockAssignTestRepository;
        private readonly Mock<IAnswerRepository> _mockAnswerRepository;

        private readonly IMapper _mapper;
        private readonly IQuestionService _questionService;

        public QuestionServiceTests()
        {
            _mockQuestionRepository = new Mock<IQuestionRepository>();
            _mockPassedTestRepository = new Mock<IPassedTestRepository>();
            _mockUserTestRepository = new Mock<IUserTestRepository>();
            _mockAssignTestRepository = new Mock<IAssignTestRepository>();
            _mockAnswerRepository = new Mock<IAnswerRepository>();

            _mapper = MapperConfigurationProvider.GetConfig().CreateMapper();

            _questionService = new QuestionService(
                _mockQuestionRepository.Object,
                _mockPassedTestRepository.Object,
                _mockUserTestRepository.Object,
                _mockAssignTestRepository.Object,
                _mockAnswerRepository.Object,
                _mapper);
        }

        [Fact]
        public async Task CreateAudioQuestionAsync_IsValid_Result_Ok()
        {
            //Arrange
            _mockQuestionRepository.Setup(x => x.AddRangeAsync(It.IsAny<IList<Question>>()))
           .Returns(async () =>
           {
               return await Task.Factory.StartNew(() => new List<Question>()
               {
                   new Question(){
                       LevelType = LevelType.Beginner,
                       QuestionType = QuestionType.Audition,
                       Text = "AuditionQuestion1",
                       FileUrl = "url",
                       Answers = new List<Answer>
                       {
                            new Answer
                            {
                                Text = "1",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "2",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "3",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "4",
                                IsCorrect = true,
                            }
                       }
                   },
                   new Question()
                   {
                       LevelType = LevelType.Beginner,
                       QuestionType = QuestionType.Audition,
                       Text = "AuditionQuestion2",
                       FileUrl = "url",
                       Answers = new List<Answer>
                       {
                            new Answer
                            {
                                Text = "1",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "2",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "3",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "4",
                                IsCorrect = true,
                            }
                       }
                   }
               });
           });

            var auditionQuestionDTO = new AuditionQuestionDTO[]
            {
                new AuditionQuestionDTO()
                {
                    LevelType = LevelType.Beginner,
                    Question = "AuditionQuestion1",
                    QuestionType = QuestionType.Audition,
                    Url = "url",
                    Answers = new List<AnswerDTO>
                    {
                        new AnswerDTO
                        {
                            Text = "1",
                            IsCorrect =false,
                        },
                        new AnswerDTO
                        {
                            Text = "2",
                            IsCorrect = false,
                        },
                        new AnswerDTO
                        {
                            Text = "3",
                            IsCorrect = false,
                        },
                        new AnswerDTO
                        {
                            Text = "4",
                            IsCorrect = true,
                        },
                    }
                },
                new AuditionQuestionDTO()
                {
                    LevelType = LevelType.Beginner,
                    Question = "AuditionQuestion2",
                    QuestionType = QuestionType.Audition,
                    Url = "url",
                    Answers = new List<AnswerDTO>
                    {
                        new AnswerDTO
                        {
                            Text = "1",
                            IsCorrect =false,
                        },
                        new AnswerDTO
                        {
                            Text = "2",
                            IsCorrect = false,
                        },
                        new AnswerDTO
                        {
                            Text = "3",
                            IsCorrect = false,
                        },
                        new AnswerDTO
                        {
                            Text = "4",
                            IsCorrect = true,
                        },
                    }
                }
            };
            // Act
            var result = await _questionService.CreateAudioQuestionAsync(auditionQuestionDTO);
            // Assert
            Assert.NotNull(result);
            Assert.Equal(QuestionType.Audition, result[0].QuestionType);
        }

        [Fact]
        public async Task CreateGrammarQuestionAsync_IsValid_Result_Ok()
        {
            //Arrange
            _mockQuestionRepository.Setup(x => x.CreateAsync(It.IsAny<Question>()))
                .Returns(async () =>
                {
                    return await Task.Factory.StartNew(() => new Question()
                    {
                        LevelType = LevelType.Beginner,
                        QuestionType = QuestionType.Grammar,
                        Text = "GrammarQuestion",
                        Answers = new List<Answer> {
                            new Answer
                            {
                                Text = "1",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "2",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "3",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "4",
                                IsCorrect = true,
                            }
                        }
                    });
                });

            var grammarQuestionDTO = new GrammarQuestionDTO
            {
                LevelType = LevelType.Beginner,
                Question = "GrammarQuestion",
                QuestionType = QuestionType.Grammar,
                Answers = new List<AnswerDTO>
                {
                    new AnswerDTO
                    {
                        Text = "1",
                        IsCorrect=false,
                    },
                    new AnswerDTO{
                        Text = "2",
                        IsCorrect = false,
                    },
                    new AnswerDTO{
                        Text = "3",
                        IsCorrect = false,
                    },
                    new AnswerDTO{
                        Text = "4",
                        IsCorrect = true,
                    }
                }
            };
            // Act
            var result = await _questionService.CreateGrammarQuestionAsync(grammarQuestionDTO);
            // Assert
            Assert.NotNull(result);
            Assert.Equal(QuestionType.Grammar, result.QuestionType);
        }

        [Fact]
        public async Task CreateTopicQuestionAsync_IsValid_Result_Ok()
        {
            //Arrange  
            _mockQuestionRepository.Setup(x => x.AddRangeAsync(It.IsAny<IList<Question>>()))
                .Returns(async () =>
                {
                    return await Task.Factory.StartNew(() => new List<Question>()
                    {
                        new Question()
                        {
                            LevelType = LevelType.Elementary,
                            QuestionType = QuestionType.Topic,
                            Text = "essay"
                         },
                        new Question()
                        {
                            LevelType = LevelType.Elementary,
                            QuestionType = QuestionType.Topic,
                            Text = "speaking"
                        }
                    });
                });

            var topicQuestionDTO1 = new TopicQuestionDTO
            {
                QuestionType = QuestionType.Topic,
                Topic = "essay"
            };

            var topicQuestionDTO2 = new TopicQuestionDTO
            {
                QuestionType = QuestionType.Topic,
                Topic = "speaking"
            };

            // Act
            var result = await _questionService.CreateTopicQuestionAsync(new[] { topicQuestionDTO1, topicQuestionDTO2 });

            // Assert
            Assert.NotNull(result);
            Assert.Equal(QuestionType.Topic, result[0].QuestionType);
        }

        [Fact]
        public async Task GenerateTestAsync_IsValid_Result_Ok()
        {
            //Arrange
            _mockQuestionRepository.Setup(x => x.GetGrammarQuestionsAsync(It.IsAny<LevelType>()))
              .Returns(async () =>
              {
                  return await Task.Factory.StartNew(() => new List<Question>()
                  {
                        new Question
                        {
                            Id = 1,
                            QuestionType = QuestionType.Grammar,
                            Text = "GrammarQuestion1",
                            LevelType = LevelType.Beginner,
                            Answers = new List<Answer>()
                            {
                               new Answer
                               {
                                    Text = "1",
                                    IsCorrect = false,
                               },
                               new Answer
                               {
                                    Text = "2",
                                    IsCorrect = false,
                               },
                               new Answer
                               {
                                    Text = "3",
                                    IsCorrect = false,
                               },
                               new Answer
                               {
                                    Text = "4",
                                    IsCorrect = true,
                               }
                            }
                        },
                        new Question
                        {
                            Id = 2,
                            QuestionType = QuestionType.Grammar,
                            Text = "GrammarQuestion2",
                            LevelType = LevelType.Beginner,
                            Answers = new List<Answer>()
                            {
                               new Answer
                               {
                                    Text = "1",
                                    IsCorrect  =false,
                               },
                               new Answer
                               {
                                    Text = "2",
                                    IsCorrect = false,
                               },
                               new Answer
                               {
                                    Text = "3",
                                    IsCorrect = false,
                               },
                               new Answer
                               {
                                    Text = "4",
                                    IsCorrect = true,
                               }
                            }
                        }
                  });
              });

            _mockQuestionRepository.Setup(x => x.GetAuditionQuestionsAsync(It.IsAny<LevelType>()))
                .Returns(async () =>
                {
                    return await Task.Factory.StartNew(() => new List<Question>()
                    {
                        new Question
                        {
                            Id = 3,
                            QuestionType = QuestionType.Audition,
                            FileUrl = "url",
                            Text = "AuditionQuestion1",
                            LevelType = LevelType.Beginner,
                            Answers = new List<Answer>()
                            {
                               new Answer
                               {
                                    Text = "1",
                                    IsCorrect = false,
                               },
                               new Answer
                               {
                                    Text = "2",
                                    IsCorrect = false,
                               },
                               new Answer
                               {
                                    Text = "3",
                                    IsCorrect = false,
                               },
                               new Answer
                               {
                                    Text = "4",
                                    IsCorrect = true,
                               }
                            }
                        },
                        new Question
                        {
                            Id = 4,
                            QuestionType = QuestionType.Audition,
                            FileUrl = "url",
                            Text = "AuditionQuestion2",
                            LevelType = LevelType.Beginner,
                            Answers = new List<Answer>()
                            {
                               new Answer
                               {
                                    Text = "1",
                                    IsCorrect = false,
                               },
                               new Answer
                               {
                                    Text = "2",
                                    IsCorrect = false,
                               },
                               new Answer
                               {
                                    Text = "3",
                                    IsCorrect = false,
                               },
                               new Answer
                               {
                                    Text = "4",
                                    IsCorrect = true,
                               }
                            }
                        }
                    });
                });

            _mockQuestionRepository.Setup(x => x.GetTopicsAsync())
                .Returns(async () =>
                {
                    return await Task.Factory.StartNew(() => new List<Question>()
                    {
                        new Question
                        {
                            Id = 5,
                            QuestionType = QuestionType.Topic,
                            Text = "TopicQuestion1",
                        },
                        new Question
                        {
                            Id = 6,
                            QuestionType = QuestionType.Topic,
                            Text = "TopicQuestion2",
                        }
                    });
                });

            _mockUserTestRepository.Setup(x => x.CreateAsync(It.IsAny<UserTest>()))
                .Returns(async () =>
                {
                    return await Task.Factory.StartNew(() => new UserTest()
                    {
                        Questions = new List<Question>
                        {
                            new Question
                            {
                                Id = 1,
                                QuestionType = QuestionType.Grammar,
                                Text = "GrammarQuestion1",
                                LevelType = LevelType.Beginner,
                                Answers = new List<Answer>()
                                {
                                   new Answer
                                   {
                                        Text = "1",
                                        IsCorrect = false,
                                   },
                                   new Answer
                                   {
                                        Text = "2",
                                        IsCorrect = false,
                                   },
                                   new Answer
                                   {
                                        Text = "3",
                                        IsCorrect = false,
                                   },
                                   new Answer
                                   {
                                        Text = "4",
                                        IsCorrect = true,
                                   }
                                }
                            },
                            new Question
                            {
                                Id = 2,
                                QuestionType = QuestionType.Grammar,
                                Text = "GrammarQuestion2",
                                LevelType = LevelType.Beginner,
                                Answers = new List<Answer>()
                                {
                                   new Answer
                                   {
                                        Text = "1",
                                        IsCorrect  =false,
                                   },
                                   new Answer
                                   {
                                        Text = "2",
                                        IsCorrect = false,
                                   },
                                   new Answer
                                   {
                                        Text = "3",
                                        IsCorrect = false,
                                   },
                                   new Answer
                                   {
                                        Text = "4",
                                        IsCorrect = true,
                                   }
                                }
                            },

                            new Question
                            {
                                Id = 3,
                                QuestionType = QuestionType.Audition,
                                FileUrl = "url",
                                Text = "AuditionQuestion1",
                                LevelType = LevelType.Beginner,
                                Answers = new List<Answer>()
                                {
                                   new Answer
                                   {
                                        Text = "1",
                                        IsCorrect = false,
                                   },
                                   new Answer
                                   {
                                        Text = "2",
                                        IsCorrect = false,
                                   },
                                   new Answer
                                   {
                                        Text = "3",
                                        IsCorrect = false,
                                   },
                                   new Answer
                                   {
                                        Text = "4",
                                        IsCorrect = true,
                                   }
                                }
                            },
                            new Question
                            {
                                Id = 4,
                                QuestionType = QuestionType.Audition,
                                FileUrl = "url",
                                Text = "AuditionQuestion2",
                                LevelType = LevelType.Beginner,
                                Answers = new List<Answer>()
                                {
                                   new Answer
                                   {
                                        Text = "1",
                                        IsCorrect = false,
                                   },
                                   new Answer
                                   {
                                        Text = "2",
                                        IsCorrect = false,
                                   },
                                   new Answer
                                   {
                                        Text = "3",
                                        IsCorrect = false,
                                   },
                                   new Answer
                                   {
                                        Text = "4",
                                        IsCorrect = true,
                                   }
                                }
                            },

                            new Question
                            {
                                Id = 5,
                                QuestionType = QuestionType.Topic,
                                Text = "TopicQuestion1",
                            },
                            new Question
                            {
                                Id = 6,
                                QuestionType = QuestionType.Topic,
                                Text = "TopicQuestion2",
                            }
                        }
                    });
                });

            var generateTestDTO = new GenerateTestDTO
            {
                UserId=1,
                LevelType =LevelType.Beginner,
                Status = StatusType.Active,
            };

            _mockPassedTestRepository.Setup(x => x.CreateAsync(It.IsAny<PassedTest>()))
                .Returns(async () =>
                {
                    return await Task.Factory.StartNew(() => new PassedTest()
                    {
                        UserId = 1,
                        LevelType = LevelType.Beginner,
                        Status = StatusType.Active,
                        UserTest = new UserTest {                         
                            Questions = new List<Question>
                            {
                                new Question
                                {
                                    Id = 1,
                                    QuestionType = QuestionType.Grammar,
                                    Text = "GrammarQuestion1",
                                    LevelType = LevelType.Beginner,
                                    Answers = new List<Answer>()
                                    {
                                       new Answer
                                       {
                                            Text = "1",
                                            IsCorrect = false,
                                       },
                                       new Answer
                                       {
                                            Text = "2",
                                            IsCorrect = false,
                                       },
                                       new Answer
                                       {
                                            Text = "3",
                                            IsCorrect = false,
                                       },
                                       new Answer
                                       {
                                            Text = "4",
                                            IsCorrect = true,
                                       }
                                    }
                                },
                                new Question
                                {
                                    Id = 2,
                                    QuestionType = QuestionType.Grammar,
                                    Text = "GrammarQuestion2",
                                    LevelType = LevelType.Beginner,
                                    Answers = new List<Answer>()
                                    {
                                       new Answer
                                       {
                                            Text = "1",
                                            IsCorrect  =false,
                                       },
                                       new Answer
                                       {
                                            Text = "2",
                                            IsCorrect = false,
                                       },
                                       new Answer
                                       {
                                            Text = "3",
                                            IsCorrect = false,
                                       },
                                       new Answer
                                       {
                                            Text = "4",
                                            IsCorrect = true,
                                       }
                                    }
                                },

                                new Question
                                {
                                    Id = 3,
                                    QuestionType = QuestionType.Audition,
                                    FileUrl = "url",
                                    Text = "AuditionQuestion1",
                                    LevelType = LevelType.Beginner,
                                    Answers = new List<Answer>()
                                    {
                                       new Answer
                                       {
                                            Text = "1",
                                            IsCorrect = false,
                                       },
                                       new Answer
                                       {
                                            Text = "2",
                                            IsCorrect = false,
                                       },
                                       new Answer
                                       {
                                            Text = "3",
                                            IsCorrect = false,
                                       },
                                       new Answer
                                       {
                                            Text = "4",
                                            IsCorrect = true,
                                       }
                                    }
                                },
                                new Question
                                {
                                    Id = 4,
                                    QuestionType = QuestionType.Audition,
                                    FileUrl = "url",
                                    Text = "AuditionQuestion2",
                                    LevelType = LevelType.Beginner,
                                    Answers = new List<Answer>()
                                    {
                                       new Answer
                                       {
                                            Text = "1",
                                            IsCorrect = false,
                                       },
                                       new Answer
                                       {
                                            Text = "2",
                                            IsCorrect = false,
                                       },
                                       new Answer
                                       {
                                            Text = "3",
                                            IsCorrect = false,
                                       },
                                       new Answer
                                       {
                                            Text = "4",
                                            IsCorrect = true,
                                       }
                                    }
                                },

                                new Question
                                {
                                    Id = 5,
                                    QuestionType = QuestionType.Topic,
                                    Text = "TopicQuestion1",
                                },
                                new Question
                                {
                                    Id = 6,
                                    QuestionType = QuestionType.Topic,
                                    Text = "TopicQuestion2",
                                }
                            }
                        }
                    });
                });

            // Act
            var generatedTest = await _questionService.GenerateTestAsync(generateTestDTO);
            // Assert
            Assert.NotNull(generatedTest);
        }
    }
}