using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using ExaLearn.Shared.Enums;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Services
{
    public class UserAnswerService : IUserAnswerService
    {
        private readonly IUserAnswerRepository _userAnswerRepository;
        private readonly IPassedTestRepository _passedTestRepository;
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public UserAnswerService(IUserAnswerRepository userAnswerRepository,
            IPassedTestRepository passedTestRepository,
            UserManager<User> userManager,
            IMapper mapper)
        {
            _userAnswerRepository = userAnswerRepository;
            _passedTestRepository = passedTestRepository;
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<List<UserAnswerDTO>> CheckUserAnswersAsync(int passedTestId, string userName)
        {
            var passedTest = await _passedTestRepository.GetByIdAsync(passedTestId);
            var checkerId = _userManager.FindByNameAsync(userName).Id;

            passedTest.CheckerId = checkerId;
            passedTest.Status = Shared.Enums.StatusType.InCoachProgress;
            _ = _passedTestRepository.UpdateAsync(passedTest);

            var checkUserAnswer = await _userAnswerRepository.GetUserAnswersByPassedTestId(passedTestId);
            return _mapper.Map<List<UserAnswerDTO>>(checkUserAnswer);
        }

        public async Task<List<UserAnswerDTO>> CreateUserAnswersAsync(List<UserAnswerDTO> userAnswersDTO)
        {
            var userAnswer =  await _userAnswerRepository.AddRangeAsync(_mapper.Map<List<UserAnswer>>(userAnswersDTO));
            return _mapper.Map<List<UserAnswerDTO>>(userAnswer);
        }

        public object SaveCheckUserAnswersAsync(PassedTestDTO passedTestDto)
        {
            passedTestDto.Status = StatusType.Checked;
            var passedTest = _passedTestRepository.UpdateAsync(_mapper.Map<PassedTest>(passedTestDto));
            return _mapper.Map<PassedTestDTO>(passedTest);
        }
    }
}
