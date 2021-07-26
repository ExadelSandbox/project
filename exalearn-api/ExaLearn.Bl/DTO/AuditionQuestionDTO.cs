using Shared.Enums;
using System.Collections.Generic;

namespace ExaLearn.Bl.DTO
{
    public class AuditionQuestionDTO
    {
        public int Id { get; set; }

        public LevelType Level { get; set; }

        public string Url { get; set; }

        public string Question { get; set; }

        public List<AnswerDTO> Answers { get; set; }
    }
}
