﻿using ExaLearn.Bl.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Interfaces
{
    public interface IUserService
    {
        Task<List<UserDTO>> GetAllAsync();

        Task<UserDTO> GetUserInfo();

        Task<UserHistoryDTO[]> GetUserHistoryByIdAsync(int id);

        Task<HrHistoryDTO[]> GetHrUserHistoryByIdAsync(int id);
    }
}
