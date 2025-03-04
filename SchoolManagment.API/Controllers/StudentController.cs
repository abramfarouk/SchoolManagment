using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolManagment.Core.Features.Students.Commands.Models;
using SchoolManagment.Core.Features.Students.Queries.Models;
using SchoolManagment.Data.AppMetaData;
using SchoolSystemCleanArchitecture.Api.Base;

namespace SchoolManagment.API.Controllers
{
    [ApiController]
    [Authorize]
    public class StudentController : AppControllerBase
    {

        [HttpGet(Router.StudentRouting.List)]
        public async Task<IActionResult> GetListStudentAsync()
        {
            var response = await _mediator.Send(new GetStudentListQuery());
            return abram(response);
        }
        [AllowAnonymous]

        [HttpGet(Router.StudentRouting.GetById)]
        public async Task<IActionResult> GetStdById(int id)
        {
            var response = await _mediator.Send(new GetStudentQuery() { Id = id });
            return abram(response);


        }
        [HttpGet(Router.StudentRouting.GetByName)]
        public async Task<IActionResult> GetStdByName(string name)
        {
            var response = await _mediator.Send(new GetStdentByNameQuery(name));
            return abram(response);


        }

        [HttpPost(Router.StudentRouting.Create)]
        public async Task<IActionResult> CreateAsync(CreateStudentCommand command)
        {
            var res = await _mediator.Send(command);
            return abram(res);
        }

        [HttpPut(Router.StudentRouting.Update)]
        public async Task<IActionResult> UpdateAsync(EditStudentCommand command)
        {
            var res = await _mediator.Send(command);
            return abram(res);
        }

        [HttpDelete(Router.StudentRouting.Delete)]
        public async Task<IActionResult> RemoveAsync(int id)
        {
            var res = await _mediator.Send(new DeleteStudentCommand(id));
            return abram(res);
        }


    }

}
