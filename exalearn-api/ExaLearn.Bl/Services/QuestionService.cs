using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using Shared.Enums;
using System.Collections.Generic;
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

        public async Task<QuestionDTO> AddAsync(QuestionDTO question)
        {
            var _question = await _questionRepository.AddAsync(_mapper.Map<Question>(question));
            return _mapper.Map<QuestionDTO>(_question);
        }

        public async Task<List<QuestionDTO>> GetAllAsync()
        {
            return (List<QuestionDTO>)(IEnumerable<QuestionDTO>)_mapper.Map<QuestionDTO>(await _questionRepository.GetAllAsync());
        }

        public async Task<QuestionDTO> GetAsync(int id)
        {
            var _question = await _questionRepository.GetAsync(id);
            return _mapper.Map<QuestionDTO>(_question);
        }

        public async Task<List<QuestionDTO>> GetByLevelAndTypeAsync(LevelType level, QuestionType type)
        {
            var questions = await _questionRepository.GetByLevelAndTypeAsync(level, type);
            return (List<QuestionDTO>)(IEnumerable<QuestionDTO>)_mapper.Map<QuestionDTO>(questions);
        }

        public async Task<List<QuestionDTO>> GetByTypeAsync(QuestionType type)
        {
            var questions = await _questionRepository.GetByTypeAsync(type);
            return (List<QuestionDTO>)(IEnumerable<QuestionDTO>)_mapper.Map<QuestionDTO>(questions);
        }

        public async Task<List<QuestionDTO>> GetByLevelAsync(LevelType level)
        {
            var questions = await _questionRepository.GetByLevelAsync(level);
            return (List<QuestionDTO>)(IEnumerable<QuestionDTO>)_mapper.Map<QuestionDTO>(questions);
        }

        public async Task<QuestionDTO> SaveAsync(QuestionDTO question)
        {
            var q = await _questionRepository.AddAsync(_mapper.Map<Question>(question));
            return _mapper.Map<QuestionDTO>(q);
        }

        public async Task<QuestionDTO> UpdateAsync(QuestionDTO question)
        {
            var q = await _questionRepository.Update(_mapper.Map<Question>(question));
            return _mapper.Map<QuestionDTO>(q);
        }
    }
}
