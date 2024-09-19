using MediatR;
using Microsoft.AspNetCore.Identity;
using SchoolManagment.Core.Bases;
using SchoolManagment.Core.Features.Authentication.Commands.Models;
using SchoolManagment.Services.Abstracts;
using System.ComponentModel.DataAnnotations;
using user = SchoolManagment.Data.Entities.Identity.User;

namespace SchoolManagment.Core.Features.Authentication.Commands.Handler
{
    public class AddSignInCommandHandler : ResponseHandler, IRequestHandler<SignInCommand, Responses<string>>
    {

        private UserManager<user> _usermanager;
        private readonly IAuthServices authServices;


        public AddSignInCommandHandler(UserManager<user> usermanager, IAuthServices authServices)
        {
            _usermanager = usermanager;
            this.authServices = authServices;
        }
        public async Task<Responses<string>> Handle(SignInCommand request, CancellationToken cancellationToken)
        {
            //if check user is Exist or not 
            var user = new EmailAddressAttribute().IsValid(request.Email) ?
              await _usermanager.FindByEmailAsync(request.Email) :

              await _usermanager.FindByNameAsync(request.Email);
            if (user == null)
            {
                return NotFound<string>("Invalid Email Or Password");

            }
            bool found = await _usermanager.CheckPasswordAsync(user, request.Password);
            if (!found)
            {
                return NotFound<string>("Invalid Email Or Password");

            }

            var accessToken = await authServices.GetJWTToken(user);

            return Success(accessToken);



        }
    }
}
