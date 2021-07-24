using Shared.Enums;
using System;

namespace ExaLearn.Bl.DTO
{
    public class UserHistoryDTO
    {
        public LevelType Level { get; set; }

        public DateTime Date { get; set; }

        public int Mark { get; set; }
    }
}
