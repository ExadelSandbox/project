using System;

namespace ExaLearn.Dal.Entities
{
    public class History
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public int TestId { get; set; }

        public PassedTest Test { get; set; }

        public DateTime CreatedDate { get; set; }

        public string Action { get; set; }
    }
}
