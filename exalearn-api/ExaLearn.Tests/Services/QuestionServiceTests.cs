using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using ExaLearn.Bl.Mapping;
using ExaLearn.Bl.Services;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
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
        private readonly IMapper _mapper;
        private readonly IQuestionService _questionService;

        public QuestionServiceTests()
        {
            _mockQuestionRepository = new Mock<IQuestionRepository>();
            _mockPassedTestRepository = new Mock<IPassedTestRepository>();

            _mapper = MapperConfigurationProvider.GetConfig().CreateMapper();

            _questionService = new QuestionService(_mockQuestionRepository.Object,
                _mockPassedTestRepository.Object, _mapper);
        }

        [Fact]
        public async Task CreateAudioQuestionAsync_IsValid_Result_Ok()
        {
            //Arrange
            _mockQuestionRepository.Setup(x => x.CreateAsync(It.IsAny<Question>()))
           .Returns(async () =>
           {
               return await Task.Factory.StartNew(() => new Question()
               {
                   LevelType = LevelType.Beginner,
                   QuestionType = QuestionType.Audition,
                   Text = "AuditionQuestion",
                   FileUrl = "aofvhajfvadfjb",
                   Answers = new List<Answer>
                   {
                        new Answer
                        {
                            Text="1",
                            IsCorrect=false,
                        },
                        new Answer
                        {
                            Text="2",
                            IsCorrect=false,
                        },
                        new Answer
                        {
                            Text="3",
                            IsCorrect=false,
                        },
                        new Answer
                        {
                            Text="4",
                            IsCorrect=true,
                        }
                   }
               });
           });

            var auditionQuestionDTO = new AuditionQuestionDTO
            {
                LevelType = LevelType.Beginner,
                Question = "AuditionQuestion",
                QuestionType = QuestionType.Audition,
                Url = "aofvhajfvadfjb",
                Answers = new List<AnswerDTO>
                {
                    new AnswerDTO
                    {
                        Text="1",
                        IsCorrect=false,
                    },
                     new AnswerDTO
                     {
                        Text="2",
                        IsCorrect=false,
                    },
                      new AnswerDTO
                      {
                        Text="3",
                        IsCorrect=false,
                    },
                       new AnswerDTO
                       {
                        Text="4",
                        IsCorrect=true,
                    },
                }
            };
            // Act
            var result = await _questionService.CreateAudioQuestionAsync(auditionQuestionDTO);
            // Assert
            Assert.NotNull(result);
            Assert.Equal(QuestionType.Audition, result.QuestionType);
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
                        Answers = new List<Answer>
                        {
                                        new Answer
                                        {
                                            Text="1",
                                            IsCorrect=false,
                                        },
                                        new Answer
                                        {
                                            Text="2",
                                            IsCorrect=false,
                                        },
                                        new Answer
                                        {
                                            Text="3",
                                            IsCorrect=false,
                                        },
                                        new Answer
                                        {
                                            Text="4",
                                            IsCorrect=true,
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
                    new AnswerDTO{
                    Text="1",
                    IsCorrect=false,
                    },
                     new AnswerDTO{
                    Text="2",
                    IsCorrect=false,
                    },
                      new AnswerDTO{
                    Text="3",
                    IsCorrect=false,
                    },
                       new AnswerDTO{
                    Text="4",
                    IsCorrect=true,
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
            _mockQuestionRepository.Setup(x => x.CreateAsync(It.IsAny<Question>()))
                .Returns(async () =>
                {
                    return await Task.Factory.StartNew(() => new Question()
                    {
                        LevelType = LevelType.Elementary,
                        QuestionType = QuestionType.Topic,
                        Text = "Topic"
                    });
                });

            var topicQuestionDTO = new TopicQuestionDTO
            {
                QuestionType = QuestionType.Topic,
                Topic = "Topic"
            };

            // Act
            var result = await _questionService.CreateTopicQuestionAsync(topicQuestionDTO);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(QuestionType.Topic, result.QuestionType);
        }

        [Theory]
        [InlineData(LevelType.Beginner)]
        public async Task GenerateTestAsync_IsValid_Result_Ok(LevelType level)
        {
            //Arrange
            _mockQuestionRepository.Setup(x => x.GetGrammarQuestionsAsync(It.IsAny<LevelType>()))
              .Returns(async () =>
              {
                  return await Task.Factory.StartNew(() => new List<Question>()
                  {
                        new Question
                        {
                            Id=1,
                            QuestionType=QuestionType.Grammar,
                            Text="GrammarQuestion1",
                            LevelType=LevelType.Beginner,
                            Answers= new List<Answer>()
                            {
                               new Answer
                               {
                                    Text="1",
                                    IsCorrect=false,
                               },
                               new Answer
                               {
                                    Text="2",
                                    IsCorrect=false,
                               },
                               new Answer
                               {
                                    Text="3",
                                    IsCorrect=false,
                               },
                               new Answer
                               {
                                    Text="4",
                                    IsCorrect=true,
                               }
                            }
                        },
                        new Question
                        {
                            Id=2,
                            QuestionType=QuestionType.Grammar,
                            Text="GrammarQuestion2",
                            LevelType=LevelType.Beginner,
                            Answers= new List<Answer>()
                            {
                               new Answer
                               {
                                    Text="1",
                                    IsCorrect=false,
                               },
                               new Answer
                               {
                                    Text="2",
                                    IsCorrect=false,
                               },
                               new Answer
                               {
                                    Text="3",
                                    IsCorrect=false,
                               },
                               new Answer
                               {
                                    Text="4",
                                    IsCorrect=true,
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
                            Id=3,
                            QuestionType=QuestionType.Audition,
                            FileUrl="dlrjgndln",
                            Text="AuditionQuestion1",
                            LevelType=LevelType.Beginner,
                            Answers= new List<Answer>()
                            {
                               new Answer
                               {
                                    Text="1",
                                    IsCorrect=false,
                               },
                               new Answer
                               {
                                    Text="2",
                                    IsCorrect=false,
                               },
                               new Answer
                               {
                                    Text="3",
                                    IsCorrect=false,
                               },
                               new Answer
                               {
                                    Text="4",
                                    IsCorrect=true,
                               }
                            }
                        },
                        new Question
                        {
                            Id=4,
                            QuestionType=QuestionType.Audition,
                            FileUrl="dlrjgndln",
                            Text="AuditionQuestion2",
                            LevelType=LevelType.Beginner,
                            Answers= new List<Answer>()
                            {
                               new Answer
                               {
                                    Text="1",
                                    IsCorrect=false,
                               },
                               new Answer
                               {
                                    Text="2",
                                    IsCorrect=false,
                               },
                               new Answer
                               {
                                    Text="3",
                                    IsCorrect=false,
                               },
                               new Answer
                               {
                                    Text="4",
                                    IsCorrect=true,
                               }
                            }
                        }
                    });
                });

            _mockQuestionRepository.Setup(x => x.GetTopicsAsync())
                .Returns(async () =>
                {
                    return await Task.Factory.StartNew(() => new List<Question>()
                    { new Question
                        {
                            Id=5,
                            QuestionType=QuestionType.Topic,
                            Text="TopicQuestion1",
                        },
                        new Question
                        {
                            Id=6,
                            QuestionType=QuestionType.Topic,
                            Text="TopicQuestion2",
                        }
                    });
                });

            // Act
            var generatedTest = await _questionService.GenerateTestAsync(level);
            // Assert
            Assert.NotNull(generatedTest);
        }
    }
}