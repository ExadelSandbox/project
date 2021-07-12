using Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Entities
{
    public class User
    {
        public int Id { get; set; }

        public RoleType Role { get; set; }

        public PersonStatusType Status { get; set; }

        public List<History> UserHistory { get; set; }

    }
}
