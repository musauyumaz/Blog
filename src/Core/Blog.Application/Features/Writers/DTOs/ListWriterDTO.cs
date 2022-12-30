namespace Blog.Application.Features.Writers.DTOs
{
    public class ListWriterDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<string> Photos { get; set; }
    }
}
