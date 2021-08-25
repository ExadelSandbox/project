using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using ExaLearn.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Services
{
    public class UserAnswerService : IUserAnswerService
    {
        private readonly IUserAnswerRepository _userAnswerRepository;
        private readonly IPassedTestRepository _passedTestRepository;
        private readonly IAssignTestRepository _assignTestRepository;
        private readonly IMapper _mapper;

        public UserAnswerService(IUserAnswerRepository userAnswerRepository, IPassedTestRepository passedTestRepository,
            IAssignTestRepository assignTestRepository, IMapper mapper)
        {
            _passedTestRepository = passedTestRepository;
            _userAnswerRepository = userAnswerRepository;
            _assignTestRepository = assignTestRepository;
            _mapper = mapper;
        }

        public async Task<List<UserAnswerDTO>> CreateUserAnswersAsync(List<UserAnswerDTO> userAnswersDTO)
        {
            var userAnswers = await _userAnswerRepository.AddRangeAsync(_mapper.Map<List<UserAnswer>>(userAnswersDTO));
            var passedTestId = userAnswers.Select(u => u.PassedTestId).FirstOrDefault();
            var correctQuestionAnswers = await _userAnswerRepository.GetCorrectQuestionsAnswers(passedTestId);
            
            if (userAnswers.Count == 0 || correctQuestionAnswers.Count == 0)
            {
                return _mapper.Map<List<UserAnswerDTO>>(userAnswers);
            }

            foreach (var ua in userAnswers.Where(ua => ua.Answer != null))
            {
                ua.Assessment += (correctQuestionAnswers.Where(qa => ua.QuestionId == qa.QuestionId && ua.Answer == qa.Text)).Count();
            }

            await _userAnswerRepository.SaveChangesAsync();

            var passedTest = await _passedTestRepository.GetByIdAsync(passedTestId);
            passedTest.Status = StatusType.Completed;
            passedTest.PassedTestDate = DateTime.Now;

            await _passedTestRepository.UpdateAsync(passedTest);

            return _mapper.Map<List<UserAnswerDTO>>(userAnswers);
        }
    }
}
