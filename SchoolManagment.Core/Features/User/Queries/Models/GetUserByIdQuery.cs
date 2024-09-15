using MediatR;
using SchoolManagment.Core.Bases;
using SchoolManagment.Core.Features.User.Queries.Results;

namespace SchoolManagment.Core.Features.User.Queries.Models
{
    public class GetUserByIdQuery : IRequest<Response<GetUserByIdResponse>>
    {
        public int Id { get; set; }

        public GetUserByIdQuery(int id)
        {
            Id = id;
        }
    }
}
