using Blog.Application.Abstractions.Services;
using Blog.Application.Features.Writers.DTOs;
using MediatR;

namespace Blog.Application.Features.Writers.Commands.Delete
{
    public class DeleteWriterCommandHandler : IRequestHandler<DeleteWriterCommandRequest, DeleteWriterCommandResponse>
    {
        private readonly IWriterService _writerService;

        public DeleteWriterCommandHandler(IWriterService writerService)
        {
            _writerService = writerService;
        }

        public async Task<DeleteWriterCommandResponse> Handle(DeleteWriterCommandRequest request, CancellationToken cancellationToken)
        {
            WriterDTO writer = await _writerService.DeleteWriterAsync(request.Id);
            return new() { WriterDTO = writer };
        }
    }
}
