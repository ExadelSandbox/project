﻿using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using ExaLearn.Shared.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Services
{
    public class UserAnswerService : IUserAnswerService
    {
        private readonly IUserAnswerRepository _userAnswerRepository;
        private readonly IPassedTestRepository _passedTestRepository;
        private readonly IMapper _mapper;

        public UserAnswerService(IUserAnswerRepository userAnswerRepository, IPassedTestRepository passedTestRepository,
            IMapper mapper)
        {
            _passedTestRepository = passedTestRepository;
            _userAnswerRepository = userAnswerRepository;            
            _mapper = mapper;
        }       

        public async Task<List<UserAnswerDTO>> CreateUserAnswersAsync(List<UserAnswerDTO> userAnswersDTO)
        {
            var userAnswers = await _userAnswerRepository.AddRangeAsync(_mapper.Map<List<UserAnswer>>(userAnswersDTO));
            var passedTestId = userAnswers.Select(u => u.PassedTestId).FirstOrDefault();

            var correctQuestionAnswers = await _userAnswerRepository.GetCorrectQuestionsAnswers(passedTestId);

            foreach (var ua in userAnswers) // its will be linq query 
            {
                foreach (var qa in correctQuestionAnswers)
                {
                    if (ua.Answer == qa.Text)
                    {
                        ua.Assessment++; 
                    }
                }
            }

            await _userAnswerRepository.SaveChangesAsync();

            var passedTest = await _passedTestRepository.GetByIdAsync(passedTestId);
            passedTest.Status = StatusType.Completed;
            await _passedTestRepository.UpdateAsync(passedTest);

            return _mapper.Map<List<UserAnswerDTO>>(userAnswers);
        }
    }
}
