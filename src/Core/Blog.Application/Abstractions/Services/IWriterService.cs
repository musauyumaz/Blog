using Blog.Application.Features.Writers.DTOs;

namespace Blog.Application.Abstractions.Services
{
    public interface IWriterService
    {
        Task<(List<ListWriterDTO> writers, int totalWriterCount)> GetAllAsync(int page, int size);
        Task<WriterDTO> AddWriterAsync(AddWriterDTO addWriterDTO);
        Task<WriterDTO> DeleteWriterAsync(int id);
        Task<WriterDTO> UpdateWriterAsync(UpdateWriterDTO updateWriterDTO);
        Task<WriterDTO> GetByIdAsync(int id);
    }
}


