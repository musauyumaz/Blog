using MediatR;

namespace Blog.Application.Features.Categories.Queries.GetAll
{
    public class GetAllCategoryQueryRequest : IRequest<GetAllCategoryQueryResponse>{}
}
