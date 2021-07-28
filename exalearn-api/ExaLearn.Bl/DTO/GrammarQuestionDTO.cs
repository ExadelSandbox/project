using System.Collections.Generic;
using Shared.Enums;

namespace ExaLearn.Bl.DTO
{
    public class GrammarQuestionDTO
    {
        public int Id { get; set; }

        public LevelType LevelType { get; set; }

        public QuestionType QuestionType { get; set; } = QuestionType.Grammar;

        public string Question { get; set; }

        public List<AnswerDTO> Answers { get; set; }
    }
}
