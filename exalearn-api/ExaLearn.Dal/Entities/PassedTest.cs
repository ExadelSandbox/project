using ExaLearn.Shared.Enums;
using System;
using System.Collections.Generic;

namespace ExaLearn.Dal.Entities
{
    public class PassedTest
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public int? AssignerId { get; set; }

        public User Assigner { get; set; }

        public int? CheckerId { get; set; }

        public User Checker { get; set; }

        public int EnglishLevelId { get; set; }

        public EnglishLevel EnglishLevel { get; set; }

        public List<UserAnswer> UserAnswers { get; set; } = new List<UserAnswer>();

        public int Assessment { get; set; }

        public string Comment { get; set; }

        public StatusType Status { get; set; } = StatusType.Active;

        public DateTime ExpirationDate { get; set; }

        public DateTime PassedTestDate { get; set; }
    }
}
