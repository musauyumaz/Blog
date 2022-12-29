namespace Blog.Application.Features.Categories.DTOs
{
    public class CategoryHeadingsDTO 
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public List<string> HeadingsName { get; set; }
    }
}
