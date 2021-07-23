using Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaLearn.Bl.DTO
{
    public class GrammarQuestionDTO
    {
        public string Question { get; set; }

        public List<AnswerDTO> Answers { get; set; }
    }
}
