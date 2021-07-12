using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ExaLearn.Dal.Entities
{
    public class ApplicationUser : IdentityUser<int>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
