using MediatR;

namespace Blog.Application.Features.Categories.Queries.GetAll
{
    public class GetAllCategoryQueryRequest : IRequest<GetAllCategoryQueryResponse>
    {
        public int Page { get; set; }
        public int Size { get; set; }
    }
}
