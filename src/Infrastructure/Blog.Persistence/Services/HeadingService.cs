using Blog.Application.Abstractions.Services;
using Blog.Application.Features.Headings.DTOs;
using Blog.Application.Repositories.Headings;
using Blog.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blog.Persistence.Services
{
    public class HeadingService : IHeadingService
    {
        private readonly IHeadingReadRepository _headingReadRepository;
        private readonly IHeadingWriteRepository _headingWriteRepository;

        public HeadingService(IHeadingReadRepository headingReadRepository, IHeadingWriteRepository headingWriteRepository)
        {
            _headingReadRepository = headingReadRepository;
            _headingWriteRepository = headingWriteRepository;
        }

        public async Task<HeadingDTO> AddHeadingAsync(AddHeadingDTO addHeadingDTO)
        {
            Heading heading = await _headingWriteRepository.AddAsync(new() { Name = addHeadingDTO.Name, CategoryId = addHeadingDTO.CategoryId, WriterId = addHeadingDTO.WriterId });
            await _headingWriteRepository.SaveAsync();
            return new() { Id = heading.Id, Name = heading.Name, CategoryId = heading.CategoryId, WriterId = heading.WriterId, IsActive = heading.IsActive, CreatedDate = heading.CreatedDate, UpdatedDate = heading.UpdatedDate };
        }

        public async Task<HeadingDTO> DeleteHeadingAsync(int id)
        {
            Heading heading = await _headingWriteRepository.RemoveAsync(id);
            await _headingWriteRepository.SaveAsync();
            return new() { Id = heading.Id, Name = heading.Name, CategoryId = heading.CategoryId, WriterId = heading.WriterId, IsActive = heading.IsActive, CreatedDate = heading.CreatedDate, UpdatedDate = heading.UpdatedDate };
        }

        public async Task<ListHeadingRootDTO> GetAllAsync(int page = 0, int size = 5)
        {
            List<ListHeadingDTO> listHeadings = await _headingReadRepository.GetAll()
                                                .Skip(page * size)
                                                .Take(size)
                                                .Include(h => h.Writer)
                                                .Include(h => h.Category)
                                                .Select(h => new ListHeadingDTO
                                                {
                                                    Id = h.Id,
                                                    Name = h.Name,
                                                    CategoryName = h.Category.Name,
                                                    WriterFullName = $"{h.Writer.FirstName} {h.Writer.LastName}",
                                                    CreatedDate = h.CreatedDate,
                                                    IsActive = h.IsActive,
                                                    UpdatedDate = h.UpdatedDate
                                                }
                                                ).ToListAsync();
            return new() { Headings = listHeadings, TotalHeadingCount = await _headingReadRepository.GetAll().CountAsync() };
        }

        public async Task<HeadingDTO> GetByIdAsync(int id)
        {
            Heading heading = await _headingReadRepository.GetByIdAsync(id, true);
            return new() { Id = heading.Id, Name = heading.Name, CategoryId = heading.CategoryId, WriterId = heading.WriterId, IsActive = heading.IsActive, CreatedDate = heading.CreatedDate, UpdatedDate = heading.UpdatedDate };
        }

        public async Task<HeadingDTO> UpdateHeadingAsync(UpdateHeadingDTO updateHeadingDTO)
        {
            Heading updatedHeading = await _headingReadRepository.GetByIdAsync(updateHeadingDTO.Id);
            updatedHeading.CategoryId = updateHeadingDTO.CategoryId;
            updatedHeading.Name = updateHeadingDTO.Name;
            updatedHeading.WriterId = updateHeadingDTO.WriterId;
            updatedHeading.IsActive = updateHeadingDTO.IsActive;
            Heading heading = _headingWriteRepository.Update(updatedHeading);
            await _headingWriteRepository.SaveAsync();
            return new() { Id = heading.Id, Name = heading.Name, CategoryId = heading.CategoryId, WriterId = heading.WriterId, IsActive = heading.IsActive, CreatedDate = heading.CreatedDate, UpdatedDate = heading.UpdatedDate };
        }
    }
}
