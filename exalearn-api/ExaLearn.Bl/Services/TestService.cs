using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using ExaLearn.Dal.Interfaces;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Services
{
    public class TestService : ITestService
    {
        private readonly IPassedTestRepository _passedTestRepository;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public TestService(IUserAnswerRepository userAnswerRepository,
           IPassedTestRepository passedTestRepository,
           IUserRepository userRepository,
           IMapper mapper)
        {
            _passedTestRepository = passedTestRepository;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<PassedTestForCheckDTO> GetUserTestByPassedTestIdAsync(int passedTestId, string checker)
        {
            var passedTest = await _passedTestRepository.GetByIdAsync(passedTestId);
            var checkerId = await _userRepository.FindByNameAsync(checker);
            passedTest.CheckerId = checkerId;
            passedTest.Status = Shared.Enums.StatusType.InCoachProgress;
            _ = await _passedTestRepository.UpdateAsync(passedTest);

            var userTest = await _passedTestRepository.GetUserTestByPassedTestIdAsync(passedTestId);
            return _mapper.Map<PassedTestForCheckDTO>(userTest);
        }
    }
}
