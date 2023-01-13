using Blog.Application.Features.Categories.DTOs;
using Blog.Application.Utilities;
using MediatR;

namespace Blog.Application.Features.Categories.Queries.GetAll
{
    public class GetAllCategoryQueryRequest : IRequest<IDataResult<CategoryListRootDTO>>
    {
        public int Page { get; set; }
        public int Size { get; set; }
    }
}
