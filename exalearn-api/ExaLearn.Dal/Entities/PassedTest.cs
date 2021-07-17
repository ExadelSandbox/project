﻿using ExaLearn.Shared.Enums;
using Shared.Enums;
using System;
using System.Collections.Generic;

namespace ExaLearn.Dal.Entities
{
    public class PassedTest
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public int AssignerId { get; set; }

        public User Assigner { get; set; }

        public int CheckerId { get; set; }

        public User Checker { get; set; }

        public List<UserAnswer> UserAnswers { get; set; } = new List<UserAnswer>();

        public int Assessment { get; set; }

        public LevelType Level { get; set; }

        public DateTime ExpirationDate { get; set; }

        public string Comment { get; set; }

        public StatusType Status { get; set; } 

        public DateTime CheckedDate { get; set; }
    }
}
