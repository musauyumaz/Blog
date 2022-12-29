using Blog.Application.Features.Categories.DTOs;
using MediatR;

namespace Blog.Application.Features.Categories.Commands.Update
{
    public class UpdateCategoryCommandRequest : IRequest<UpdateCategoryCommandResponse>
    {
        public UpdateCategoryDTO UpdateCategoryDTO { get; set; }
    }
}
