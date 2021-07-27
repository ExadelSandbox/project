﻿using ExaLearn.Bl.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Interfaces
{
    public interface IUserService
    {
        Task<List<UserDTO>> GetAllAsync();

        Task<UserDTO> GetByIdAsync(int id);

        Task<UserHistoryDTO[]> GetUserHistoryByIdAsync(int id);

        Task<HrHistoryDTO[]> GetHrUserHistoryByIdAsync(int id);

        Task<AssignedTestDTO> CreateAssignedTestAsync(AssignedTestDTO assignedTestDTO);

        Task<HrAssignedTestDTO[]> GetHrAssignedTestByIdAsync(int id);

        Task<UserAssignedTestDTO[]> GetUserAssignedTestByIdAsync(int id);
    }
}
