using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Services
{
    public class TestService : ITestService
    {
        private readonly IUserAnswerRepository _userAnswerRepository;
        private readonly IPassedTestRepository _passedTestRepository;
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public TestService(IUserAnswerRepository userAnswerRepository,
           IPassedTestRepository passedTestRepository,
           UserManager<User> userManager,
           IMapper mapper)
        {
            _userAnswerRepository = userAnswerRepository;
            _passedTestRepository = passedTestRepository;
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<PassedTestDTO> GetUserTestByPassedTestIdAsync(int passedTestId, string checker)
        {
            var passedTest = await _passedTestRepository.GetByIdAsync(passedTestId);
            var checkerId = _userManager.FindByNameAsync(checker).Id;       

            var userTest = _passedTestRepository.GetUserTestByPassedTestIdAsync(passedTestId);
            return _mapper.Map<PassedTestDTO>(userTest);
        }
    }
}
