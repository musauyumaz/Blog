using Blog.Application.Abstractions.Services;
using Blog.Application.Features.Categories.Constants;
using Blog.Application.Features.Categories.DTOs;
using Blog.Application.Utilities;
using MediatR;

namespace Blog.Application.Features.Categories.Commands.Update
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommandRequest, IDataResult<CategoryDTO>>
    {
        private readonly ICategoryService _categoryService;

        public UpdateCategoryCommandHandler(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IDataResult<CategoryDTO>> Handle(UpdateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            CategoryDTO categoryDTO = await _categoryService.UpdateCategoryAsync(request.UpdateCategoryDTO);
            return new SuccessDataResult<CategoryDTO>(Messages.UpdateCategory,categoryDTO) ;
        }
    }
}
