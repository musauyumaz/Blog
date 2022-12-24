using Blog.Application.Repositories.Files;
using Blog.Persistence.Contexts;

namespace Blog.Persistence.Repositories.Files
{
    public class FileReadRepository : ReadRepository<Domain.Entities.Files.File>, IFileReadRepository
    {
        public FileReadRepository(BlogDbContext context) : base(context)
        {
        }
    }
}
