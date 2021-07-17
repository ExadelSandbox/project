﻿using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using System.Collections.Generic;
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

        public async Task<UserAnswerDTO> AddAsync(UserAnswerDTO questionAnswerDTO)
        {
            var questionAnswer = _mapper.Map<UserAnswer>(questionAnswerDTO);
            questionAnswer = await _questionAnswerRepository.AddAsync(questionAnswer);
            return _mapper.Map<UserAnswerDTO>(questionAnswer);
        }

        public async Task<UserAnswerDTO> GetByIdAsync(int id)
        {
            var questionAnswer = await _questionAnswerRepository.GetAsync(id);
            return _mapper.Map<UserAnswerDTO>(questionAnswer);
        }

        public async Task<List<UserAnswerDTO>> GetAllAsync()
        {
            var questionAnswer = await _questionAnswerRepository.GetAllAsync();
            return _mapper.Map<List<UserAnswerDTO>>(questionAnswer);
        }

        public async Task<UserAnswerDTO> RemoveAsync(UserAnswerDTO questionAnswerDTO)
        {
            var questionAnswer = _mapper.Map<UserAnswer>(questionAnswerDTO);
            questionAnswer = await _questionAnswerRepository.Remove(questionAnswer);
            return _mapper.Map<UserAnswerDTO>(questionAnswer);
        }

        public async Task<UserAnswerDTO> UpdateAsync(UserAnswerDTO questionAnswerDTO)
        {
            var questionAnswer = _mapper.Map<UserAnswer>(questionAnswerDTO);
            questionAnswer = await _questionAnswerRepository.Update(questionAnswer);
            return _mapper.Map<UserAnswerDTO>(questionAnswer);
        }
    }
}
