using ExaLearn.Dal.Model;
using Shared.Enums;
using System.Collections.Generic;

namespace ExaLearn.Dal.Entities
{
    public class Question
    {
        public int Id { get; set; }

        public LevelType LevelType { get; set; }

        public int? AudioId { get; set; }

        public AudioFile AudioFile { get; set; }

        public QuestionType Type { get; set; }

        public string Text { get; set; }

        public List<Answer> Answers { get; set; } = new List<Answer>();
    }
}
