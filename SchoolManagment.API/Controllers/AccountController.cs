using Microsoft.AspNetCore.Mvc;
using SchoolManagment.Core.Features.User.Commands.Models;
using SchoolManagment.Core.Features.User.Queries.Models;
using SchoolManagment.Data.AppMetaData;
using SchoolSystemCleanArchitecture.Api.Base;

namespace SchoolManagment.API.Controllers
{
    [ApiController]
    public class AccountController : AppControllerBase
    {


        [HttpPost(Router.AccountRouting.Create)]
        public async Task<IActionResult> RegisterUserAsync(AddUserCommand command)
        {
            var response = await _mediator.Send(command);
            return abram(response);
        }

        [HttpGet(Router.AccountRouting.Pagination)]
        public async Task<IActionResult> GetLIstUserAsync([FromQuery] GetListUserQuery Query)
        {
            var response = await _mediator.Send(Query);
            return Ok(response);
        }
        [HttpGet(Router.AccountRouting.GetUserById)]
        public async Task<IActionResult> GetUserbyIdAsync(int id)
        {
            var response = await _mediator.Send(new GetUserByIdQuery(id));
            return Ok(response);
        }


    }
}
