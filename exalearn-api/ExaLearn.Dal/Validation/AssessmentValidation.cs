using ExaLearn.Dal.Entities;
using FluentValidation;

namespace ExaLearn.Dal.Validation
{
    public class AssessmentValidation : AbstractValidator<Assessment>
    {
        public AssessmentValidation()
        {
            RuleFor(assessment => assessment.Grammar).NotNull();
            RuleFor(answer => answer.Audition).NotNull();
            RuleFor(answer => answer.Essay);
            RuleFor(answer => answer.Speaking);
            RuleFor(answer => answer.General);
        }
    }
}
