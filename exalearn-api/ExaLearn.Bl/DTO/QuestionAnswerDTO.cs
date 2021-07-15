using ExaLearn.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaLearn.Bl.DTO
{
    public class QuestionAnswerDTO
    {
        public int Id { get; set; }

        public Test Test { get; set; }

        public Question Question { get; set; }

        public string Answer { get; set; }

        public int Assessment { get; set; }
    }
}
