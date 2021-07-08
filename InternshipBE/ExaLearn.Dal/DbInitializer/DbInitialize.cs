using ExaLearn.Dal.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaLearn.Dal.DbInitializer
{
    public class DbInitialize 
    {
        public static void Initialize(ExaLearnDbContext exaLearnDbContext)
        {
            exaLearnDbContext.Database.EnsureCreated(); // its create db before deploy our project on the server
        }
    }
}
