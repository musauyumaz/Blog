using MediatR;

namespace Blog.Application.Features.Writers.Queries.GetAll
{
    public class GetAllWriterQueryRequest : IRequest<GetAllWriterQueryResponse>
    {
        public int Page { get; set; }
        public int Size { get; set; }
    }
}
