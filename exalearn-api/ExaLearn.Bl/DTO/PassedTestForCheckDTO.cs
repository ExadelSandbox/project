namespace ExaLearn.Bl.DTO
{
    public class PassedTestForCheckDTO
    {
        public UserTestDTO UserTest { get; set; }

        public UserAnswerQuestionDTO[] UserAnswers { get; set; }
    }
}