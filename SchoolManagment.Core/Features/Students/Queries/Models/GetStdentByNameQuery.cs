using MediatR;
using SchoolManagment.Core.Features.Students.Queries.Results;

namespace SchoolManagment.Core.Features.Students.Queries.Models
{
    public class GetStdentByNameQuery : IRequest<Bases.Responses<GetStdentByNameResponse>>
    {
        public string Name { get; set; }
        public GetStdentByNameQuery(string name)
        {
            Name = name;
        }
    }
}
