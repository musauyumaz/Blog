using MediatR;

namespace Blog.Application.Features.Writers.Commands.Create
{
    public class CreateWriterCommandRequest : IRequest<CreateWriterCommandResponse>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
