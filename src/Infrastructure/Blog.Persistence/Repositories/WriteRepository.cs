using Blog.Application.Repositories;
using Blog.Domain.Entities.Common;
using Blog.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Blog.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly BlogDbContext _context;

        public WriteRepository(BlogDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<T> AddAsync(T model)
        {
            EntityEntry entityEntry = await Table.AddAsync(model);
            entityEntry.State = EntityState.Added;
            return model;
        }

        public T Remove(T model)
        {
            EntityEntry entityEntry = Table.Remove(model);
            entityEntry.State = EntityState.Deleted;
            return model;
        }

        public async Task<T> RemoveAsync(int id)
        {
            T? model = await Table.FirstOrDefaultAsync(data=>data.Id == id);
            return Remove(model);
        }

        public async Task<int> SaveAsync()
            => await _context.SaveChangesAsync();

        public T Update(T model)
        {
            EntityEntry entityEntry = Table.Update(model);
            entityEntry.State = EntityState.Modified;
            return model;
        }
    }
}
