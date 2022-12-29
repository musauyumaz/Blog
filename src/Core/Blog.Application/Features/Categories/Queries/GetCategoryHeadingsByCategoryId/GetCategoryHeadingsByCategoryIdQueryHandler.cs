using Blog.Application.Abstractions.Services;
using MediatR;

namespace Blog.Application.Features.Categories.Queries.GetCategoryHeadingsByCategoryId
{
    public class GetCategoryHeadingsByCategoryIdQueryHandler : IRequestHandler<GetCategoryHeadingsByCategoryIdQueryRequest, GetCategoryHeadingsByCategoryIdQueryResponse>
    {
        private readonly ICategoryService _categoryService;

        public GetCategoryHeadingsByCategoryIdQueryHandler(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<GetCategoryHeadingsByCategoryIdQueryResponse> Handle(GetCategoryHeadingsByCategoryIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _categoryService.GetCategoryHeadingsByCategoryId(request.Id);
            return new() { CategoryName = data.CategoryName, HeadingsName = data.HeadingsName };
        }
    }
}
