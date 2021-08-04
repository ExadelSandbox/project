﻿using ExaLearn.Bl.DTO;
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

        Task<HrAssignedTestDTO[]> GetHrAssignedTestByIdAsync(int id);

        Task<UserAssignedTestDTO[]> GetUserAssignedTestByIdAsync(int id);

        Task<AssignedTestDTO> CreateAssignedTestAsync(AssignedTestDTO assignedTestDTO);
    }
}
