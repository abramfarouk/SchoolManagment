using SchoolManagment.Data.Entities.Identity;
using SchoolManagment.Services.Abstracts;
using System.IdentityModel.Tokens.Jwt;

namespace SchoolManagment.Services.Implemetation
{
    public class AuthenticationServices : IAuthenticationServices
    {
        public Task<string> GetJWTToken(User user)
        {
            //Generate Token 


            var AccessToken = new JwtSecurityToken(
                issuer: "",
                audience: ""


                );

            throw new NotImplementedException();
        }
    }
}
