﻿using MediatR;
using SchoolManagment.Core.Bases;
using SchoolManagment.Core.Features.Students.Queries.Results;

namespace SchoolManagment.Core.Features.Students.Queries.Models
{
    public class GetStudentQuery : IRequest<Response<GetStudentReponse>>
    {
        public int Id { get; set; }
    }
}
