using Blog.Application.Abstractions.Services;
using Blog.Application.Features.Categories.Constants;
using Blog.Application.Features.Categories.DTOs;
using Blog.Application.Utilities;
using MediatR;

namespace Blog.Application.Features.Categories.Queries.GetById
{
    public class GetByIdCategoryQueryHandler : IRequestHandler<GetByIdCategoryQueryRequest, IDataResult<CategoryDTO>>
    {
        private readonly ICategoryService _categoryService;

        public GetByIdCategoryQueryHandler(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IDataResult<CategoryDTO>> Handle(GetByIdCategoryQueryRequest request, CancellationToken cancellationToken)
        {
            CategoryDTO categoryDTO = await _categoryService.GetByIdAsync(request.Id);
            return new SuccessDataResult<CategoryDTO>(Messages.GetCategory,categoryDTO);
        }
    }
}
