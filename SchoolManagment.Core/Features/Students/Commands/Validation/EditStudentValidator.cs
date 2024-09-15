using FluentValidation;
using SchoolManagment.Core.Features.Students.Commands.Models;
using SchoolManagment.Services.Abstracts;

namespace SchoolProject.Core.Features.Students.Commands.Validation
{
    public class EditStudentValidator : AbstractValidator<EditStudentCommand>
    {
        private readonly IStudentServices _studentServices;
        public EditStudentValidator(IStudentServices studentServices)
        {
            ApplyValidationRules();
            ApplyCustomValidationRules();
            _studentServices = studentServices;

        }

        public void ApplyValidationRules()
        {

            RuleFor(x => x.Name).NotEmpty().WithMessage("{PropertyName} is Not Empty")
                .NotNull().WithMessage("{ProperyName} is Not Null")
                .MaximumLength(10).WithMessage("Name Is Max 10");

            RuleFor(x => x.Address).NotEmpty().WithMessage("{PropertyName} is Not Empty")
                .NotNull().WithMessage("{ProperyName} is Not Null")
                .MaximumLength(10).WithMessage("{ProperyName} Is Max 10");
            RuleFor(x => x.Phone)
    .Matches(@"^(?:010|011|012)[0-9]{8}$")
    .WithMessage("Phone number must start with 010, 011, or 012 and be followed by 8 digits.");

        }

        public async void ApplyCustomValidationRules()
        {
            RuleFor(x => x.Name).MustAsync(async (model, Key, CancellationToken) => !await _studentServices.IsNameExistIncludeSelf(Key, model.Id)).WithMessage("Already Name Is Exist");
        }

    }
}
