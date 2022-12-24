using Blog.Application.Features.Categories.DTOs;

namespace Blog.Application.Abstractions.Services
{
    public interface ICategoryService
    {
        Task<List<ListCategoryDTO>> GetAllAsync();
        Task<CategoryDTO> AddCategoryAsync(CategoryAddDTO categoryAddDTO);
    }
}
