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

        public int? AssignTestId { get; set; }

        public AssignTest AssignTest { get; set; }

        public int? UserTestId { get; set; }

        public UserTest UserTest { get; set; }

        public LevelType LevelType { get; set; }

        public int? AssessmentId { get; set; }

        public Assessment Assessment { get; set; }

        public List<UserAnswer> UserAnswers { get; set; } = new List<UserAnswer>();

        public StatusType Status { get; set; } = StatusType.Active;

        public DateTime PassedTestDate { get; set; }
    }
}
