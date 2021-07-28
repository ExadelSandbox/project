using Microsoft.AspNetCore.Identity;
using Portal.Core.Constants;
using Shared.Enums;
using System.Collections.Generic;

namespace ExaLearn.Dal.Entities
{
    public class User : IdentityUser<int>
    {
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public bool IsActive { get; set; }

        public const RoleNames RoleName;

        public LevelType? LevelType { get; set; }

        public List<History> History { get; set; } = new List<History>();
    }
}
