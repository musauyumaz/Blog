using Blog.Application.Repositories.Files;
using Blog.Persistence.Contexts;

namespace Blog.Persistence.Repositories.Files
{
    public class FileWriteRepository : WriteRepository<Domain.Entities.Files.File>, IFileWriteRepository
    {
        public FileWriteRepository(BlogDbContext context) : base(context)
        {
        }
    }
}
