using MediatR;
using SchoolManagment.Core.Bases;

namespace SchoolManagment.Core.Features.Students.Commands.Models
{
    public class CreateStudentCommand : IRequest<Responses<string>>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string? Phone { get; set; }
        public int DeptarmentID { get; set; }
    }
}
