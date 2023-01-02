using MediatR;

namespace Blog.Application.Features.Writers.Queries.GetHeadingsByWriter
{
    public class GetHeadingsByWriterQueryRequest : IRequest<GetHeadingsByWriterQueryResponse>
    {
        public int Id { get; set; }
    }
}
