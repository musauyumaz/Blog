using Blog.Application.Repositories.Abouts;
using Blog.Domain.Entities;
using Blog.Persistence.Contexts;

namespace Blog.Persistence.Repositories.Abouts
{
    public class AboutWriteRepository : WriteRepository<About>, IAboutWriteRepository
    {
        public AboutWriteRepository(BlogDbContext context) : base(context)
        {
        }
    }
}
