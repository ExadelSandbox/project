using Shared.Enums;
using System;

namespace ExaLearn.Bl.DTO
{
    public class AllPassedTestDTO
    {
        public string FullName { get; set; }

        public LevelType LevelType { get; set; }

        public DateTime PassedTestDate { get; set; }

        public int Assessment { get; set; }
    }
}
