namespace Blog.Application.Features.Headings.DTOs
{
    public class UpdateHeadingDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int WriterId { get; set; }
        public int CategoryId { get; set; }
        public bool IsActive { get; set; }
    }
}
