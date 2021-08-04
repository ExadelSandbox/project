using ExaLearn.Dal.Entities;
using FluentValidation;
using FluentValidation.Results;

namespace ExaLearn.Dal.Validation
{
    public class AnswerValidator : AbstractValidator<Answer>
    {
        public AnswerValidator()
        {
            RuleFor(answer => answer.QuestionId).NotNull();
            RuleFor(answer => answer.Question).NotNull();
            RuleFor(answer => answer.Text).NotNull().MaximumLength(255);
            RuleFor(answer => answer.IsCorrect).NotNull();
        }
    }
}
