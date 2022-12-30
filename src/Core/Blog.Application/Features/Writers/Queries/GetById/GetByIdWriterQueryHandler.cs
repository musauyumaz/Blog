using Blog.Application.Abstractions.Services;
using Blog.Application.Features.Writers.DTOs;
using MediatR;

namespace Blog.Application.Features.Writers.Queries.GetById
{
    public class GetByIdWriterQueryHandler : IRequestHandler<GetByIdWriterQueryRequest, GetByIdWriterQueryResponse>
    {
        private readonly IWriterService _writerService;

        public GetByIdWriterQueryHandler(IWriterService writerService)
        {
            _writerService = writerService;
        }

        public async Task<GetByIdWriterQueryResponse> Handle(GetByIdWriterQueryRequest request, CancellationToken cancellationToken)
        {
            WriterDTO writer = await _writerService.GetByIdAsync(request.Id);
            return new() { WriterDTO = writer };
        }
    }
}
