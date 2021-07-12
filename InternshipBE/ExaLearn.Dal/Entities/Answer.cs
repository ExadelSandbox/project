﻿using ExaLearn.Dal.Model;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Entities
{
    public class Answer
    {
        public int Id { get; set; }

        public int QuestionId { get; set; }

        public Question Question { get; set; }

        public string Text { get; set; }

        public bool IsCorrect { get; set; }
    }
}
