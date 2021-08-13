namespace ExaLearn.Bl.DTO
{
    public class UserAnswerForCheckDTO
    {
        public int Id { get; set; }

        public string UserAnswer { get; set; }

        public int Assessment { get; set; }

        public QuestionDTO Question { get; set; }

    }
}
