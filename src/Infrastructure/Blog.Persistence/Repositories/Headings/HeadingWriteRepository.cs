using Blog.Application.Repositories.Headings;
using Blog.Domain.Entities;
using Blog.Persistence.Contexts;

namespace Blog.Persistence.Repositories.Headings
{
    public class HeadingWriteRepository : WriteRepository<Heading>, IHeadingWriteRepository
    {
        public HeadingWriteRepository(BlogDbContext context) : base(context)
        {
        }
    }
}
