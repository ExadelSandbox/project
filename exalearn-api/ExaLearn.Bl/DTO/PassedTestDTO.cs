using ExaLearn.Shared.Enums;
using Shared.Enums;
using System;

namespace ExaLearn.Bl.DTO
{
    public class PassedTestDTO
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public LevelType LevelType { get; set; }

        public DateTime PassedTestDate { get; set; }

        public int Assessment { get; set; }

        public StatusType Status { get; set; }
    }
}
