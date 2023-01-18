using Blog.Application.Features.Headings.DTOs;

namespace Blog.Application.Abstractions.Services
{
    public interface IHeadingService
    {
        Task<ListHeadingRootDTO> GetAllAsync(int page = 0,int size = 5);
        Task<HeadingDTO> GetByIdAsync(int id);
        Task<HeadingDTO> AddHeadingAsync(AddHeadingDTO addHeadingDTO);
        Task<HeadingDTO> UpdateHeadingAsync(UpdateHeadingDTO updateHeadingDTO);
        Task<HeadingDTO> DeleteHeadingAsync(int id);
    }
}
