using SchoolManagment.Data.Entities.Identity;

namespace SchoolManagment.Services.Abstracts
{
    interface IAuthenticationServices
    {
        public Task<string> GetJWTToken(User user);

    }
}
