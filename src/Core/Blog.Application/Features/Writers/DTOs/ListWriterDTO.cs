namespace Blog.Application.Features.Writers.DTOs
{
    public class ListWriterDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string About { get; set; }
        public string Title { get; set; }
        public List<string> Photos { get; set; }
    }
    public class ListWriterRootDTO
    {
        public List<ListWriterDTO> Writers { get; set; }
        public int TotalWriterCount { get; set; }
    }
}
