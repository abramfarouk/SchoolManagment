using MediatR;
using SchoolManagment.Core.Bases;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagment.Core.Features.Authentication.Commands.Models
{
    public class SignInCommand : IRequest<Responses<string>>
    {
        [EmailAddress]
        [Display(Name = "Email Or UserName")]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
