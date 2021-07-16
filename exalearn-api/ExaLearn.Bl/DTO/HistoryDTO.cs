using ExaLearn.Dal.Entities;
using System;

namespace ExaLearn.Bl.DTO
{
    public class HistoryDTO
    {
        public int Id { get; set; }

        public UserDTO User { get; set; }

        public TestDTO Test { get; set; }

        public DateTime CreatedDate { get; set; }

        public string Action { get; set; }
    }
}
