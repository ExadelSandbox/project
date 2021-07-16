using ExaLearn.Dal.Entities;
using ExaLearn.Shared.Enums;
using Shared.Enums;
using System;

namespace ExaLearn.Bl.DTO
{
    public class TestDTO
    {
        public int Id { get; set; }

        public User User { get; set; }

        public User Assigner { get; set; }

        public User Checker { get; set; }

        public int Assessment { get; set; }

        public LevelType Level { get; set; }

        public DateTime ExpirationDate { get; set; }

        public string Comment { get; set; }

        public StatusType Status { get; set; }

        public DateTime CheckedDate { get; set; }
    }
}
