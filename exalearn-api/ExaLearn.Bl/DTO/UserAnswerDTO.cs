namespace ExaLearn.Bl.DTO
{
    public class UserAnswerDTO
    {
        public int Id { get; set; }

        public int PassedTestId { get; set; }       

        public int QuestionId { get; set; }

        public string UserAnswer { get; set; }

        public string ReportedMessage { get; set; }

        public int Assessment { get; set; }
    }
}
