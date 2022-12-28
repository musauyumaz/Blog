using Blog.Application.Abstractions.Services;
using Blog.Application.Features.Categories.DTOs;
using MediatR;

namespace Blog.Application.Features.Categories.Commands.Update
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommandRequest, UpdateCategoryCommandResponse>
    {
        private readonly ICategoryService _categoryService;

        public UpdateCategoryCommandHandler(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<UpdateCategoryCommandResponse> Handle(UpdateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            CategoryDTO categoryDTO = await _categoryService.UpdateCategoryAsync(new() { Id = request.Id, Name = request.Name, Description = request.Description, IsActive = request.IsActive });
            return new() { CategoryDTO = categoryDTO };
        }
    }
}
