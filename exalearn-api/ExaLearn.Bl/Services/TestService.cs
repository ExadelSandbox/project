using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Bl.EmailService;
using ExaLearn.Bl.Interfaces;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using ExaLearn.Shared.Enums;
using Microsoft.AspNetCore.Identity;
using Shared.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Services
{
    public class TestService : ITestService
    {
        private readonly IPassedTestRepository _passedTestRepository;
        private readonly IAssessmentRepository _assessmentRepository;
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public TestService(IPassedTestRepository passedTestRepository, IAssessmentRepository assessmentRepository,
           UserManager<User> userManager,
           IMapper mapper,
           IUserRepository userRepository)
        {
            _userRepository = userRepository;
            _assessmentRepository = assessmentRepository;
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

        public async Task<AssessmentDTO> CreateAssesmentAsync(AssessmentDTO assessmentDTO)
        {
            var passedTest = await _passedTestRepository.GetByIdAsync(assessmentDTO.passedTestId);
            var assessment = _mapper.Map<Assessment>(assessmentDTO);
            var userAnswers = passedTest.UserAnswers;

            await _assessmentRepository.CreateAsync(assessment);

            assessment.Audition = userAnswers
                .Where(x => x.Question.QuestionType == QuestionType.Audition && x.Assessment == 1)
                .Select(x => x.Assessment)
                .Sum();

            assessment.Grammar = userAnswers
                .Where(x => x.Question.QuestionType == QuestionType.Audition && x.Assessment == 1)
                .Select(x => x.Assessment)
                .Sum();

            int assessmentCount = 4;
            assessment.General = (assessment.Audition + assessment.Grammar + assessment.Speaking + assessment.Essay) / assessmentCount;
            await _assessmentRepository.SaveChangesAsync();
            passedTest.AssessmentId = assessment.Id;
            passedTest.Status = StatusType.Checked;
            await _passedTestRepository.UpdateAsync(passedTest);

            var user = await _userRepository.GetByIdAsync(passedTest.UserId);

            if (assessment.General >= 6)
            {
                user.LevelType = passedTest.LevelType;
                await _userManager.UpdateAsync(user);
            }

            var emailMessage = MessageBuilder.GenerateMessageForUserAsync(user, passedTest.LevelType, passedTest.PassedTestDate, "checkEng");

            EmailSender.SendEmailAsync(emailMessage).GetAwaiter();

            return _mapper.Map<AssessmentDTO>(assessment);
        }

        public async Task<IList<PassedTestDTO>> GetUnverifiedTestsAsync(string userName)
        {
            var user = await _userManager.FindByEmailAsync(userName);
            var tests = await _passedTestRepository.GetUnverifiedTestsAsync(user.Id);
            return _mapper.Map<IList<PassedTestDTO>>(tests);
        }
    }
}
