using Blog.Application.Features.Categories.DTOs;
using Blog.Application.Utilities;
using MediatR;

namespace Blog.Application.Features.Categories.Commands.Create
{
    public class CreateCategoryCommandRequest : IRequest<IDataResult<CategoryDTO>>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
