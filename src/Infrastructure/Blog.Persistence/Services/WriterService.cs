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
            Writer writer = await _writerWriteRepository.AddAsync(new() { FirstName = addWriterDTO.FirstName, LastName = addWriterDTO.LastName, About = addWriterDTO.About, Email = addWriterDTO.Email, Password = addWriterDTO.Password });
            await _writerWriteRepository.SaveAsync();
            return new() { Id = writer.Id, FirstName = writer.FirstName, LastName = writer.LastName, Email = writer.Email, About = writer.About, Title = writer.Title, IsActive = writer.IsActive, CreatedDate = writer.CreatedDate };
        }
        public async Task<WriterDTO> DeleteWriterAsync(int id)
        {
            Writer writer = await _writerWriteRepository.RemoveAsync(id);
            await _writerWriteRepository.SaveAsync();
            return new() { Id = writer.Id, FirstName = writer.FirstName, LastName = writer.LastName, Email = writer.Email, About = writer.About, Title = writer.Title, IsActive = writer.IsActive, CreatedDate = writer.CreatedDate };
        }
        public async Task<ListWriterRootDTO> GetAllAsync(int page, int size)
        {
            List<ListWriterDTO> listWriters = await _writerReadRepository.Table.Include(w => w.WriterImageFiles).Skip(page * size).Take(size).Select
            (
                w => new ListWriterDTO
                {
                    Id = w.Id,
                    Email = w.Email,
                    FirstName = w.FirstName,
                    LastName = w.LastName,
                    About = w.About,
                    Title = w.Title,
                    Photos = w.WriterImageFiles.Select(i => i.FileName).ToList()
                }
            ).ToListAsync();
            int count = await _writerReadRepository.GetAll().CountAsync();
            return new() { Writers = listWriters, TotalWriterCount = count };

        }
        public async Task<WriterDTO> GetByIdAsync(int id)
        {
            Writer writer = await _writerReadRepository.GetByIdAsync(id);
            return new() { Id = writer.Id, FirstName = writer.FirstName, LastName = writer.LastName, Email = writer.Email, About = writer.About, Title = writer.Title, IsActive = writer.IsActive, CreatedDate = writer.CreatedDate };
        }
        public async Task<List<string>> GetWriterHeadingsByWriterIdAsync(int id)
            => (await _writerReadRepository.Table.Include(w => w.Headings)
                .Select(w => new
                {
                    Id = w.Id,
                    Headings = w.Headings.Select(h => h.Name).ToList()
                }
            ).FirstOrDefaultAsync(w => w.Id == id)).Headings;
        public async Task<WriterDTO> UpdateWriterAsync(UpdateWriterDTO updateWriterDTO)
        {
            Writer updatedWriter = await _writerReadRepository.GetByIdAsync(updateWriterDTO.Id);
            updatedWriter.FirstName = updateWriterDTO.FirstName;
            updatedWriter.LastName = updateWriterDTO.LastName;
            updatedWriter.Email = updateWriterDTO.Email;
            updatedWriter.About = updateWriterDTO.About;
            updatedWriter.Title = updateWriterDTO.Title;
            updatedWriter.IsActive = updateWriterDTO.IsActive;
            Writer writer = _writerWriteRepository.Update(updatedWriter);
            await _writerWriteRepository.SaveAsync();
            return new() { Id = writer.Id, FirstName = writer.FirstName, LastName = writer.LastName, Email = writer.Email, About = writer.About, Title = writer.Title, IsActive = writer.IsActive, CreatedDate = writer.CreatedDate };
        }
    }
}
