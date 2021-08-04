using Shared.Enums;
using System;

namespace ExaLearn.Bl.DTO
{
    public class AssignedTestDTO
    {
        public int Id { get; set; }

        public LevelType Level { get; set; }

        public DateTime ExpireDate { get; set; }

        public int HrId { get; set; }

        public int UserId { get; set; }
    }
}
