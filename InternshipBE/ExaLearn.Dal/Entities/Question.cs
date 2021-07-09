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

        public QuestionType Type { get; set; } //its can be null

        public string Text { get; set; }  //its can be null

        public FileEntry Audio { get; set; }  //its can be null | its need?

        public int Score { get; set; }

        public LevelType Level { get; set; }

        public Answer Answer { get; set; }

        public PeopleAnswer PeopleAnswer { get; set; }

    }
}
