namespace Blog.Application.Features.Writers.DTOs
{
    public class WriterDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string About { get; set; }
        public bool IsActive { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
