using Blog.Application.Utilities;
using MediatR;

namespace Blog.Application.Features.Writers.Queries.GetHeadingsByWriter
{
    public class GetHeadingsByWriterQueryRequest : IRequest<IDataResult<List<string>>>
    {
        public int Id { get; set; }
    }
}
