using Blog.Application.Abstractions.Services;
using Blog.Application.Features.Categories.Constants;
using Blog.Application.Features.Categories.DTOs;
using Blog.Application.Utilities;
using MediatR;

namespace Blog.Application.Features.Categories.Queries.GetCategoryHeadingsByCategoryId
{
    public class GetCategoryHeadingsByCategoryIdQueryHandler : IRequestHandler<GetCategoryHeadingsByCategoryIdQueryRequest, IDataResult<CategoryHeadingsDTO>>
    {
        private readonly ICategoryService _categoryService;

        public GetCategoryHeadingsByCategoryIdQueryHandler(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IDataResult<CategoryHeadingsDTO>> Handle(GetCategoryHeadingsByCategoryIdQueryRequest request, CancellationToken cancellationToken)
        {
            CategoryHeadingsDTO categoryHeadingsDTO = await _categoryService.GetCategoryHeadingsByCategoryId(request.Id);
            return new SuccessDataResult<CategoryHeadingsDTO>(Messages.GetCategoryHeadingsByCategory, categoryHeadingsDTO);
        }
    }
}
