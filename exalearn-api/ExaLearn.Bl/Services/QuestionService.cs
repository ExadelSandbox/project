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
        private readonly IMapper _mapper;

        public QuestionService(IQuestionRepository questionRepository, IMapper mapper)
        {
            _questionRepository = questionRepository;
            _mapper = mapper;
        }

        public async Task<TestDTO> GenerateTestAsync(LevelType level)
        {
            var essayTopic = await _questionRepository.GetEssayTopicAsync(level);
            if (essayTopic is null)
            {
                throw new ArgumentException($"{nameof(essayTopic)} cannot be equals null.");
            }

            var speakingTopic = await _questionRepository.GetSpeakingTopicAsync(level);
            if (speakingTopic is null)
            {
                throw new ArgumentException($"{nameof(speakingTopic)} cannot be equals null.");
            }

            var grammarQuestions = await _questionRepository.GetGrammarQuestionAsync(level);
            if (grammarQuestions is null)
            {
                throw new ArgumentException($"{nameof(grammarQuestions)} cannot be equals null.");
            }

            var auditionQuestions = await _questionRepository.GetAuditionQuestionAsync(level);
            if (auditionQuestions is null)
            {
                throw new ArgumentException($"{nameof(auditionQuestions)} cannot be equals null.");
            }

            return _mapper.Map<TestDTO>(grammarQuestions)
                .Map(auditionQuestions)
                .Map(essayTopic)
                .Map(speakingTopic);
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
    }
}
