using Shared.Enums;
using System;

namespace ExaLearn.Bl.DTO
{
    public class HrAssignedTestDTO
    {
        public int Id { get; set; }

        public LevelType Level { get; set; }

        public DateTime ExpireDate { get; set; }

        public string AssignedBy { get; set; }

        public bool Passed { get; set; }
    }
}
