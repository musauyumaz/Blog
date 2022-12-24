using Blog.Application.Repositories.Writers;
using Blog.Domain.Entities;
using Blog.Persistence.Contexts;

namespace Blog.Persistence.Repositories.Writers
{
    public class WriterWriteRepository : WriteRepository<Writer>, IWriterWriteRepository
    {
        public WriterWriteRepository(BlogDbContext context) : base(context)
        {
        }
    }
}
