using Microsoft.AspNetCore.Mvc;
using SchoolManagment.Core.Features.User.Commands.Models;
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


    }
}
