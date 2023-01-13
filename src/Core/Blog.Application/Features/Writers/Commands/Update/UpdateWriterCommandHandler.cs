using Blog.Application.Abstractions.Services;
using Blog.Application.Features.Writers.Constants;
using Blog.Application.Features.Writers.DTOs;
using Blog.Application.Utilities;
using MediatR;

namespace Blog.Application.Features.Writers.Commands.Update
{
    public class UpdateWriterCommandHandler : IRequestHandler<UpdateWriterCommandRequest, IDataResult<WriterDTO>>
    {
        private readonly IWriterService _writerService;

        public UpdateWriterCommandHandler(IWriterService writerService)
        {
            _writerService = writerService;
        }

        public async Task<IDataResult<WriterDTO>> Handle(UpdateWriterCommandRequest request, CancellationToken cancellationToken)
        {
            WriterDTO writerDto = await _writerService.UpdateWriterAsync(new() { Id = request.Id, Email = request.Email, FirstName = request.FirstName, LastName = request.LastName, About = request.About, IsActive = request.IsActive,Title = request.Title });
            return new SuccessDataResult<WriterDTO>(Messages.UpdateWriter,writerDto);
        }
    }
}
