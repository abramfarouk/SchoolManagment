using Microsoft.AspNetCore.Mvc;
using SchoolManagment.Core.Features.Authentication.Commands.Models;
using SchoolManagment.Data.AppMetaData;
using SchoolSystemCleanArchitecture.Api.Base;

namespace SchoolManagment.API.Controllers
{
    [ApiController]
    public class AuthenticationController : AppControllerBase
    {

        [HttpPost(Router.AuthenticationRouting.Create)]
        public async Task<IActionResult> SignInAsync([FromForm] SignInCommand command)
        {
            var response = await _mediator.Send(command);
            return abram(response);
        }
    }
}
