using AutoMapper;
using MediatR;
using SchoolManagment.Core.Bases;
using SchoolManagment.Core.Features.Students.Commands.Models;
using SchoolManagment.Data.Entities;
using SchoolManagment.Services.Abstracts;

namespace SchoolManagment.Core.Features.Students.Commands.Handlers
{
    public class AddStudentCommandHandler : ResponseHandler,
        IRequestHandler<CreateStudentCommand, Response<string>>,
         IRequestHandler<EditStudentCommand, Response<string>>,
         IRequestHandler<DeleteStudentCommand, Response<string>>
    {
        private readonly IMapper _mapper;
        private readonly IStudentServices _studentServices;

        public AddStudentCommandHandler(IMapper mapper, IStudentServices studentServices)
        {
            _mapper = mapper;
            _studentServices = studentServices;
        }
        public async Task<Response<string>> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            var StdMapper = _mapper.Map<Student>(request);
            var stdres = await _studentServices.AddStudentAsync(StdMapper);

            if (stdres == "Success") { return Created<string>("Add Successfull"); }
            else if (stdres == "Fk")
            {
                return UnprocessableEntity<string>("Fk is Error");
            }
            else
            {
                return BadRequest<string>();
            }

        }

        public async Task<Response<string>> Handle(EditStudentCommand request, CancellationToken cancellationToken)
        {
            var Std = await _studentServices.GetStudentByIdAysnc(request.Id);
            if (Std == null)
            {
                return NotFound<string>($"ID : {request.Id} Not Founded");
            }
            //Mapping
            var StdMapper = _mapper.Map<Student>(request);
            //_studentServices
            var result = await _studentServices.EditStudentAsync(StdMapper);
            if (result == "Updated") { return Success<string>($"Updated Successfull {StdMapper.StudID}"); }

            else
            {
                return BadRequest<string>();
            }

        }

        public async Task<Response<string>> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            var std = await _studentServices.GetStudentByIdAysnc(request.Id);
            if (std == null) { return NotFound<string>("ID Is Not Founded"); }

            var Result = await _studentServices.DeleteStudentAsync(std);
            if (Result == "Delete") { return Success<string>($"Delete Successfull {std.StudID}"); }

            else
            {
                return BadRequest<string>();
            }
        }
    }
}
