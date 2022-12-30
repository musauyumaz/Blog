using Blog.Application.Abstractions.Services;
using Blog.Application.Features.Writers.DTOs;
using MediatR;

namespace Blog.Application.Features.Writers.Commands.Update
{
    public class UpdateWriterCommandRequest : IRequest<UpdateWriterCommandResponse>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
    }
    public class UpdateWriterCommandResponse
    {
        public WriterDTO WriterDTO { get; set; }
    }
    public class UpdateWriterCommandHandler : IRequestHandler<UpdateWriterCommandRequest, UpdateWriterCommandResponse>
    {
        private readonly IWriterService _writerService;

        public UpdateWriterCommandHandler(IWriterService writerService)
        {
            _writerService = writerService;
        }

        public async Task<UpdateWriterCommandResponse> Handle(UpdateWriterCommandRequest request, CancellationToken cancellationToken)
        {
            WriterDTO writer = await _writerService.UpdateWriterAsync(new() { Id = request.Id, Email = request.Email, FirstName = request.FirstName, LastName = request.LastName, IsActive = request.IsActive });
            return new() { WriterDTO = writer };
        }
    }
}
