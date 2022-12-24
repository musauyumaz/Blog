using Blog.Application.Repositories;
using Blog.Domain.Entities.Common;
using Blog.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Blog.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly BlogDbContext _context;

        public ReadRepository(BlogDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll(bool tracking = false)
        {
            var query = Table.AsQueryable();
            if(!tracking)
                query.AsNoTracking();
            return query;
        }

        public async Task<T> GetByIdAsync(int id, bool tracking = false)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query.AsNoTracking();
            return await query.FirstOrDefaultAsync(data => data.Id == id);
        }
    }
}
