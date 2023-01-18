namespace Blog.Application.Features.Headings.DTOs
{
    public class ListHeadingDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CategoryName { get; set; }
        public string WriterFullName { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
    public class ListHeadingRootDTO
    {
        public List<ListHeadingDTO> Headings{ get; set; }
        public int TotalHeadingCount { get; set; }
    }
}
