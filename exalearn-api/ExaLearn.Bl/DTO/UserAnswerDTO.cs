﻿namespace ExaLearn.Bl.DTO
{
    public class UserAnswerDTO
    {
        public int Id { get; set; }

        public int PassedTestId { get; set; }

        public int QuestionId { get; set; }

        public string Answer { get; set; }

        public string FileUrl { get; set; }

        public int Assessment { get; set; }
    }
}
