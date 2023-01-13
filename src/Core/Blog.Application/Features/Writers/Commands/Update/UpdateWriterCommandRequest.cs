using Blog.Application.Features.Writers.DTOs;
using Blog.Application.Utilities;
using MediatR;

namespace Blog.Application.Features.Writers.Commands.Update
{
    public class UpdateWriterCommandRequest : IRequest<IDataResult<WriterDTO>>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string About { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }
    }
}
