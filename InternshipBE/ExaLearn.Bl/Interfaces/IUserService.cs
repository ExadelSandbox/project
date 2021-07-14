﻿using ExaLearn.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Interfaces
{
    public interface IUserService
    {
        public Task<List<User>> GetAllAsync();

        public Task<User> GetAsync(int id);
    }
}
