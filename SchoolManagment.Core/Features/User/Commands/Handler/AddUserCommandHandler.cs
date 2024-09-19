using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using SchoolManagment.Core.Bases;
using SchoolManagment.Core.Features.User.Commands.Models;
using user = SchoolManagment.Data.Entities.Identity.User;


namespace SchoolManagment.Core.Features.User.Commands.Handler
{

    public class AddUserCommandHandler : ResponseHandler
        , IRequestHandler<AddUserCommand, Responses<string>>
        , IRequestHandler<UpdateUserCommand, Responses<string>>
        , IRequestHandler<DeleteUserByIdCommand, Responses<string>>
    {

        private readonly IMapper _mapper;
        private readonly UserManager<user> _userManager;
        public AddUserCommandHandler(IMapper mapper, UserManager<Data.Entities.Identity.User> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;

        }
        public async Task<Responses<string>> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            var IsEmailExist = await _userManager.FindByEmailAsync(request.Email);
            if (IsEmailExist != null) { return BadRequest<string>($"Email Is Exist Must Be Change this =>{request.Email}"); }
            var IsUserNameExist = await _userManager.FindByNameAsync(request.UserName);
            if (IsUserNameExist != null) { return BadRequest<string>($"UserName Is Exist Must Be Change this =>{request.UserName}"); }

            var UserMap = _mapper.Map<user>(request);
            if (UserMap != null)
            {
                var result = await _userManager.CreateAsync(UserMap, request.Password);
                if (result.Succeeded)
                {
                    return Success<string>("Success");
                }
                else
                {
                    //foreach (var error in result.Errors)
                    //{
                    //    return BadRequest<string>(error.Description);

                    //}
                    var errorMessages = string.Join(", ", result.Errors.Select(e => e.Description));
                    return BadRequest<string>(errorMessages);
                }
            }
            return BadRequest<string>("Failed");

        }

        public async Task<Responses<string>> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {

            //findUser
            var OldUser = await _userManager.FindByIdAsync(request.Id.ToString());
            if (OldUser == null) { return NotFound<string>($"ID is not Founded {request.Id}"); }
            //mappING

            var newuser = _mapper.Map(request, OldUser);
            if (newuser == null) { return BadRequest<string>(); }

            var result = await _userManager.UpdateAsync(newuser);
            if (result.Succeeded)
            {
                return Success("Successfull Updated");
            }

            return BadRequest<string>("Failed Updated");




        }

        public async Task<Responses<string>> Handle(DeleteUserByIdCommand request, CancellationToken cancellationToken)
        {
            //foundUser 
            var user = await _userManager.FindByIdAsync(request.Id.ToString());
            if (user == null)
            {
                return NotFound<string>($"UserID :  {request.Id} iS Not Founded ");
            }

            var res = await _userManager.DeleteAsync(user);
            if (res.Succeeded)
            {
                return Deleted<string>("User Is Deleted Successfull");
            }
            return BadRequest<string>("Faild Delete");

        }
    }
}
