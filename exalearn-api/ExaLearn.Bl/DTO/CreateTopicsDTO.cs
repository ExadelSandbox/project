using Shared.Enums;

namespace ExaLearn.Bl.DTO
{
    public class CreateTopicsDTO
    {
        public string[] Topics { get; set; }

        public QuestionType QuestionType { get; set; } = QuestionType.Topic;
    }
}
