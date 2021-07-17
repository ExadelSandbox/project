using ExaLearn.Dal.Model;
using Shared.Enums;
using System.Collections.Generic;

namespace ExaLearn.Bl.DTO
{
    public class QuestionDTO
    {
        public int Id { get; set; }        

        public AudioFileDTO AudioFile { get; set; }

        public QuestionType Type { get; set; }

        public string Text { get; set; }

        public string Description { get; set; }

        public int Score { get; set; }

        public LevelType Level { get; set; }

        public List<AnswerDTO> Answer { get; set; } = new List<AnswerDTO>();
    }
}
