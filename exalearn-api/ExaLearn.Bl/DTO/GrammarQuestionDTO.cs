using Shared.Enums;
using System.Collections.Generic;

namespace ExaLearn.Bl.DTO
{
    public class GrammarQuestionDTO
    {   
        public LevelType Level { get; set; }

        public string Question { get; set; }

        public List<AnswerDTO> AnswersId { get; set; }
    }
}
