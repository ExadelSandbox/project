using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Services
{
    public class UserAnswerService : IUserAnswerService
    {
        private readonly IUserAnswerRepository _userAnswerRepository;
        private readonly IMapper _mapper;

        public UserAnswerService(IUserAnswerRepository userAnswerRepository, IMapper mapper)
        {
            _userAnswerRepository = userAnswerRepository;
            _mapper = mapper;
        }

        public async Task<List<UserAnswerDTO>> CreateUserAnswersAsync(List<UserAnswerDTO> userAnswersDTO)
        {
            var userAnswer =  await _userAnswerRepository.AddRangeAsync(_mapper.Map<List<UserAnswer>>(userAnswersDTO));
            return _mapper.Map<List<UserAnswerDTO>>(userAnswer);
        }
    }
}
