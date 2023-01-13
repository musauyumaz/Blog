using Blog.Application.Features.Writers.DTOs;
using Blog.Application.Utilities;
using MediatR;

namespace Blog.Application.Features.Writers.Commands.Delete
{
    public class DeleteWriterCommandRequest : IRequest<IDataResult<WriterDTO>>
    {
        public int Id { get; set; }
    }
}
