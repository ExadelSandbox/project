using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Entities
{
    public class TestAnswer
    {
        public int Id { get; set; }

        public Test Test { get; set; }

        public string AnswerText { get; set; }

        public string AnswerAudio { get; set; }

        public double Mark { get; set; }
    }
}
