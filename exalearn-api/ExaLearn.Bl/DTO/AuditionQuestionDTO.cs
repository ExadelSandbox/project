using System.Collections.Generic;

namespace ExaLearn.Bl.DTO
{
    public class AuditionQuestionDTO
    {
        public string Url { get; set; }

        public string Question { get; set; }

        public List<AnswerDTO> Answers { get; set; }
    }
}
