namespace ExaLearn.Bl.DTO
{
    public class PassedTestForCheckDTO
    {
        public int Id { get; set; }

        public UserTestDTO UserTest { get; set; }

        public UserAnswerDTO[] UserAnswers { get; set; }
    }
}