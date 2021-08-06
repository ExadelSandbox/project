using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using ExaLearn.Bl.Mapping;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using Shared.Enums;
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
            var grammarQuestions = _mapper.Map<GrammarQuestionDTO[]>(await _questionRepository.GetGrammarQuestionsAsync(generateTestDTO.LevelType));
            var auditionQuestions = _mapper.Map<AuditionQuestionDTO[]>(await _questionRepository.GetAuditionQuestionsAsync(generateTestDTO.LevelType));
            var topics = _mapper.Map<TopicQuestionDTO[]>(await _questionRepository.GetTopicsAsync());

            var userTest = await _userTestRepository.CreateAsync( 
                _mapper.Map<UserTest>(grammarQuestions).Map(auditionQuestions).Map(topics));

            var passedTest = _mapper.Map<PassedTest>(generateTestDTO);
            await _passedTestRepository.CreateAsync(passedTest);

            return _mapper.Map<TestDTO>(userTest);
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
            var question = await _questionRepository.AddRange(_mapper.Map<Question[]>(topicQuestionDTO));
            return _mapper.Map<TopicQuestionDTO[]>(question);
        }
    }
}
