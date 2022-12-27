using Blog.Application.Features.Categories.DTOs;

namespace Blog.Application.Abstractions.Services
{
    public interface ICategoryService
    {
        Task<List<ListCategoryDTO>> GetAllAsync();
        Task<CategoryDTO> GetByIdAsync(int id);
        Task<CategoryDTO> AddCategoryAsync(AddCategoryDTO categoryAddDTO);
        Task<CategoryDTO> DeleteCategoryAsync(int id);
        Task<CategoryDTO> UpdateCategoryAsync(UpdateCategoryDTO updateCategoryDTO);
    }
}
