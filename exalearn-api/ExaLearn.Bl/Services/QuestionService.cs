using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using ExaLearn.Bl.Mapping;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly IPassedTestRepository _passedTestRepository;
        private readonly IUserTestRepository _userTestRepository;
        private readonly IMapper _mapper;

        public QuestionService(IQuestionRepository questionRepository, IPassedTestRepository passedTestRepository, IUserTestRepository userTestRepository, IMapper mapper)
        {
            _questionRepository = questionRepository;
            _passedTestRepository = passedTestRepository;
            _userTestRepository = userTestRepository;
            _mapper = mapper;
        }

        public async Task<TestDTO> GenerateTestAsync(GenerateTestDTO generateTestDTO)
        {
            var grammarQuestions = await _questionRepository.GetGrammarQuestionsAsync(generateTestDTO.LevelType);
            var auditionQuestions = await _questionRepository.GetAuditionQuestionsAsync(generateTestDTO.LevelType);
            var topics = await _questionRepository.GetTopicsAsync();

            var allQuestions = grammarQuestions;
            allQuestions.AddRange(auditionQuestions);
            allQuestions.AddRange(topics);

            var userTest = new UserTest()
            {
                Questions = allQuestions
            };

            await _userTestRepository.CreateAsync(userTest);

            var passedTest = _mapper.Map<PassedTest>(generateTestDTO).Map(userTest);
            await _passedTestRepository.CreateAsync(passedTest);

            return _mapper
                .Map<TestDTO>(passedTest.Id)
                .Map(_mapper.Map<GrammarQuestionDTO[]>(grammarQuestions)
                .Map(_mapper.Map<AuditionQuestionDTO[]>(auditionQuestions)
                .Map(_mapper.Map<TopicQuestionDTO[]>(topics))));
        }

        public async Task<AuditionQuestionDTO> CreateAudioQuestionAsync(AuditionQuestionDTO audioQuestionDTO)
        {
            var question = await _questionRepository.CreateAsync(_mapper.Map<Question>(audioQuestionDTO));
            return _mapper.Map<AuditionQuestionDTO>(question);
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
