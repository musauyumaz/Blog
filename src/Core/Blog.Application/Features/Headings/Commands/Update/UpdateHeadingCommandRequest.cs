using Blog.Application.Features.Headings.DTOs;
using Blog.Application.Utilities;
using MediatR;

namespace Blog.Application.Features.Headings.Commands.Update
{
    public class UpdateHeadingCommandRequest : IRequest<IDataResult<HeadingDTO>>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int WriterId { get; set; }
        public int CategoryId { get; set; }
        public bool IsActive { get; set; }
    }
}

