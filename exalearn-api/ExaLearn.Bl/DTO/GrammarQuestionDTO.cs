using System.Collections.Generic;

namespace ExaLearn.Bl.DTO
{
    public class GrammarQuestionDTO
    {
        public int Id { get; set; }

        public string Question { get; set; }

        public List<AnswerDTO> Answers { get; set; }
    }
}
