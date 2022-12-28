using Blog.Application.Features.Categories.DTOs;

namespace Blog.Application.Features.Categories.Queries.GetAll
{
    public class GetAllCategoryQueryResponse
    {
        public List<ListCategoryDTO> Categories { get; set; }
        public int TotalCategoryCount { get; set; }
    }
}
