using MediatR;
using SchoolManagment.Core.Bases;

namespace SchoolManagment.Core.Features.User.Commands.Models
{
    public class AddUserCommand : IRequest<Responses<string>>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? Country { get; set; }
    }
}
