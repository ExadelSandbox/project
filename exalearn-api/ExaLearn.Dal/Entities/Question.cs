using Shared.Enums;
using System.Collections.Generic;

namespace ExaLearn.Dal.Entities
{
    public class Question
    {
        public int Id { get; set; }

        public LevelType LevelType { get; set; }

        public string FileUrl { get; set; }

        public QuestionType QuestionType { get; set; }

        public string Text { get; set; }

        public List<Answer> Answers { get; set; } = new List<Answer>();

        public List<UserTest> UserTest { get; set; } = new List<UserTest>();

        public bool? Archived { get; set; }
    }
}
