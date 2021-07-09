using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Entities
{
    public class Answer
    {
        public int Id { get; set; }

        public AnswerOption AnswerType { get; set; }

        public bool IsCorrectAnswer { get; set; }
    }
}
