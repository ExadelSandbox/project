﻿namespace ExaLearn.Bl.DTO
{
    public class UserAnswerForCheckDTO
    {
        public int Id { get; set; }

        public string UserAnswer { get; set; }

        public int QuestionId { get; set; }

        public int Assessment { get; set; }
    }
}