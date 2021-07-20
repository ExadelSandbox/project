using Shared.Enums;

namespace ExaLearn.Bl.DTO
{
    public class QuestionDTO
    {
        public int Id { get; set; }        

        public QuestionType Type { get; set; }

        public string Text { get; set; }

        public string Description { get; set; }

        public int Score { get; set; }
    }
}
