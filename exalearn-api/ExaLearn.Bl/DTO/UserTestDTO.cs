using ExaLearn.Dal.Entities;
using System.Collections.Generic;

namespace ExaLearn.Bl.DTO
{
    public class UserTestDTO
    {
        public int Id { get; set; }

        public List<Question> Questions { get; set; }
    }
}
