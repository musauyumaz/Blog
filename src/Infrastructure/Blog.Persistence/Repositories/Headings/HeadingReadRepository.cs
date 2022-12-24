using Blog.Application.Repositories.Headings;
using Blog.Domain.Entities;
using Blog.Persistence.Contexts;

namespace Blog.Persistence.Repositories.Headings
{
    public class HeadingReadRepository : ReadRepository<Heading>, IHeadingReadRepository
    {
        public HeadingReadRepository(BlogDbContext context) : base(context)
        {
        }
    }
}
