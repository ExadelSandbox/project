using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using ExaLearn.Bl.Mapping;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using Shared.Enums;
using System;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly IPassedTestRepository _passedTestRepository;
        private readonly IMapper _mapper;

        public QuestionService(IQuestionRepository questionRepository, IPassedTestRepository passedTestRepository, IMapper mapper)
        {
            _questionRepository = questionRepository;
            _passedTestRepository = passedTestRepository;
            _mapper = mapper;
        }

        public async Task<TestDTO> GenerateTestAsync(LevelType level)
        {
            var grammarQuestions = _mapper.Map<GrammarQuestionDTO[]>(await _questionRepository.GetGrammarQuestionsAsync(level));
            var auditionQuestions = _mapper.Map<AuditionQuestionDTO[]>(await _questionRepository.GetAuditionQuestionsAsync(level));
            var topics = _mapper.Map<TopicQuestionDTO[]>(await _questionRepository.GetTopicsAsync());

            return _mapper.Map<TestDTO>(grammarQuestions)
                .Map(auditionQuestions)
                .Map(topics);
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

        public async Task<TopicQuestionDTO> CreateTopicQuestionAsync(TopicQuestionDTO topicQuestionDTO)
        {
            var question = await _questionRepository.CreateAsync(_mapper.Map<Question>(topicQuestionDTO));
            return _mapper.Map<TopicQuestionDTO>(question);
        }

        public async Task<PassedTestDTO> CreatePassedTestAsync(PassedTestDTO passedTestDTO)
        {
            var passedTest = _mapper.Map<PassedTest>(passedTestDTO);
            passedTest = await _passedTestRepository.CreateAsync(passedTest);
            return _mapper.Map<PassedTestDTO>(passedTest);
        }
    }
}
