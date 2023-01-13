using Blog.Application.Abstractions.Services;
using Blog.Application.Features.Writers.Constants;
using Blog.Application.Features.Writers.DTOs;
using Blog.Application.Utilities;
using MediatR;

namespace Blog.Application.Features.Writers.Commands.Create
{
    public class CreateWriterCommandHandler : IRequestHandler<CreateWriterCommandRequest, IDataResult<WriterDTO>>
    {
        private readonly IWriterService _writerService;

        public CreateWriterCommandHandler(IWriterService writerService)
        {
            _writerService = writerService;
        }

        public async Task<IDataResult<WriterDTO>> Handle(CreateWriterCommandRequest request, CancellationToken cancellationToken)
        {
            WriterDTO writerDto = await _writerService.AddWriterAsync(new() { FirstName = request.FirstName, LastName = request.LastName, About = request.About, Email = request.Email, Password = request.Password, Title = request.Title });
            return new SuccessDataResult<WriterDTO>(Messages.AddWriter,writerDto) ;
        }
    }
}
