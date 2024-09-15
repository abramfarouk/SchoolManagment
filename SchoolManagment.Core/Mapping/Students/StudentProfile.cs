using AutoMapper;

namespace SchoolManagment.Core.Mapping.Students
{
    public partial class StudentProfile : Profile
    {

        public StudentProfile()
        {
            //Queries
            GetListStudent();
            GetStudentByIDMapping();
            GetStudentByNameMapping();


            //Commands
            CreateStudent();
            EditStudent();


        }
    }
}
