using Blog.Application.Abstractions.Services;
using Blog.Application.Features.Categories.Constants;
using Blog.Application.Features.Categories.DTOs;
using Blog.Application.Utilities;
using MediatR;

namespace Blog.Application.Features.Categories.Commands.Delete
{
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommandRequest, IDataResult<CategoryDTO>>
    {
        private readonly ICategoryService _categoryService;

        public DeleteCategoryCommandHandler(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IDataResult<CategoryDTO>> Handle(DeleteCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            CategoryDTO categoryDTO = await _categoryService.DeleteCategoryAsync(request.Id);
            return new SuccessDataResult<CategoryDTO>(Messages.DeleteCategory,categoryDTO);
        }
    }
}
