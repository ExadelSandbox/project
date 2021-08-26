using Shared.Enums;
using System.Collections.Generic;

namespace ExaLearn.Bl.DTO
{
    public class AuditionQuestionDTO
    {
        public int Id { get; set; }

        public LevelType LevelType { get; set; }

        public QuestionType QuestionType { get; set; } = QuestionType.Audition;

        public string Url { get; set; }

        public string Question { get; set; }

        public List<AnswerDTO> Answers { get; set; }
    }
}
