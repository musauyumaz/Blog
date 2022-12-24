using Blog.Application.Repositories.WriterImageFiles;
using Blog.Domain.Entities.Files;
using Blog.Persistence.Contexts;

namespace Blog.Persistence.Repositories.WriterImageFiles
{
    public class WriterImageFileWriteRepository : WriteRepository<WriterImageFile>, IWriterImageFileWriteRepository
    {
        public WriterImageFileWriteRepository(BlogDbContext context) : base(context)
        {
        }
    }
}
