﻿namespace ExaLearn.Bl.DTO
{
    public class UserAnswerQuestionDTO
    {
        public int Id { get; set; }

        public string UserAnswer { get; set; }

        public int Assessment { get; set; }

        public int? ReportId { get; set; }
    }
}
