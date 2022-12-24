using Blog.Application.Repositories.WriterImageFiles;
using Blog.Domain.Entities.Files;
using Blog.Persistence.Contexts;

namespace Blog.Persistence.Repositories.WriterImageFiles
{
    public class WriterImageFileReadRepository : ReadRepository<WriterImageFile>, IWriterImageFileReadRepository
    {
        public WriterImageFileReadRepository(BlogDbContext context) : base(context)
        {
        }
    }
}
