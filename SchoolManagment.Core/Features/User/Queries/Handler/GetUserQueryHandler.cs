using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SchoolManagment.Core.Bases;
using SchoolManagment.Core.Features.User.Queries.Models;
using SchoolManagment.Core.Features.User.Queries.Results;
using SchoolManagment.Core.Wrappers;
using user = SchoolManagment.Data.Entities.Identity.User;


namespace SchoolManagment.Core.Features.User.Queries.Handler
{
    public class GetUserQueryHandler : ResponseHandler
        , IRequestHandler<GetListUserQuery, PaginatedResult<GetListUserResponse>>
        , IRequestHandler<GetUserByIdQuery, Responses<GetUserByIdResponse>>
    {
        private readonly IMapper _mapper;
        private readonly UserManager<user> _userManager;
        public GetUserQueryHandler(IMapper mapper, UserManager<user> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<PaginatedResult<GetListUserResponse>> Handle(GetListUserQuery request, CancellationToken cancellationToken)
        {
            var users = _userManager.Users.AsQueryable();
            var PigatinationList = await _mapper.ProjectTo<GetListUserResponse>(users).ToPaginatedListAsync(request.PageNumber, request.PageSize);
            return PigatinationList;
        }

        public async Task<Responses<GetUserByIdResponse>> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var users = await _userManager.Users.FirstOrDefaultAsync(d => d.Id == request.Id);
            if (users == null) { return NotFound<GetUserByIdResponse>($"ID Not Founded {request.Id}"); }

            var result = _mapper.Map<GetUserByIdResponse>(users);

            return Success(result);
        }
    }
}
