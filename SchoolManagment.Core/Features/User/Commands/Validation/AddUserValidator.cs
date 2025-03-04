using FluentValidation;
using SchoolManagment.Core.Features.User.Commands.Models;

namespace SchoolManagment.Core.Features.User.Commands.Validation
{
    public class AddUserValidator : AbstractValidator<AddUserCommand>
    {


        public AddUserValidator()
        {
            ApplyValidationRules();


        }


        public void ApplyValidationRules()
        {

            RuleFor(x => x.FirstName).NotEmpty().WithMessage("{PropertyName} is Not Empty")
                .NotNull().WithMessage("{ProperyName} is Not Null")
                .MaximumLength(30).WithMessage("FirstNamr Is Max 30");

            RuleFor(x => x.LastName).NotEmpty().WithMessage("{PropertyName} is Not Empty")
                .NotNull().WithMessage("{ProperyName} is Not Null")
                .MaximumLength(30).WithMessage("LastName Is Max 30");

            RuleFor(x => x.UserName).NotEmpty().WithMessage("{PropertyName} is Not Empty")
                .NotNull().WithMessage("{ProperyName} is Not Null")
                .MaximumLength(60).WithMessage("UserName Is Max 60");

            RuleFor(x => x.Phone)
          .Matches(@"^(?:010|011|012)[0-9]{8}$")
         .WithMessage("Phone number must start with 010, 011, or 012 and be followed by 8 digits.");



            RuleFor(x => x.Email)
      .Matches(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$")
      .NotEmpty().WithMessage("{PropertyName} is Not Empty")
      .NotNull().WithMessage("{ProperyName} is Not Null")
      .WithMessage("Invalid email address format. explample@gmail.com");


            RuleFor(x => x.Password)
      .NotEmpty().WithMessage("{PropertyName} is Not Empty")
      .NotNull().WithMessage("{ProperyName} is Not Null");


            RuleFor(x => x.ConfirmPassword)
      .NotEmpty().WithMessage("{PropertyName} is Not Empty")
      .NotNull().WithMessage("{ProperyName} is Not Null")
                .Equal(x => x.Password)
                .WithMessage("Passwords do not match.");

        }

    }
}
