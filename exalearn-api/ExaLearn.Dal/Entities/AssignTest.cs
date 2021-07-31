using Shared.Enums;
using System;

namespace ExaLearn.Dal.Entities
{
    public class AssignTest
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; } //i think will be is many (we can assign test on many users). however, roma, your approval is needed

        public int AssignerId { get; set; }

        public User Assigner { get; set; }

        public DateTime ExpirationDate { get; set; }

        public LevelType LevelType { get; set; }
    }
}
