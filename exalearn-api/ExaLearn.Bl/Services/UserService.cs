using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using ExaLearn.Bl.Mapping;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IAssignTestRepository _assignTestRepository;
        private readonly IMapper _mapper;
        private readonly IPassedTestRepository _passedTestRepository;

        public UserService(IUserRepository userRepository, IAssignTestRepository assignTestRepository, IMapper mapper, IPassedTestRepository passedTestRepository)
        {
            _userRepository = userRepository;
            _assignTestRepository = assignTestRepository;
            _mapper = mapper;
            _passedTestRepository = passedTestRepository;
        }

        public async Task<List<UserDTO>> GetAllAsync()
        {
            var user = await _userRepository.GetAllAsync();
            return _mapper.Map<List<UserDTO>>(user);
        }

        public async Task<UserDTO> GetUserInfoByIdAsync(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            var role = await _userRepository.GetUserRole(id);

            return _mapper.Map<UserDTO>(user)
                .Map(role);
        }

        public async Task<HrAssignedTestDTO[]> GetHrAssignedTestByIdAsync(int id)
        {
            var assignedTest = await _assignTestRepository.GetHrAssignedTestByIdAsync(id);
            return _mapper.Map<HrAssignedTestDTO[]>(assignedTest);
        }

        public async Task<UserAssignedTestDTO[]> GetUserAssignedTestByIdAsync(int id)
        {
            var assignedTest = await _assignTestRepository.GetUserAssignedTestByIdAsync(id);
            return _mapper.Map<UserAssignedTestDTO[]>(assignedTest);
        }

        public async Task<AssignedTestDTO> CreateAssignedTestAsync(AssignedTestDTO assignedTestDTO)
        {
            var assignedTest = _mapper.Map<AssignTest>(assignedTestDTO);
            assignedTest = await _assignTestRepository.CreateAsync(assignedTest);
            return _mapper.Map<AssignedTestDTO>(assignedTest);
        }

        public async Task<HrAssignedTestDTO[]> GetHrExpiredAssignedTestByIdAsync(int id)
        {
            var assignedTest = await _assignTestRepository.GetHrExpiredAssignedTestByIdAsync(id);
            return _mapper.Map<HrAssignedTestDTO[]>(assignedTest);
        }

        public async Task<List<AllPassedTestDTO>> AllTestHistoryAsync()
        {
            var allPassedTests = await _passedTestRepository.AllTestHistoryAsync();

            return _mapper.Map<List<AllPassedTestDTO>>(allPassedTests);
        }

        public async Task<List<PassedTestDTO>> MyTestHistoryAsync(int id)
        {
            var passedTests = await _passedTestRepository.MyTestHistoryAsync(id);

            return _mapper.Map<List<PassedTestDTO>>(passedTests);
        }
    }
}
