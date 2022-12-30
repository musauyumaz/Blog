using Blog.Application.Abstractions.Services;
using Blog.Application.Features.Writers.DTOs;
using MediatR;

namespace Blog.Application.Features.Writers.Commands.Create
{
    public class CreateWriterCommandHandler : IRequestHandler<CreateWriterCommandRequest, CreateWriterCommandResponse>
    {
        private readonly IWriterService _writerService;

        public CreateWriterCommandHandler(IWriterService writerService)
        {
            _writerService = writerService;
        }

        public async Task<CreateWriterCommandResponse> Handle(CreateWriterCommandRequest request, CancellationToken cancellationToken)
        {
            WriterDTO writer = await _writerService.AddWriterAsync(new() { FirstName = request.FirstName, LastName = request.LastName, Email = request.Email, Password = request.Password });
            return new() { WriterDTO = writer };
        }
    }
}
