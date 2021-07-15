using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Services
{
    public class QuestionAnswerService : IQuestionAnswerService
    {
        private readonly IQuestionAnswerRepository _questionAnswerRepository;
        private readonly IMapper _mapper;

        public QuestionAnswerService(IQuestionAnswerRepository questionAnswerRepository, IMapper mapper)
        {
            _questionAnswerRepository = questionAnswerRepository;
            _mapper = mapper;
        }

        public async Task<QuestionAnswerDTO> AddAsync(QuestionAnswerDTO questionAnswerDTO)
        {
            var questionAnswer = _mapper.Map<QuestionAnswer>(questionAnswerDTO);
            questionAnswer = await _questionAnswerRepository.AddAsync(questionAnswer);
            return _mapper.Map<QuestionAnswerDTO>(questionAnswer);
        }

        public async Task<QuestionAnswerDTO> GetAsync(int id)
        {
            var questionAnswer = await _questionAnswerRepository.GetAsync(id);
            return _mapper.Map<QuestionAnswerDTO>(questionAnswer);
        }

        public async Task<List<QuestionAnswerDTO>> GetAllAsync()
        {
            var questionAnswer = await _questionAnswerRepository.GetAllAsync();
            return _mapper.Map<List<QuestionAnswerDTO>>(questionAnswer);
        }

        public async Task<QuestionAnswerDTO> RemoveAsync(QuestionAnswerDTO questionAnswerDTO)
        {
            var questionAnswer = _mapper.Map<QuestionAnswer>(questionAnswerDTO);
            questionAnswer = await _questionAnswerRepository.Remove(questionAnswer);
            return _mapper.Map<QuestionAnswerDTO>(questionAnswer);
        }

        public async Task<QuestionAnswerDTO> UpdateAsync(QuestionAnswerDTO questionAnswerDTO)
        {
            var questionAnswer = _mapper.Map<QuestionAnswer>(questionAnswerDTO);
            questionAnswer = await _questionAnswerRepository.Update(questionAnswer);
            return _mapper.Map<QuestionAnswerDTO>(questionAnswer);
        }
    }
}
