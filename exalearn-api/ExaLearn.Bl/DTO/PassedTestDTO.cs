using ExaLearn.Shared.Enums;
using Shared.Enums;
using System;

namespace ExaLearn.Bl.DTO
{
    public class PassedTestDTO
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int? CheckerId { get; set; }

        public int? AssignTestId { get; set; }

        public LevelType LevelType { get; set; }

        public int Assessment { get; set; }

        public StatusType Status { get; set; } = StatusType.Active;

        public DateTime PassedTestDate { get; set; }
    }
}
