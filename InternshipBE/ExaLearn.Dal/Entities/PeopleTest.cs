using Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Entities
{
    public class PeopleTest
    {
        public int Id { get; set; }

        public People PeopleId { get; set; }

        public LevelType LevelId { get; set; }

        public DateTime ExpirationDate { get; set; }

        public string Comment { get; set; }
        
        public StatusType Status { get; set; } 

        public DateTime CheckedDate { get; set; }
    }
}
