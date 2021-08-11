using System.Collections.Generic;

namespace ExaLearn.Dal.Entities
{
    public class UserTest
    {
        public int Id { get; set; }

        public List<Question> Questions { get; set; } = new List<Question>();
    }
}
