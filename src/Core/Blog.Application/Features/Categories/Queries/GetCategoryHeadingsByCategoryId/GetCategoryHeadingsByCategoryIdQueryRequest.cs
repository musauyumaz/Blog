using MediatR;

namespace Blog.Application.Features.Categories.Queries.GetCategoryHeadingsByCategoryId
{
    public class GetCategoryHeadingsByCategoryIdQueryRequest : IRequest<GetCategoryHeadingsByCategoryIdQueryResponse>
    {
        public int Id { get; set; }
    }
}
