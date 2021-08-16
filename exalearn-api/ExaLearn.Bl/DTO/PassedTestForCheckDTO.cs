namespace ExaLearn.Bl.DTO
{
    public class PassedTestForCheckDTO
    {
        public QuestionDTO[] Questions { get; set; }

        public UserAnswerForCheckDTO[] UserAnswers { get; set; }
    }
}