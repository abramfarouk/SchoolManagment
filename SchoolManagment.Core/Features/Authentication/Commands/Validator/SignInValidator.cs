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
            RuleFor(x => x.Email)
      .Matches(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$")
      .NotEmpty().WithMessage("{PropertyName} is Not Empty")
      .NotNull().WithMessage("{ProperyName} is Not Null")
      .WithMessage("Invalid email address format. explample@gmail.com");


            RuleFor(x => x.Password)
      .NotEmpty().WithMessage("{PropertyName} is Not Empty")
      .NotNull().WithMessage("{ProperyName} is Not Null");




        }
    }

}
