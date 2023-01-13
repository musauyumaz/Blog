using Blog.Application.Features.Categories.DTOs;
using Blog.Application.Utilities;
using MediatR;

namespace Blog.Application.Features.Categories.Commands.Update
{
    public class UpdateCategoryCommandRequest : IRequest<IDataResult<CategoryDTO>>
    {
        public UpdateCategoryDTO UpdateCategoryDTO { get; set; }
    }
}
