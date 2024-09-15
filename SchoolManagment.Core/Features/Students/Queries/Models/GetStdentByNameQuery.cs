using MediatR;
using SchoolManagment.Core.Features.Students.Queries.Results;

namespace SchoolManagment.Core.Features.Students.Queries.Models
{
    public class GetStdentByNameQuery : IRequest<Bases.Response<GetStdentByNameResponse>>
    {
        public string Name { get; set; }
        public GetStdentByNameQuery(string name)
        {
            Name = name;
        }
    }
}
