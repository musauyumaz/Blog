using Blog.Application.Features.Writers.DTOs;
using Blog.Application.Utilities;
using MediatR;

namespace Blog.Application.Features.Writers.Queries.GetAll
{
    public class GetAllWriterQueryRequest : IRequest<IDataResult<ListWriterRootDTO>>
    {
        public int Page { get; set; }
        public int Size { get; set; }
    }
}
