using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using ExaLearn.Dal.Interfaces;
using Shared.Enums;
using System;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly IMapper _mapper;

        public QuestionService(IQuestionRepository questionRepository, IMapper mapper)
        {
            _questionRepository = questionRepository;
            _mapper = mapper;
        }

        public async Task<TestDTO> GenerateTestAsync(LevelType level)
        {
            var grammarQuestions = await _questionRepository.GetGrammarQuestionAsync(level);
            var auditionQuestions = await _questionRepository.GetAuditionQuestionAsync(level);
            var essayTopic = await _questionRepository.GetEssayTopicAsync(level);
            var speakingTopic = await _questionRepository.GetSpeakingTopicAsync(level);

            var test = _mapper.Map<TestDTO>(grammarQuestions);
            test = _mapper.Map(auditionQuestions, test);
            test = _mapper.Map(essayTopic, test);
            test = _mapper.Map(speakingTopic, test);

            return _mapper.Map<TestDTO>(test);
        }
    }
}
