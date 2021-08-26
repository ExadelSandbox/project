using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using ExaLearn.Bl.Mapping;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using Hangfire;
using Shared.Enums;
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
        private readonly IAnswerRepository _answerRepository;
        private readonly IMapper _mapper;

        public QuestionService(IQuestionRepository questionRepository, IPassedTestRepository passedTestRepository, IUserTestRepository userTestRepository, IAssignTestRepository assignTestRepository, IAnswerRepository answerRepository, IMapper mapper)
        {
            _questionRepository = questionRepository;
            _passedTestRepository = passedTestRepository;
            _userTestRepository = userTestRepository;
            _assignTestRepository = assignTestRepository;
            _answerRepository = answerRepository;
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

        public async Task<QuestionDTO[]> GetByTypeAsync(LevelType? level, QuestionType? questionType)
        {
            IList<Question> questions;
            if (questionType.HasValue && questionType.Value == QuestionType.Topic)
            {
                questions = await _questionRepository.GetByExpressionAsync(q => q.QuestionType == questionType);
                return _mapper.Map<QuestionDTO[]>(questions);
            }

            if (level.HasValue && questionType.HasValue)
            {
                questions = await _questionRepository.GetByExpressionAsync(q =>
                q.LevelType == level.Value && q.QuestionType == questionType.Value);
                return _mapper.Map<QuestionDTO[]>(questions);
            }

            questions = level.HasValue && !questionType.HasValue
                ? await _questionRepository.GetByExpressionAsync(q => q.LevelType == level.Value)
                : await _questionRepository.GetByExpressionAsync(q => q.QuestionType == questionType.Value);

            return _mapper.Map<QuestionDTO[]>(questions);
        }

        public async Task<QuestionDTO> UpdateAsync(QuestionDTO question)
        {
            foreach (var item in question.Answers)
            {
                var answer = _mapper.Map<Answer>(item);
                answer.QuestionId = question.Id;
                await _answerRepository.UpdateAsync(answer);
            }

            var _question = await _questionRepository.UpdateAsync(_mapper.Map<Question>(question));
            return _mapper.Map<QuestionDTO>(_question);
        }

        public async Task<QuestionDTO> GetByIdAsync(int questionId)
        {
            var question = await _questionRepository.GetQuestionByIdAsync(questionId);
            return _mapper.Map<QuestionDTO>(question);
        }

        public async Task<QuestionDTO> DeleteAsync(QuestionDTO question)
        {
            var deletequestion = await _questionRepository.GetQuestionByIdAsync(question.Id);
            deletequestion.IsArchive = true;
            deletequestion = await _questionRepository.UpdateAsync(deletequestion);
            return _mapper.Map<QuestionDTO>(deletequestion);
        }
    }
}