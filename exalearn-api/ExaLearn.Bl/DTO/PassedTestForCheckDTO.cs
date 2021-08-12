namespace ExaLearn.Bl.DTO
{
    public class PassedTestForCheckDTO
    {
        public QuestionDTO[] Questions { get; set; }

        public UserAnswerQuestionDTO[] UserAnswers { get; set; }
    }
}