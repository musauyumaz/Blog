using Blog.Application.Repositories.AboutImageFiles;
using Blog.Domain.Entities.Files;
using Blog.Persistence.Contexts;

namespace Blog.Persistence.Repositories.AboutImageFiles
{
    public class AboutImageFileWriteRepository : WriteRepository<AboutImageFile>,IAboutImageFileWriteRepository
    {
        public AboutImageFileWriteRepository(BlogDbContext context) : base(context)
        {
        }
    }
}
