using MediatR;
using Microsoft.AspNetCore.Identity;
using SchoolManagment.Core.Bases;
using SchoolManagment.Core.Features.Authentication.Commands.Models;
using user = SchoolManagment.Data.Entities.Identity.User;

namespace SchoolManagment.Core.Features.Authentication.Commands.Handler
{
    public class AddSignInCommandHandler : ResponseHandler, IRequestHandler<SignInCommand, Responses<string>>
    {

        private UserManager<user> _usermanager;
        private SignInManager<user> _signinmanager;

        public AddSignInCommandHandler(UserManager<user> usermanager, SignInManager<user> signinmanager)
        {
            _usermanager = usermanager;
            _signinmanager = signinmanager;
        }
        public async Task<Responses<string>> Handle(SignInCommand request, CancellationToken cancellationToken)
        {
            //if check user is Exist or not 
            var user = await _usermanager.FindByEmailAsync(request.Email);
            if (user == null) { return NotFound<string>("Email Or Password Is not Correct"); }

            // Check pass
            var SignInResult = await _signinmanager.CheckPasswordSignInAsync(user, request.Password, false);
            if (!SignInResult.Succeeded)
            { return BadRequest<string>("Email Or Password Is not Correct"); }

            //Generate Token 




            throw new NotImplementedException();
        }
    }
}
