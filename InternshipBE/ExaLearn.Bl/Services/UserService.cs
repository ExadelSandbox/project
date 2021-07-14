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
    public class UserService : IUserService
    {
        private readonly IUserRepository _genericRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public async Task<List<UserDTO>> GetAllAsync()
        {
            var user = await _genericRepository.GetAllAsync();
            return _mapper.Map<List<UserDTO>>(user);
        }

        public async Task<UserDTO> GetAsync(int id)
        {
            var user = await _genericRepository.GetAsync(id);
            return _mapper.Map<UserDTO>(user);
        }
    }
}
