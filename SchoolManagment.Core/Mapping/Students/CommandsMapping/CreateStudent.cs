using SchoolManagment.Core.Features.Students.Commands.Models;
using SchoolManagment.Data.Entities;

namespace SchoolManagment.Core.Mapping.Students
{
    public partial class StudentProfile
    {


        public void CreateStudent()
        {
            CreateMap<CreateStudentCommand, Student>()
                   .ForMember(des => des.DID, opt => opt.MapFrom(src => src.DeptarmentID));

        }

    }
}
