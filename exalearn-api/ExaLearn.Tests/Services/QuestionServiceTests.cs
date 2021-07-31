using AutoFixture;
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
        private readonly Mock<IQuestionRepository> _mockQuestionRepository = new Mock<IQuestionRepository>();
        private readonly QuestionService _questionService;
        private readonly IMapper _mapper = MapperConfigurationProvider.GetConfig().CreateMapper();

        public QuestionServiceTests()
        {
            _questionService = new QuestionService(_mockQuestionRepository.Object, _mapper);
        }

        [Fact]
        public async Task CreateAudioQuestionAsync_IsValid_Result_Ok()
        {
            //Arrange
            var audioQuestion = new Question
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
            };

            _mockQuestionRepository.Setup(x => x.CreateAsync(audioQuestion))
            .Returns(async () =>
            {
                return await new Task<Question>(() => new Question());
            });

            var audioQuestionDTO = new AuditionQuestionDTO
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
            var result = await _questionService.CreateAudioQuestionAsync(audioQuestionDTO);

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public async Task CreateGrammarQuestionAsync_IsValid_Result_Ok()
        {
            //Arrange
            var grammarQuestion = new Question
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
            };

            _mockQuestionRepository.Setup(x => x.CreateAsync(grammarQuestion))
            .Returns(async () =>
            {
                return await new Task<Question>(() => new Question());
            });
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
            var topicQuestion = new Question
            {
                LevelType = LevelType.Elementary,
                Type = QuestionType.Essay,
                Text = "Topic31072021"
            };

            _mockQuestionRepository.Setup(x => x.CreateAsync(topicQuestion))
            .Returns(async () =>
            {
                return await new Task<Question>(() => new Question());
            });

            var topicQuestionDTO = new TopicQuestionDTO
            {
                Level = LevelType.Elementary,
                Type = QuestionType.Essay,
                Topic = "Topic31072021"
            };

            // Act
            var result = await _questionService.CreateTopicQuestionAsync(topicQuestionDTO);

            // Assert
            Assert.NotNull(result);
        }

        //[Theory]
        //[InlineData(LevelType.Beginner)]
        //[InlineData(LevelType.Elementary)]
        //[InlineData(LevelType.Intermediate)]
        //public async Task GenerateTestAsync_IsValid_Result_Ok(LevelType level)
        //{
        //    //Arange

        //   /////////

        //    //_mockQuestionRepository.Verify(x => x.GetGrammarQuestionAsync(level), Times.Once);
        //    // Act
        //    var generatedTest = await _questionService.GenerateTestAsync(level);

        //    // Assert
        //    Assert.NotNull(generatedTest);
        //}
    }
}