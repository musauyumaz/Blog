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
            var categories = await _categoryService.GetAllAsync();
            return new() { Categories= categories };
        }
    }
}
