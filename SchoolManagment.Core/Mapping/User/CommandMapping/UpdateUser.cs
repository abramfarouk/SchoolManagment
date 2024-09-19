using SchoolManagment.Core.Features.User.Commands.Models;
namespace SchoolManagment.Core.Mapping.User
{
    public partial class UserProfile
    {

        public void UpdateUser()
        {

            CreateMap<UpdateUserCommand, SchoolManagment.Data.Entities.Identity.User>()
                .ForMember(des => des.PhoneNumber, opt => opt.MapFrom(src => src.Phone));


        }
    }
}
