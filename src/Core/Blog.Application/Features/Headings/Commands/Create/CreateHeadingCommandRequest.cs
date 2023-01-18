using Blog.Application.Features.Headings.DTOs;
using Blog.Application.Utilities;
using MediatR;

namespace Blog.Application.Features.Headings.Commands.Create
{
    public class CreateHeadingCommandRequest : IRequest<IDataResult<HeadingDTO>>
    {
        public string Name { get; set; }
        public int WriterId { get; set; }
        public int CategoryId { get; set; }
    }
}
