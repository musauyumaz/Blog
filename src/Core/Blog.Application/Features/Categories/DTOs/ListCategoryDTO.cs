namespace Blog.Application.Features.Categories.DTOs
{
    public class ListCategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
    public class CategoryListRootDTO
    {
        public List<ListCategoryDTO> Categories { get; set; }
        public int TotalCategoryCount { get; set; }
    }
}
