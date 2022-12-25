using Blog.Application.Abstractions.Services;
using Blog.Application.Features.Categories.DTOs;
using MediatR;

namespace Blog.Application.Features.Categories.Commands.Create
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommandRequest, CreateCategoryCommandResponse>
    {
        private readonly ICategoryService _categoryService;

        public CreateCategoryCommandHandler(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<CreateCategoryCommandResponse> Handle(CreateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            CategoryDTO category = await _categoryService.AddCategoryAsync(new() { Name = request.Name, Description = request.Description });
            return new() { CategoryDTO = category };
        }
    }
}
