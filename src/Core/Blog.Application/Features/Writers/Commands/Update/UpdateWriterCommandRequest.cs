using MediatR;

namespace Blog.Application.Features.Writers.Commands.Update
{
    public class UpdateWriterCommandRequest : IRequest<UpdateWriterCommandResponse>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string About { get; set; }
        public bool IsActive { get; set; }
    }
}
