using Blog.Application.Abstractions.Services;
using Blog.Application.Features.Writers.DTOs;
using Blog.Application.Repositories.Writers;
using Blog.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blog.Persistence.Services
{
    public class WriterService : IWriterService
    {
        private readonly IWriterReadRepository _writerReadRepository;
        private readonly IWriterWriteRepository _writerWriteRepository;

        public WriterService(IWriterReadRepository writerReadRepository, IWriterWriteRepository writerWriteRepository)
        {
            _writerReadRepository = writerReadRepository;
            _writerWriteRepository = writerWriteRepository;
        }

        public async Task<WriterDTO> AddWriterAsync(AddWriterDTO addWriterDTO)
        {
            Writer writer = await _writerWriteRepository.AddAsync(new() { FirstName = addWriterDTO.FirstName, LastName = addWriterDTO.LastName, Email = addWriterDTO.Email, Password = addWriterDTO.Password });
            await _writerWriteRepository.SaveAsync();
            return new() { Id = writer.Id, FirstName = writer.FirstName, LastName = writer.LastName, Email = writer.Email, IsActive = writer.IsActive, CreatedDate = writer.CreatedDate };
        }

        public async Task<WriterDTO> DeleteWriterAsync(int id)
        {
            Writer writer = await _writerWriteRepository.RemoveAsync(id);
            await _writerWriteRepository.SaveAsync();
            return new() { Id = writer.Id, FirstName = writer.FirstName, LastName = writer.LastName, Email = writer.Email, IsActive = writer.IsActive, CreatedDate = writer.CreatedDate };
        }

        public async Task<(List<ListWriterDTO> writers, int totalWriterCount)> GetAllAsync(int page, int size)
            => (await _writerReadRepository.Table.Include(w => w.WriterImageFiles).Skip(page * size).Take(size).Select
            (
                w => new ListWriterDTO
                {
                    Email = w.Email,
                    FirstName = w.FirstName,
                    LastName = w.LastName,
                    Photos = w.WriterImageFiles.Select(i => i.FileName).ToList()
                }
            ).ToListAsync(), await _writerReadRepository.GetAll().CountAsync());

        public async Task<WriterDTO> GetByIdAsync(int id)
        {
            Writer writer = await _writerReadRepository.GetByIdAsync(id);
            return new() { Id = writer.Id, FirstName = writer.FirstName, LastName = writer.LastName, Email = writer.Email, IsActive = writer.IsActive, CreatedDate = writer.CreatedDate };
        }

        public async Task<WriterDTO> UpdateWriterAsync(UpdateWriterDTO updateWriterDTO)
        {
            Writer updatedWriter = await _writerReadRepository.GetByIdAsync(updateWriterDTO.Id);
            updatedWriter.FirstName = updateWriterDTO.FirstName;
            updatedWriter.LastName = updateWriterDTO.LastName;
            updatedWriter.Email = updateWriterDTO.Email;
            updatedWriter.IsActive = updateWriterDTO.IsActive;
            Writer writer = _writerWriteRepository.Update(updatedWriter);
            await _writerWriteRepository.SaveAsync();
            return new() { Id = writer.Id, FirstName = writer.FirstName, LastName = writer.LastName, Email = writer.Email, IsActive = writer.IsActive, CreatedDate = writer.CreatedDate };
        }
    }
}
