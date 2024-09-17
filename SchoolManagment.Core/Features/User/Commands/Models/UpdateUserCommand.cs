﻿using MediatR;
using SchoolManagment.Core.Bases;

namespace SchoolManagment.Core.Features.User.Commands.Models
{
    public class UpdateUserCommand : IRequest<Response<string>>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? Country { get; set; }

    }
}