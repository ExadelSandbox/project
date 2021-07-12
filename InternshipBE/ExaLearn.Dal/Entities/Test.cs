﻿using ExaLearn.Shared.Enums;
using Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Entities
{
    public class Test
    {
        public int Id { get; set; }

        public User PersonId { get; set; }

        public LevelType Level { get; set; }

        public DateTime ExpirationDate { get; set; }

        public User Assigner { get; set; }

        public string Comment { get; set; }
        
        public User Checker { get; set; }

        public TestStatusType Status { get; set; } 

        public DateTime CheckedDate { get; set; }
    }
}
