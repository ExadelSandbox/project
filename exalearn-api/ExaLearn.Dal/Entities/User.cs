using Microsoft.AspNetCore.Identity;
using Shared.Enums;
using System.Collections.Generic;

namespace ExaLearn.Dal.Entities
{
    public class User : IdentityUser<int>
    {
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public bool IsActive { get; set; }

        public LevelType? LevelType { get; set; }

        public List<History> History { get; set; } = new List<History>();
    }
}
