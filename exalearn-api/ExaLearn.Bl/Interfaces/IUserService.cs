﻿using ExaLearn.Bl.DTO;
using ExaLearn.Dal.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Interfaces
{
    public interface IUserService
    {
        Task<List<UserDTO>> GetAllAsync();

        Task<UserDTO> GetUserInfoByIdAsync(int id);

        Task<UserHistoryDTO[]> GetUserHistoryByIdAsync(int id);

        Task<HrHistoryDTO[]> GetHrUserHistoryByIdAsync(int id);
    }
}
