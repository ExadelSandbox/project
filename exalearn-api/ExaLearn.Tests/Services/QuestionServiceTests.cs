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
        // _mockQuestionService.Setup(x => x.GenerateTestAsync(
        //      (global::Shared.Enums.LevelType)It.Is<int>(i => i >= 1 && i <= 6)))
        //     .Returns(async () =>
        //     {
        //         return await new Task<TestDTO>(() => new TestDTO());
        //     });

        // _mockQuestionRepository.Setup(x => x.GetGrammarQuestionAsync(
        //     (global::Shared.Enums.LevelType)It.Is<int>(i => i >= 1 && i <= 6)))
        // .Returns(async () =>
        //     {
        //         return await new Task<List<Question>>(() => new List<Question>());
        //     });

        // _mockQuestionRepository.Setup(x => x.GetAuditionQuestionAsync(
        //     (global::Shared.Enums.LevelType)It.Is<int>(i => i >= 1 && i <= 6)))
        // .Returns(async () =>
        // {
        //     return await new Task<List<Question>>(() => new List<Question>());
        // });

        // _mockQuestionRepository.Setup(x => x.GetEssayTopicAsync(
        //    (global::Shared.Enums.LevelType)It.Is<int>(i => i >= 1 && i <= 6)))
        //.Returns(async () =>
        //{
        //    return await new Task<List<Question>>(() => new List<Question>());
        //});

        // _mockQuestionRepository.Setup(x => x.GetSpeakingTopicAsync(
        //    (global::Shared.Enums.LevelType)It.Is<int>(i => i >= 1 && i <= 6)))
        //.Returns(async () =>
        //{
        //    return await new Task<List<Question>>(() => new List<Question>());
        //});     

        [Theory]
        [InlineData(LevelType.Beginner)]
        [InlineData(LevelType.Elementary)]
        [InlineData(LevelType.Intermediate)]
        public async Task GenerateTestAsync_IsValid_Result_Ok(LevelType level)
        {
            _mockQuestionService.Setup(x => x.GenerateTestAsync((global::Shared.Enums.LevelType)It.Is<int>(i => i >= 1 && i <= 6)))
              .Returns(() =>
              {
                  return new Task<TestDTO>(() => new TestDTO());
              });

            _mockQuestionRepository.Verify(x => x.GetGrammarQuestionAsync(level), Times.Once);
            // Act
            var generatedTest = await _sut.GenerateTestAsync(level);

            // Assert
            Assert.NotNull(generatedTest);
        }

        [Theory]
        [InlineData(LevelType.Beginner)]
        public async Task GenerateTestAsync_IsNotValid_Result_Error(LevelType level)
        {
            _mockQuestionService.Setup(x => x.GenerateTestAsync((global::Shared.Enums.LevelType)It.Is<int>(i => i > 6)))
              .Returns(() => null);

            var generatedTest = await _sut.GenerateTestAsync(level);

            // Assert
            Assert.Null(generatedTest);
        }
    }
}
