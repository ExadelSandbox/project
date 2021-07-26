using ExaLearn.Shared.Enums;
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

        public int? CheckerId { get; set; }

        public User Checker { get; set; }

        public int AssignTestId { get; set; }

        public AssignTest AssignTest { get; set; }

        public LevelType LevelType { get; set; }

        public List<UserAnswer> UserAnswers { get; set; } = new List<UserAnswer>();

        public int Assessment { get; set; }

        public string Comment { get; set; }

        public StatusType Status { get; set; } = StatusType.Active;

        public DateTime PassedTestDate { get; set; }
    }
}
