using Blog.Application.Repositories.Abouts;
using Blog.Domain.Entities;
using Blog.Persistence.Contexts;

namespace Blog.Persistence.Repositories.Abouts
{
    public class AboutReadRepository : ReadRepository<About>,IAboutReadRepository
    {
        public AboutReadRepository(BlogDbContext context) : base(context)
        {
        }
    }
}
