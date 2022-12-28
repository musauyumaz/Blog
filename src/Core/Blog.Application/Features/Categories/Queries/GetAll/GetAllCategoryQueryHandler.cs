using Blog.Application.Abstractions.Services;
using MediatR;

namespace Blog.Application.Features.Categories.Queries.GetAll
{
    public class GetAllCategoryQueryHandler : IRequestHandler<GetAllCategoryQueryRequest, GetAllCategoryQueryResponse>
    {
        private readonly ICategoryService _categoryService;

        public GetAllCategoryQueryHandler(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<GetAllCategoryQueryResponse> Handle(GetAllCategoryQueryRequest request, CancellationToken cancellationToken)
        {
            var (categoryList,totalCategoryCount) = await _categoryService.GetAllAsync(request.Page, request.Size);
            return new() { Categories = categoryList, TotalCategoryCount = totalCategoryCount };
        }
    }
}
