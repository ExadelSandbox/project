using Shared.Enums;
using System.Collections.Generic;
using System.Security.Policy;

namespace ExaLearn.Bl.DTO
{
    public class AudioQuestionDTO
    {
        public LevelType Level { get; set; }

        public string FileUrl { get; set; }

        public string Question { get; set; }

        public List<AnswerDTO> Answers { get; set; }
    }
}
