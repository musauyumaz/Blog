using Blog.Application.Features.Writers.DTOs;

namespace Blog.Application.Features.Writers.Queries.GetAll
{
    public class GetAllWriterQueryResponse
    {
        public List<ListWriterDTO> Writers { get; set; }
        public int TotalWriterCount { get; set; }
    }
}
