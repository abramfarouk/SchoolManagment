using MediatR;

namespace SchoolManagment.Core.Features.User.Commands.Models
{
    public class DeleteUserByIdCommand : IRequest<Bases.Response<string>>
    {
        public int Id { get; set; }

        public DeleteUserByIdCommand(int id)
        {
            Id = id;
        }
    }
}
