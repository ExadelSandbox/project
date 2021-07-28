using Shared.Enums;
using System.Collections.Generic;

namespace ExaLearn.Bl.DTO
{
    public class QuestionDTO
    {
        public int Id { get; set; }

        public LevelType LevelType { get; set; }

        public AudioFileDTO AudioFile { get; set; }

        public QuestionType QuestionType { get; set; }

        public string Text { get; set; }

        public List<AnswerDTO> Answers { get; set; }
    }
}
