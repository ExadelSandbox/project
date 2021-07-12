using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Entities
{
    public class QuestionAnswer
    {
        public int Id { get; set; }

        public int TestId { get; set; }

        public Test Test { get; set; }

        public int QuestionId { get; set; }

        public Question Question { get; set; }

        public string Answer { get; set; }

        public int Assessment { get; set; }
    }
}
