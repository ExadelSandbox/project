using System.Collections.Generic;
using Shared.Enums;

namespace ExaLearn.Bl.DTO
{
    public class GrammarQuestionDTO
    {
        public int Id { get; set; }

        public LevelType Level { get; set; }
        
        public string Question { get; set; }

        public List<AnswerDTO> Answers { get; set; }
    }
}
