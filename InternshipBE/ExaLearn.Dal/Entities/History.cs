using System;

namespace ExaLearn.Dal.Entities
{
    public class History
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public Person PersonId { get; set; }

        public string Action { get; set; }

        public Test Test { get; set; }
    }
}
