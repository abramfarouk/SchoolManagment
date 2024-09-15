using SchoolManagment.Core.Features.Students.Queries.Results;
using SchoolManagment.Data.Entities;

namespace SchoolManagment.Core.Mapping.Students
{
    public partial class StudentProfile
    {
        public void GetStudentByIDMapping()
        {
            CreateMap<Student, GetStudentReponse>()
                   .ForMember(des => des.Code, opt => opt.MapFrom(src => src.StudID))
                   .ForMember(des => des.DepartName, opt => opt.MapFrom(src => src.Department.DName));

        }
    }
}
