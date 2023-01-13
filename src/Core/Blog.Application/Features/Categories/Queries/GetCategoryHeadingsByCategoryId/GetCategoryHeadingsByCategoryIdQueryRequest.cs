using Blog.Application.Features.Categories.DTOs;
using Blog.Application.Utilities;
using MediatR;

namespace Blog.Application.Features.Categories.Queries.GetCategoryHeadingsByCategoryId
{
    public class GetCategoryHeadingsByCategoryIdQueryRequest : IRequest<IDataResult<CategoryHeadingsDTO>>
    {
        public int Id { get; set; }
    }
}
