using Blog.Application.Features.Categories.DTOs;
using Blog.Application.Utilities;
using MediatR;

namespace Blog.Application.Features.Categories.Commands.Delete
{
    public class DeleteCategoryCommandRequest : IRequest<IDataResult<CategoryDTO>>
    {
        public int Id { get; set; }
    }
}
