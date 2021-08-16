using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using ExaLearn.Shared.Enums;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Services
{
    public class TestService : ITestService
    {
        private readonly IPassedTestRepository _passedTestRepository;
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public TestService(IPassedTestRepository passedTestRepository,
           UserManager<User> userManager,
           IMapper mapper)
        {
            _passedTestRepository = passedTestRepository;
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<PassedTestForCheckDTO> GetUserTestByPassedTestIdAsync(int passedTestId, string checkerEmail)
        {
            var passedTest = await _passedTestRepository.GetByIdAsync(passedTestId);
            var checker = await _userManager.FindByEmailAsync(checkerEmail);

            passedTest.CheckerId = checker.Id;
            passedTest.Status = StatusType.InCoachProgress;

            await _passedTestRepository.UpdateAsync(passedTest);

            var userTest = await _passedTestRepository.GetUserTestByPassedTestIdAsync(passedTestId);
            return _mapper.Map<PassedTestForCheckDTO>(userTest);
        }
    }
}
