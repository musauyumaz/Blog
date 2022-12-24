using Blog.Application.Repositories.Writers;
using Blog.Domain.Entities;
using Blog.Persistence.Contexts;

namespace Blog.Persistence.Repositories.Writers
{
    public class WriterReadRepository : ReadRepository<Writer>, IWriterReadRepository
    {
        public WriterReadRepository(BlogDbContext context) : base(context)
        {
        }
    }
}
