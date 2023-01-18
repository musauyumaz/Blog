using Blog.Application.Features.Headings.DTOs;
using Blog.Application.Utilities;
using MediatR;

namespace Blog.Application.Features.Headings.Commands.Delete
{
    public class DeleteHeadingCommandRequest : IRequest<IDataResult<HeadingDTO>>
    {
        public int Id { get; set; }
    }
}
