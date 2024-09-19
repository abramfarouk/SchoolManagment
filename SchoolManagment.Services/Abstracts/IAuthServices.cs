using SchoolManagment.Data.Entities.Identity;

namespace SchoolManagment.Services.Abstracts
{
    public interface IAuthServices
    {
        public Task<string> GetJWTToken(User user);

    }
}
