using SchoolManagment.Core.Features.User.Queries.Results;

namespace SchoolManagment.Core.Mapping.User
{
    public partial class UserProfile
    {

        public void GetUserById()
        {
            CreateMap<Data.Entities.Identity.User, GetUserByIdResponse>()
                .ForMember(des => des.Phone, opt => opt.MapFrom(src => src.PhoneNumber));

        }

    }
}
