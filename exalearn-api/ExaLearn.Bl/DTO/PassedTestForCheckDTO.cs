namespace ExaLearn.Bl.DTO
{
    public class PassedTestForCheckDTO
    {
        public int Id { get; set; }

        public int GeneralAssessment { get; set; }       

        public UserAnswerForCheckDTO[] UserAnswers { get; set; }
    }
}