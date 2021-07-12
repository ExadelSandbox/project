using ExaLearn.Dal.Model;
using Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Entities
{
    public class Question
    {
        public int Id { get; set; }

        public int AudioId { get; set; }

        public AudioFile Audio { get; set; }

        public QuestionType Type { get; set; } 

        public string Text { get; set; } 

        public string Description { get; set; }

        public int Score { get; set; }

        public LevelType Level { get; set; }

        public List<Answer> Answer { get; set; } = new List<Answer>();
    }
}
