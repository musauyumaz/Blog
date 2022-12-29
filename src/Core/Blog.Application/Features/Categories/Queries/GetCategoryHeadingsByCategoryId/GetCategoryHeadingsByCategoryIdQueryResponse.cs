namespace Blog.Application.Features.Categories.Queries.GetCategoryHeadingsByCategoryId
{
    public class GetCategoryHeadingsByCategoryIdQueryResponse
    {
        public string CategoryName { get; set; }
        public List<string> HeadingsName { get; set; }
    }
}
