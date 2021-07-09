using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Entities
{
    public class History
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public string Action { get; set; }

        public PeopleTest Test { get; set; }
    }
}
