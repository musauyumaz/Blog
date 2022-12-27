using Blog.Application.Abstractions.Services;
using Blog.Application.Features.Categories.DTOs;
using MediatR;

namespace Blog.Application.Features.Categories.Queries.GetById
{
    public class GetByIdCategoryQueryRequest : IRequest<GetByIdCategoryQueryResponse>
    {
        public int Id { get; set; }
    }
    public class GetByIdCategoryQueryResponse
    {
        public CategoryDTO CategoryDTO { get; set; }
    }
    public class GetByIdCategoryQueryHandler : IRequestHandler<GetByIdCategoryQueryRequest, GetByIdCategoryQueryResponse>
    {
        private readonly ICategoryService _categoryService;

        public GetByIdCategoryQueryHandler(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<GetByIdCategoryQueryResponse> Handle(GetByIdCategoryQueryRequest request, CancellationToken cancellationToken)
        {
            CategoryDTO categoryDTO = await _categoryService.GetByIdAsync(request.Id);
            return new() { CategoryDTO = categoryDTO };
        }
    }
}
