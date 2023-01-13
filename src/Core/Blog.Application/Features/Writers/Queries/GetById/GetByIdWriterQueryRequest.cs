using Blog.Application.Features.Writers.DTOs;
using Blog.Application.Utilities;
using MediatR;

namespace Blog.Application.Features.Writers.Queries.GetById
{
    public class GetByIdWriterQueryRequest : IRequest<IDataResult<WriterDTO>>
    {
        public int Id { get; set; }
    }
}
