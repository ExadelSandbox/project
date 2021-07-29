using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
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
        private readonly Mock<IMapper> _mockmapper;
        private readonly Mock<IQuestionService> _mockQuestionService;
        private readonly Mock<IQuestionRepository> _mockQuestionRepository;

        public QuestionServiceTests()
        {
            _mockmapper = new Mock<IMapper>();
            _mockQuestionService = new Mock<IQuestionService>();
            _mockQuestionRepository = new Mock<IQuestionRepository>();

            _mockQuestionService.Setup(x => x.GenerateTestAsync(
                 (global::Shared.Enums.LevelType)It.Is<int>(i => i >= 1 && i <= 6)))
                .Returns(async () =>
                {
                    return await new Task<TestDTO>(() => new TestDTO());
                });

            _mockQuestionRepository.Setup(x => x.GetGrammarQuestionAsync(
                (global::Shared.Enums.LevelType)It.Is<int>(i => i >= 1 && i <= 6)))
            .Returns(async () =>
                {
                    return await new Task<List<Question>>(() => new List<Question>());
                });

            _mockQuestionRepository.Setup(x => x.GetAuditionQuestionAsync(
                (global::Shared.Enums.LevelType)It.Is<int>(i => i >= 1 && i <= 6)))
            .Returns(async () =>
            {
                return await new Task<List<Question>>(() => new List<Question>());
            });

            _mockQuestionRepository.Setup(x => x.GetEssayTopicAsync(
               (global::Shared.Enums.LevelType)It.Is<int>(i => i >= 1 && i <= 6)))
           .Returns(async () =>
           {
               return await new Task<List<Question>>(() => new List<Question>());
           });

            _mockQuestionRepository.Setup(x => x.GetSpeakingTopicAsync(
               (global::Shared.Enums.LevelType)It.Is<int>(i => i >= 1 && i <= 6)))
           .Returns(async () =>
           {
               return await new Task<List<Question>>(() => new List<Question>());
           });
        }


        [Theory]
        [InlineData(LevelType.Beginner)]
        [InlineData(LevelType.Elementary)]
        [InlineData(LevelType.Intermediate)]
        public async Task GenerateTestAsync_IsValid_Result_Ok(LevelType level)
        {
            //Arrange
            var service = new QuestionService(_mockQuestionRepository.Object, _mockmapper.Object);

            // Act
            TestDTO result = await service.GenerateTestAsync(level);

            // Assert
            Assert.NotNull(result);
        }
    }
}
