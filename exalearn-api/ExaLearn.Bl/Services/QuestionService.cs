using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using ExaLearn.Bl.Mapping;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly IPassedTestRepository _passedTestRepository;
        private readonly IUserTestRepository _userTestRepository;
        private readonly IAssignTestRepository _assignTestRepository;
        private readonly IMapper _mapper;

        public QuestionService(IQuestionRepository questionRepository, IPassedTestRepository passedTestRepository, IUserTestRepository userTestRepository, IAssignTestRepository assignTestRepository, IMapper mapper)
        {
            _questionRepository = questionRepository;
            _passedTestRepository = passedTestRepository;
            _userTestRepository = userTestRepository;
            _assignTestRepository = assignTestRepository;
            _mapper = mapper;
        }

        public async Task<TestDTO> GenerateTestAsync(GenerateTestDTO generateTestDTO)
        {
            var grammarQuestions = await _questionRepository.GetGrammarQuestionsAsync(generateTestDTO.LevelType);
            var auditionQuestions = await _questionRepository.GetAuditionQuestionsAsync(generateTestDTO.LevelType);
            var topics = await _questionRepository.GetTopicsAsync();

            var allQuestions = new List<Question>();

            allQuestions.AddRange(grammarQuestions);
            allQuestions.AddRange(auditionQuestions);
            allQuestions.AddRange(topics);

            var userTest = new UserTest() { Questions = allQuestions };

            await _userTestRepository.CreateAsync(userTest);

            var passedTest = _mapper.Map<PassedTest>(generateTestDTO).Map(userTest);
            passedTest.PassedTestDate = DateTime.Now;
            await _passedTestRepository.CreateAsync(passedTest);

            if (passedTest.AssignTestId != null)
            {
                var assignTest = await _assignTestRepository.GetByIdAsync((int)passedTest.AssignTestId);
                assignTest.Passed = true;
                await _assignTestRepository.UpdateAsync(assignTest);
            }

            var grammarQuestionsDTO = _mapper.Map<GrammarQuestionDTO[]>(grammarQuestions);
            var auditionQuestionsDTO = _mapper.Map<AuditionQuestionDTO[]>(auditionQuestions);
            var topicsDTO = _mapper.Map<TopicQuestionDTO[]>(topics);

            foreach (var z in grammarQuestionsDTO.SelectMany(item => item.Answers))
            {
                z.IsCorrect = null;
            }

            foreach (var z in auditionQuestionsDTO.SelectMany(item => item.Answers))
            {
                z.IsCorrect = null;
            }

            BackgroundJob.Schedule(() => _passedTestRepository.CloseTestAsync(passedTest.Id), TimeSpan.FromMinutes(61));

            return _mapper.Map<TestDTO>(passedTest.Id).Map(grammarQuestionsDTO).Map(auditionQuestionsDTO).Map(topicsDTO);
        }

        public async Task<AuditionQuestionDTO[]> CreateAudioQuestionAsync(AuditionQuestionDTO[] audioQuestionDTO)
        {
            var question = await _questionRepository.AddRangeAsync(_mapper.Map<Question[]>(audioQuestionDTO));
            return _mapper.Map<AuditionQuestionDTO[]>(question);
        }

        public async Task<GrammarQuestionDTO> CreateGrammarQuestionAsync(GrammarQuestionDTO grammarQuestionDTO)
        {
            var question = await _questionRepository.CreateAsync(_mapper.Map<Question>(grammarQuestionDTO));
            return _mapper.Map<GrammarQuestionDTO>(question);
        }

        public async Task<TopicQuestionDTO[]> CreateTopicQuestionAsync(TopicQuestionDTO[] topicQuestionDTO)
        {
            var question = await _questionRepository.AddRangeAsync(_mapper.Map<Question[]>(topicQuestionDTO));
            return _mapper.Map<TopicQuestionDTO[]>(question);
        }
    }
}
