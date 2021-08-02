using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Mapping;
using ExaLearn.Bl.Services;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using ExaLearn.Dal.Model;
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
        private readonly IMapper _mapper;
        private readonly QuestionService _questionService;

        public QuestionServiceTests()
        {
            _mockQuestionRepository = new Mock<IQuestionRepository>();

            _mockQuestionRepository.Setup(x => x.CreateAsync(It.IsAny<Question>()))
            .Returns(async () =>
            {
                return await Task.Factory.StartNew(() => new Question()
                {
                    LevelType = LevelType.Beginner,
                    Type = QuestionType.Audition,
                    Text = "AuditionQuestion",
                    AudioFile = new AudioFile { Url = "aofvhajfvadfjb" },
                    Answers = new List<Answer>
                    {
                        new Answer{
                        Text="1",
                        IsCorrect=false,
                        },
                         new Answer{
                        Text="2",
                        IsCorrect=false,
                        },
                          new Answer{
                        Text="3",
                        IsCorrect=false,
                        },
                           new Answer{
                        Text="4",
                        IsCorrect=true,
                        }
                    }
                });
            });

            _mockQuestionRepository.Setup(x => x.CreateAsync(It.IsAny<Question>()))
            .Returns(async () =>
            {
                return await Task.Factory.StartNew(() => new Question()
                {
                    LevelType = LevelType.Beginner,
                    Type = QuestionType.Grammar,
                    Text = "GrammarQuestion",
                    Answers = new List<Answer>
                {
                    new Answer{
                    Text="1",
                    IsCorrect=false,
                    },
                     new Answer{
                    Text="2",
                    IsCorrect=false,
                    },
                      new Answer{
                    Text="3",
                    IsCorrect=false,
                    },
                       new Answer{
                    Text="4",
                    IsCorrect=true,
                    }
                }
                });
            });

            _mockQuestionRepository.Setup(x => x.CreateAsync(It.IsAny<Question>()))
            .Returns(async () =>
            {
                return await Task.Factory.StartNew(() => new Question()
                {
                    LevelType = LevelType.Elementary,
                    Type = QuestionType.Essay,
                    Text = "Topic"
                });
            });            

            _mapper = MapperConfigurationProvider.GetConfig().CreateMapper();

            _questionService = new QuestionService(_mockQuestionRepository.Object, _mapper);
        }

        [Fact]
        public async Task CreateAudioQuestionAsync_IsValid_Result_Ok()
        {
            //Arrange
            var auditionQuestionDTO = new AuditionQuestionDTO
            {
                Level = LevelType.Beginner,
                Question = "AuditionQuestion",
                Url = "aofvhajfvadfjb",
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
            var result = await _questionService.CreateAudioQuestionAsync(auditionQuestionDTO);
            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public async Task CreateGrammarQuestionAsync_IsValid_Result_Ok()
        {
            //Arrange           
            var grammarQuestionDTO = new GrammarQuestionDTO
            {
                Level = LevelType.Beginner,
                Question = "GrammarQuestion",
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
        }

        [Fact]
        public async Task CreateTopicQuestionAsync_IsValid_Result_Ok()
        {
            //Arrange  
            var topicQuestionDTO = new TopicQuestionDTO
            {
                Level = LevelType.Elementary,
                Type = QuestionType.Essay,
                Topic = "Topic"
            };

            // Act
            var result = await _questionService.CreateTopicQuestionAsync(topicQuestionDTO);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(QuestionType.Essay, result.Type);
        }

        [Theory]
        [InlineData(LevelType.Beginner)]
        [InlineData(LevelType.Elementary)]
        [InlineData(LevelType.Intermediate)]
        public async Task GenerateTestAsync_IsValid_Result_Ok(LevelType level)
        {
            ////Arange

            
            ////_mockQuestionRepository.Verify(x => x.GetGrammarQuestionAsync(level), Times.Once);
            //// Act
            //var generatedTest = await _questionService.GenerateTestAsync(level);
            //// Assert
            //Assert.NotNull(generatedTest);
        }
    }
}