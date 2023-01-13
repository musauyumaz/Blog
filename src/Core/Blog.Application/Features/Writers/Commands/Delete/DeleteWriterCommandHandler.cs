using Blog.Application.Abstractions.Services;
using Blog.Application.Features.Writers.Constants;
using Blog.Application.Features.Writers.DTOs;
using Blog.Application.Utilities;
using MediatR;

namespace Blog.Application.Features.Writers.Commands.Delete
{
    public class DeleteWriterCommandHandler : IRequestHandler<DeleteWriterCommandRequest, IDataResult<WriterDTO>>
    {
        private readonly IWriterService _writerService;

        public DeleteWriterCommandHandler(IWriterService writerService)
        {
            _writerService = writerService;
        }

        public async Task<IDataResult<WriterDTO>> Handle(DeleteWriterCommandRequest request, CancellationToken cancellationToken)
        {
            WriterDTO writerDto = await _writerService.DeleteWriterAsync(request.Id);
            return new SuccessDataResult<WriterDTO>(Messages.DeleteWriter, writerDto) ;
        }
    }
}
