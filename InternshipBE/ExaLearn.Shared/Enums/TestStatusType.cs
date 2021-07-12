using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaLearn.Shared.Enums
{
    public enum TestStatusType
    {
        Unscheduled, //test isnt start 
        Active, 
        Completed,
        Finished,
        InProcess,
        Checked
    }
}
