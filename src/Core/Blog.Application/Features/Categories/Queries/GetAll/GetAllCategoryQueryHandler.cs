using Blog.Application.Abstractions.Services;
using Blog.Application.Features.Categories.Constants;
using Blog.Application.Features.Categories.DTOs;
using Blog.Application.Utilities;
using MediatR;

namespace Blog.Application.Features.Categories.Queries.GetAll
{
    public class GetAllCategoryQueryHandler : IRequestHandler<GetAllCategoryQueryRequest, IDataResult<CategoryListRootDTO>>
    {
        private readonly ICategoryService _categoryService;

        public GetAllCategoryQueryHandler(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IDataResult<CategoryListRootDTO>> Handle(GetAllCategoryQueryRequest request, CancellationToken cancellationToken)
        {
            CategoryListRootDTO categoryList = await _categoryService.GetAllAsync(request.Page, request.Size);
            return new SuccessDataResult<CategoryListRootDTO>(Messages.GetAllCategory, categoryList);
        }
    }
}
