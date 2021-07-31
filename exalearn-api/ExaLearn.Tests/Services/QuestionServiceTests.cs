using AutoFixture;
using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using ExaLearn.Bl.Services;
using ExaLearn.Dal.Interfaces;
using Moq;
using Shared.Enums;
using System.Threading.Tasks;
using Xunit;

namespace ExaLearn.Tests.Services
{
    public class QuestionServiceTests
    {
        private readonly QuestionService _sut;
        private readonly Mock<IMapper> _mockmapper = new Mock<IMapper>();
        private readonly Mock<IQuestionService> _mockQuestionService = new Mock<IQuestionService>();
        private readonly Mock<IQuestionRepository> _mockQuestionRepository = new Mock<IQuestionRepository>();

        public QuestionServiceTests()
        {
            _sut = new QuestionService(_mockQuestionRepository.Object, _mockmapper.Object);
        }

        [Theory]
        [InlineData(LevelType.Beginner)]
        [InlineData(LevelType.Elementary)]
        [InlineData(LevelType.Intermediate)]
        public async Task GenerateTestAsync_IsValid_Result_Ok(LevelType level)
        {
            //Arange
            _mockQuestionService.Setup(x => x.GenerateTestAsync(
                (global::Shared.Enums.LevelType)It.Is<int>(i => i >= 1 && i <= 6)))
              .Returns(() =>
              {
                  return new Task<TestDTO>(() => new TestDTO());
              });

            //_mockQuestionRepository.Verify(x => x.GetGrammarQuestionAsync(level), Times.Once);
            // Act
            var generatedTest = await _sut.GenerateTestAsync(level);

            // Assert
            Assert.NotNull(generatedTest);
        }

        [Fact]
        public async Task CreateAudioQuestionAsync_IsValid_Result_Ok()
        {
            //Arrange

            var audioQuestionDTO = new AutoFixture.Fixture().Build<AuditionQuestionDTO>()
                .Without(x => x.Id).Create();

            _mockQuestionService.Setup(x => x.CreateAudioQuestionAsync(audioQuestionDTO))
            .Returns(async () =>
            {
                return await new Task<AuditionQuestionDTO>(() => new AuditionQuestionDTO());
            });

            // Act
            var audioQuestion = await _sut.CreateAudioQuestionAsync(audioQuestionDTO);

            // Assert
            Assert.NotNull(audioQuestion);
        }

        [Fact]
        public async Task CreateGrammarQuestionAsync_IsValid_Result_Ok()
        {
            //Arrange
            var grammarQuestionDTO = new AutoFixture.Fixture().Build<GrammarQuestionDTO>()
                .Without(x => x.Id).Create();

            _mockQuestionService.Setup(x => x.CreateGrammarQuestionAsync(grammarQuestionDTO))
            .Returns(async () =>
            {
                return await new Task<GrammarQuestionDTO>(() => new GrammarQuestionDTO());
            });

            // Act
            var grammarQuestion = await _sut.CreateGrammarQuestionAsync(grammarQuestionDTO);

            // Assert
            Assert.NotNull(grammarQuestion);
        }

        [Fact]
        public async Task CreateTopicQuestionAsync_IsValid_Result_Ok()
        {
            //Arrange
            //var topicQuestionDTO = new AutoFixture.Fixture().Build<TopicQuestionDTO>()
            //    .With(x => x.Type, QuestionType.Essay).Without(x => x.Id).Create();

            var topicQuestionDTO = new TopicQuestionDTO
            {
                Level = LevelType.Elementary,
                Type = QuestionType.Essay,
                Topic = "Topic31072021"
            };

            _mockQuestionService.Setup(x => x.CreateTopicQuestionAsync(topicQuestionDTO))
            .Returns(async () =>
            {
                return await new Task<TopicQuestionDTO>(() => new TopicQuestionDTO());
            });

            // Act
            var topicQuestion = await _sut.CreateTopicQuestionAsync(topicQuestionDTO);

            // Assert
            Assert.NotNull(topicQuestion);
        }
    }
}