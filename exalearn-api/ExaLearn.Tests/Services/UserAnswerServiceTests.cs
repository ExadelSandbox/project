using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using ExaLearn.Bl.Mapping;
using ExaLearn.Bl.Services;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using ExaLearn.WebApi.EqualityComparers;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace ExaLearn.Tests.Services
{
    public class UserAnswerServiceTests
    {
        private readonly Mock<IUserAnswerRepository> _mockUserAnswerRepository;
        private readonly IMapper _mapper;
        private readonly IUserAnswerService _userAnswerService;

        public UserAnswerServiceTests()
        {
            _mockUserAnswerRepository = new Mock<IUserAnswerRepository>();

            _mapper = MapperConfigurationProvider.GetConfig().CreateMapper();

            _userAnswerService = new UserAnswerService(_mockUserAnswerRepository.Object, _mapper);
        }

        [Fact]
        public async Task GetUserAnswersAsync_UserAnswerModelIsValid()
        {
            // Arrange
            _mockUserAnswerRepository.Setup(x => x.CreateUserAnswersAsync(It.IsAny<List<UserAnswer>>()))
                .Returns(async () =>
                {
                    return await Task.Factory.StartNew(() => new List<UserAnswer>()
                    {
                        new UserAnswer
                        {
                            Id = 1,
                            PassedTestId = 1,
                            QuestionId = 1,
                            FileUrl = "fff.ru",
                            Assessment = 6
                        },
                        new UserAnswer
                        {
                            Id = 2,
                            PassedTestId = 2,
                            QuestionId = 2,
                            FileUrl = "zzzz.ru",
                            Assessment = 8
                        }
                    });
                });

            var userAnswerDto = new List<UserAnswerDTO>()
            {
                new UserAnswerDTO()
                {
                    Id = 1,
                    PassedTestId = 1,
                    QuestionId = 1,
                    FileUrl = "fff.ru",
                    Assessment = 6,
                },
                new UserAnswerDTO()
                {
                    Id = 2,
                    PassedTestId = 2,
                    QuestionId = 2,
                    FileUrl = "zzzz.ru",
                    Assessment = 8
                }
            };

            // Act
            var result = await _userAnswerService.CreateUserAnswersAsync(userAnswerDto);

            // Assert
            Assert.NotNull(result);

            Assert.Equal(userAnswerDto, result, new UserAnswerDTOEqualityComparer());
        }
    }
}
