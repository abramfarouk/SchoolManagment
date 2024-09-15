using SchoolManagment.Core.Features.Students.Commands.Models;
using SchoolManagment.Data.Entities;

namespace SchoolManagment.Core.Mapping.Students
{
    public partial class StudentProfile
    {


        public void EditStudent()
        {
            CreateMap<EditStudentCommand, Student>()
                   .ForMember(des => des.StudID, opt => opt.MapFrom(src => src.Id))
                   .ForMember(des => des.DID, opt => opt.MapFrom(src => src.DeptarmentID));
        }

    }
}
