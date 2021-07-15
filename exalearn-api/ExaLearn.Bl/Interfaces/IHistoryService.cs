﻿using ExaLearn.Bl.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Interfaces
{
    public interface IHistoryService
    {
        public Task<HistoryDTO> AddAsync(HistoryDTO userDTO);

        public Task<HistoryDTO> GetAsync(int id);

        public Task<List<HistoryDTO>> GetAllAsync();
    }
}
