using Blog.Application.Features.Headings.DTOs;
using Blog.Application.Utilities;
using MediatR;

namespace Blog.Application.Features.Headings.Queries.GetAll
{
    public class GetAllHeadingsQueryRequest : IRequest<IDataResult<ListHeadingRootDTO>>
    {
        public int Page { get; set; }
        public int Size { get; set; }
    }
}
