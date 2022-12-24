using Blog.Application.Repositories.AboutImageFiles;
using Blog.Domain.Entities.Files;
using Blog.Persistence.Contexts;

namespace Blog.Persistence.Repositories.AboutImageFiles
{
    public class AboutImageFileReadRepository : ReadRepository<AboutImageFile>, IAboutImageFileReadRepository
    {
        public AboutImageFileReadRepository(BlogDbContext context) : base(context)
        {
        }
    }
}
