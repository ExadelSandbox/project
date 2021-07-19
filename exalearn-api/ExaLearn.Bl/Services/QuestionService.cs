using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
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

        public async Task<QuestionDTO> CreateAsync(QuestionDTO question)
        {
            var _question = await _questionRepository.CreateAsync(_mapper.Map<Question>(question));
            return _mapper.Map<QuestionDTO>(_question);
        }

        public async Task<List<QuestionDTO>> GetAllAsync()
        {
            return _mapper.Map<List<QuestionDTO>>(await _questionRepository.GetAllAsync());
        }

        public async Task<QuestionDTO> GetByIdAsync(int id)
        {
            var _question = await _questionRepository.GetByIdAsync(id);
            return _mapper.Map<QuestionDTO>(_question);
        }

        public async Task<List<QuestionDTO>> GetByLevelAndTypeAsync(LevelType level, QuestionType type)
        {
            var questions = await _questionRepository.GetByExpressionAsync(x => x.LevelType == level && x.Type == type);
            return _mapper.Map<List<QuestionDTO>>(questions);
        }

        public async Task<QuestionDTO> UpdateAsync(QuestionDTO question)
        {
            var _question = await _questionRepository.UpdateAsync(_mapper.Map<Question>(question));
            return _mapper.Map<QuestionDTO>(_question);
        }
    }
}
