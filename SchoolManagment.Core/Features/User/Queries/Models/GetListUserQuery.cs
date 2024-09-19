using MediatR;
using SchoolManagment.Core.Features.User.Queries.Results;
using SchoolManagment.Core.Wrappers;

namespace SchoolManagment.Core.Features.User.Queries.Models
{
    public class GetListUserQuery : IRequest<PaginatedResult<GetListUserResponse>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

    }
}
