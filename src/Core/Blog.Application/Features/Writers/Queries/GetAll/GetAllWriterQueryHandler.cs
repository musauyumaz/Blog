using Blog.Application.Abstractions.Services;
using MediatR;

namespace Blog.Application.Features.Writers.Queries.GetAll
{
    public class GetAllWriterQueryHandler : IRequestHandler<GetAllWriterQueryRequest, GetAllWriterQueryResponse>
    {
        private readonly IWriterService _writerService;

        public GetAllWriterQueryHandler(IWriterService writerService)
        {
            _writerService = writerService;
        }

        public async Task<GetAllWriterQueryResponse> Handle(GetAllWriterQueryRequest request, CancellationToken cancellationToken)
        {
            var writers = await _writerService.GetAllAsync(request.Page, request.Size);
            return new() { Writers = writers.writers, TotalWriterCount = writers.totalWriterCount };
        }
    }
}
