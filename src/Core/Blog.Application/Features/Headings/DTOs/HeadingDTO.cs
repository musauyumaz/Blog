namespace Blog.Application.Features.Headings.DTOs
{
    public class HeadingDTO
    {
        public int Id { get; set; }
        public int WriterId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
