using SchoolManagment.Core.Features.User.Commands.Models;

namespace SchoolManagment.Core.Mapping.User
{
    public partial class UserProfile
    {

        public void AddUser()
        {

            CreateMap<AddUserCommand, SchoolManagment.Data.Entities.Identity.User>()
                .ForMember(des => des.PhoneNumber, opt => opt.MapFrom(src => src.Phone));




        }
    }
}
