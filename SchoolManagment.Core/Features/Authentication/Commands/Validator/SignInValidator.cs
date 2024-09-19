using FluentValidation;
using SchoolManagment.Core.Features.Authentication.Commands.Models;

namespace SchoolManagment.Core.Features.Authentication.Commands.Validator
{
    public class SignInValidator : AbstractValidator<SignInCommand>
    {


        public SignInValidator()
        {
            ApplyValidationRules();


        }


        public void ApplyValidationRules()
        {


            RuleFor(x => x.Password)
      .NotEmpty().WithMessage("{PropertyName} is Not Empty")
      .NotNull().WithMessage("{ProperyName} is Not Null");




        }
    }

}
