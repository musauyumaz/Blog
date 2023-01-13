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

        public async Task<CategoryListRootDTO> GetAllAsync(int page = 0, int size = 5)
        {
            List<ListCategoryDTO> data = await _categoryReadRepository.GetAll()
                                            .Skip(page * size)
                                            .Take(size)
                                            .Select(c => new ListCategoryDTO { Id = c.Id, Name = c.Name, Description = c.Description, CreatedDate = c.CreatedDate, UpdatedDate = c.UpdatedDate, IsActive = c.IsActive })
                                            .ToListAsync();
            int count = await _categoryReadRepository.GetAll().CountAsync();
            return new() { Categories = data, TotalCategoryCount = count };
        }

        public async Task<CategoryDTO> GetByIdAsync(int id)
        {
            Category category = await _categoryReadRepository.GetByIdAsync(id);
            return new() { Id = category.Id, Name = category.Name, Description = category.Description, IsActive = category.IsActive, CreatedDate = category.CreatedDate };
        }

        public async Task<CategoryHeadingsDTO> GetCategoryHeadingsByCategoryId(int id)
        {
            CategoryHeadingsDTO? categoryHeadings = await _categoryReadRepository.Table
                                         .Include(c => c.Headings)
                                         .Select(c => new CategoryHeadingsDTO
                                         {
                                             Id = c.Id,
                                             CategoryName = c.Name,
                                             HeadingsName = c.Headings.Select(h => h.Name).ToList()
                                         })
                                         .FirstOrDefaultAsync(c => c.Id == id);

            if (categoryHeadings == null)
                throw new Exception("Kategori Bulunamadı");
            return categoryHeadings;
        }


        public async Task<CategoryDTO> UpdateCategoryAsync(UpdateCategoryDTO updateCategoryDTO)
        {
            Category updatedCategory = await _categoryReadRepository.GetByIdAsync(updateCategoryDTO.Id, true);
            updatedCategory.Name = updateCategoryDTO.Name;
            updatedCategory.Description = updateCategoryDTO.Description;
            updatedCategory.IsActive = updateCategoryDTO.IsActive;
            Category category = _categoryWriteRepository.Update(updatedCategory);
            await _categoryWriteRepository.SaveAsync();
            return new() { Id = category.Id, Name = category.Name, Description = category.Description, CreatedDate = category.CreatedDate };
        }
    }
}
