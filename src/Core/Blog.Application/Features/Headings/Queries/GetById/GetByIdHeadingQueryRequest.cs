using Blog.Application.Features.Headings.DTOs;
using Blog.Application.Utilities;
using MediatR;

namespace Blog.Application.Features.Headings.Queries.GetById
{
    public class GetByIdHeadingQueryRequest : IRequest<IDataResult<HeadingDTO>>
    {
        public int Id { get; set; }
    }
}
