using ExaLearn.Dal.Model;
using Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Entities
{
    public class Question
    {
        public int Id { get; set; }

        public QuestionType Type { get; set; } 

        public string Text { get; set; } 

        public FileEntry? Audio { get; set; } 

        public double Score { get; set; }

        public LevelType Level { get; set; }

        public List<Answer>? Answer { get; set; } 

        //public Answer PeopleAnswer { get; set; }
    }
}
