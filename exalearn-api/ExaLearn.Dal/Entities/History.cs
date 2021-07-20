using System;

namespace ExaLearn.Dal.Entities
{
    public class History
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public int PassedTestId { get; set; }

        public PassedTest PassedTest { get; set; }

        public DateTime CreatedDate { get; set; }

        public string Action { get; set; }
    }
}
