using ExaLearn.Dal.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Validation
{
    public class PassedTestValidation : AbstractValidator<PassedTest>
    {
        public PassedTestValidation()
        {

        }
    }
}
