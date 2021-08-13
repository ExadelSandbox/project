namespace ExaLearn.Bl.DTO
{
    public class SecureAnswerDTO //this model is designed for safe data delivery (the user must receive a test with no answers)
    {
        public int Id { get; set; }

        public string Text { get; set; }
    }
}
