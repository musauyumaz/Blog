using Blog.Application.Abstractions.Services;
using Blog.Application.Features.Writers.Constants;
using Blog.Application.Utilities;
using MediatR;

namespace Blog.Application.Features.Writers.Queries.GetHeadingsByWriter
{
    public class GetHeadingsByWriterQueryHandler : IRequestHandler<GetHeadingsByWriterQueryRequest, IDataResult<List<string>>>
    {
        private readonly IWriterService _writerService;

        public GetHeadingsByWriterQueryHandler(IWriterService writerService)
        {
            _writerService = writerService;
        }

        public async Task<IDataResult<List<string>>> Handle(GetHeadingsByWriterQueryRequest request, CancellationToken cancellationToken)
        {
            List<string> headings = await _writerService.GetWriterHeadingsByWriterIdAsync(request.Id);
            return new SuccessDataResult<List<string>>(Messages.GetAllHeadingsByWriter,headings);
        }
    }
}
