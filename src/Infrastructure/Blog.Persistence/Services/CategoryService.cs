using Blog.Application.Abstractions.Services;
using Blog.Application.Features.Categories.DTOs;
using Blog.Application.Repositories.Categories;
using Blog.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blog.Persistence.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryReadRepository _categoryReadRepository;
        private readonly ICategoryWriteRepository _categoryWriteRepository;

        public CategoryService(ICategoryReadRepository categoryReadRepository, ICategoryWriteRepository categoryWriteRepository)
        {
            _categoryReadRepository = categoryReadRepository;
            _categoryWriteRepository = categoryWriteRepository;
        }

        public async Task<CategoryDTO> AddCategoryAsync(AddCategoryDTO categoryAddDTO)
        {
            Category category = await _categoryWriteRepository.AddAsync(new() { Name = categoryAddDTO.Name, Description = categoryAddDTO.Description });
            await _categoryWriteRepository.SaveAsync();
            return new() { Id = category.Id, Name = category.Name, Description = category.Description, CreatedDate = category.CreatedDate };
        }

        public async Task<CategoryDTO> DeleteCategoryAsync(int id)
        {
            Category category = await _categoryWriteRepository.RemoveAsync(id);
            await _categoryWriteRepository.SaveAsync();
            return new() { Id = category.Id, Name = category.Name, Description = category.Description, CreatedDate = category.CreatedDate };
        }

        public async Task<List<ListCategoryDTO>> GetAllAsync()
            => await _categoryReadRepository.GetAll().Select(c => new ListCategoryDTO { Name = c.Name, Description = c.Description }).ToListAsync();

        public async Task<CategoryDTO> GetByIdAsync(int id)
        {
            Category category = await _categoryReadRepository.GetByIdAsync(id);
            return new() { Id = category.Id, Name = category.Name, Description = category.Description, CreatedDate = category.CreatedDate };
        }

        public async Task<CategoryDTO> UpdateCategoryAsync(UpdateCategoryDTO updateCategoryDTO)
        {
            Category category = _categoryWriteRepository.Update(new() { Id = updateCategoryDTO.Id, Name = updateCategoryDTO.Name, Description = updateCategoryDTO.Description, IsActive = updateCategoryDTO.IsActive });
            await _categoryWriteRepository.SaveAsync();
            return new() { Id = category.Id, Name = category.Name, Description = category.Description, CreatedDate = category.CreatedDate };
        }
    }
}
