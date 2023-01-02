using Blog.Application.Abstractions.Services;
using MediatR;

namespace Blog.Application.Features.Writers.Queries.GetHeadingsByWriter
{
    public class GetHeadingsByWriterQueryHandler : IRequestHandler<GetHeadingsByWriterQueryRequest, GetHeadingsByWriterQueryResponse>
    {
        private readonly IWriterService _writerService;

        public GetHeadingsByWriterQueryHandler(IWriterService writerService)
        {
            _writerService = writerService;
        }

        public async Task<GetHeadingsByWriterQueryResponse> Handle(GetHeadingsByWriterQueryRequest request, CancellationToken cancellationToken)
        {
            List<string> headings = await _writerService.GetWriterHeadingsByWriterIdAsync(request.Id);
            return new() { Headings = headings };
        }
    }
}
