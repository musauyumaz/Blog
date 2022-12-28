﻿using Blog.Application.Features.Categories.DTOs;

namespace Blog.Application.Abstractions.Services
{
    public interface ICategoryService
    {
        Task<(List<ListCategoryDTO>,int totalCategoryCount)> GetAllAsync(int page = 0, int size = 5);
        Task<CategoryDTO> GetByIdAsync(int id);
        Task<CategoryDTO> AddCategoryAsync(AddCategoryDTO categoryAddDTO);
        Task<CategoryDTO> DeleteCategoryAsync(int id);
        Task<CategoryDTO> UpdateCategoryAsync(UpdateCategoryDTO updateCategoryDTO);
    }
}
