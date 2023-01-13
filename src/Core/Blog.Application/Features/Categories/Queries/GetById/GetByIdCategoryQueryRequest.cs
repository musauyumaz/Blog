using Blog.Application.Features.Categories.DTOs;
using Blog.Application.Utilities;
using MediatR;

namespace Blog.Application.Features.Categories.Queries.GetById
{
    public class GetByIdCategoryQueryRequest : IRequest<IDataResult<CategoryDTO>>
    {
        public int Id { get; set; }
    }
}
