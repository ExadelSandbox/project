using ExaLearn.Dal.Entities;
using FluentValidation;

namespace ExaLearn.Dal.Validation
{
    public class AssignTestValidation : AbstractValidator<AssignTest>
    {
        public AssignTestValidation()
        {
            RuleFor(assignTest => assignTest.Id).NotNull().NotEqual(0);
            RuleFor(assignTest => assignTest.UserId).NotNull().NotEqual(0);
            RuleFor(assignTest => assignTest.AssignerId).NotNull().NotEqual(0);
            RuleFor(assignTest => assignTest.ExpirationDate).NotNull();
            RuleFor(assignTest => assignTest.IsExpired).NotNull();
            RuleFor(assignTest => assignTest.LevelType).NotNull();
        }
    }
}
