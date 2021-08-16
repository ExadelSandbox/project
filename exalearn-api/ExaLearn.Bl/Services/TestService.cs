using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using ExaLearn.Shared.Enums;
using Microsoft.AspNetCore.Identity;
using Shared.Enums;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Services
{
    public class TestService : ITestService
    {
        private readonly IPassedTestRepository _passedTestRepository;
        private readonly IAssessmentRepository _assessmentRepository;
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public TestService(IPassedTestRepository passedTestRepository, IAssessmentRepository assessmentRepository,
           UserManager<User> userManager,
           IMapper mapper)
        {
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

            foreach (var item in userAnswers)
            {
                if (item.Assessment == 1)
                {
                    if (item.Question.QuestionType == QuestionType.Audition) //in liuq
                        assessment.Audition++;
                    if (item.Question.QuestionType == QuestionType.Grammar) // in linq 
                        assessment.Grammar++;
                }
            }

            int assessmentCount = 4;

            assessment.General = (assessment.Audition + assessment.Grammar + assessment.Speaking + assessment.Essay) / assessmentCount;

            await _assessmentRepository.SaveChangesAsync();

            passedTest.AssessmentId = assessment.Id;
            await _passedTestRepository.UpdateAsync(passedTest);

            return _mapper.Map<AssessmentDTO>(assessment);
        }
    }
}
