using Blog.Application.Abstractions.Services;
using Blog.Application.Features.Categories.DTOs;
using MediatR;

namespace Blog.Application.Features.Categories.Commands.Delete
{
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommandRequest, DeleteCategoryCommandResponse>
    {
        private readonly ICategoryService _categoryService;

        public DeleteCategoryCommandHandler(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<DeleteCategoryCommandResponse> Handle(DeleteCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            CategoryDTO categoryDTO = await _categoryService.DeleteCategoryAsync(request.Id);
            return new() { CategoryDTO= categoryDTO };
        }
    }
}
