using MediatR;
using SchoolManagment.Core.Bases;

namespace SchoolManagment.Core.Features.Authentication.Commands.Models
{
    public class SignInCommand : IRequest<Responses<string>>
    {

        public string Email { get; set; }
        public string Password { get; set; }
    }
}
