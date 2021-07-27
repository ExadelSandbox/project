using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IHistoryRepository _historyRepository;
        private readonly IAssignTestRepository _assignTestRepository;
        private readonly IMapper _mapper;


        public UserService(IUserRepository userRepository, IHistoryRepository historyRepository,
            IAssignTestRepository assignTestRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _historyRepository = historyRepository;
            _assignTestRepository = assignTestRepository;
            _mapper = mapper;
        }

        public async Task<List<UserDTO>> GetAllAsync()
        {
            var user = await _userRepository.GetAllAsync();
            return _mapper.Map<List<UserDTO>>(user);
        }

        public async Task<UserDTO> GetByIdAsync(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            return _mapper.Map<UserDTO>(user);
        }

        public async Task<UserHistoryDTO[]> GetUserHistoryByIdAsync(int id)
        {
            var history = await _historyRepository.GetUserHistoryByIdAsync(id);
            return _mapper.Map<UserHistoryDTO[]>(history);
        }

        public async Task<HrHistoryDTO[]> GetHrUserHistoryByIdAsync(int id)
        {
            var passedTests = await _historyRepository.GetHRUserHistoryByIdAsync(id);
            return _mapper.Map<HrHistoryDTO[]>(passedTests);
        }

        public async Task<AssignedTestDTO> CreateAssignedTestAsync(AssignedTestDTO assignedTestDTO)
        {
            var assignedTest = await _assignTestRepository.CreateAsync(_mapper.Map<AssignTest>(assignedTestDTO));
            return _mapper.Map<AssignedTestDTO>(assignedTest);
        }

        public async Task<HrAssignedTestDTO[]> GetHrAssignedTestByIdAsync(int id)
        {
            var hrAssignedTest = await _assignTestRepository.GetHRAssignedTestByIdAsync(id);
            return _mapper.Map<HrAssignedTestDTO[]>(hrAssignedTest);
        }

        public async Task<UserAssignedTestDTO[]> GetUserAssignedTestByIdAsync(int id)
        {
            var userAssignedTest = await _assignTestRepository.GetUserAssignedTestByIdAsync(id);
            return _mapper.Map<UserAssignedTestDTO[]>(userAssignedTest);
        }
    }
}
