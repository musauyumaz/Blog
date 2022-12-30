using MediatR;

namespace Blog.Application.Features.Writers.Commands.Delete
{
    public class DeleteWriterCommandRequest : IRequest<DeleteWriterCommandResponse>
    {
        public int Id { get; set; }
    }
}
