using Shared.Enums;

namespace ExaLearn.Bl.DTO
{
    public class QuestionForCheckDTO
    {  
        public string FileUrl { get; set; }

        public QuestionType QuestionType { get; set; }

        public string QuestionText { get; set; }

        public AnswerDTO[] Choices { get; set; }
    }
}
