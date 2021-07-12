using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Entities
{
    public class PeopleAnswer
    {
        public int Id { get; set; }

        public PeopleTest PeopleTest { get; set; }

        public string Text { get; set; }

        public string AnswerAudio { get; set; }

        public int Mark { get; set; }
    }
}
