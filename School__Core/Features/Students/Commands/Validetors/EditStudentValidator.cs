using FluentValidation;
using School__Core.Features.Students.Commands.Models;

namespace School__Core.Features.Students.Commands.Validetors
{
    public class EditStudentValidator : AbstractValidator<EditStudentCommand>
    {
        public EditStudentValidator()
        {
            ApplyValidationsRules();
        }
        public void ApplyValidationsRules()
        {

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name must be not Empty")
                .MaximumLength(100).WithMessage("Name has Max length 100");

            RuleFor(x => x.Address)
                .NotEmpty().WithMessage("Address must be not Empty")
                .MaximumLength(100).WithMessage("Address has Max length 100");

            RuleFor(x => x.DpartmentID)
                .NotEmpty().WithMessage("Department ID must be not Empty");

            RuleFor(x => x.Phone)
                .NotEmpty().WithMessage("Phone must be not Empty");
        }
    }
}
