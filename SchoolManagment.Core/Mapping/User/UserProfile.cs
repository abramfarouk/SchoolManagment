using AutoMapper;

namespace SchoolManagment.Core.Mapping.User
{
    public partial class UserProfile : Profile
    {
        public UserProfile()
        {
            AddUser();
            GetUserPagination();
            GetUserById();
        }
    }
}
