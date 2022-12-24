using Blog.Application.Repositories.Contents;
using Blog.Domain.Entities;
using Blog.Persistence.Contexts;

namespace Blog.Persistence.Repositories.Contents
{
    public class ContentWriteRepository : WriteRepository<Content>, IContentWriteRepository
    {
        public ContentWriteRepository(BlogDbContext context) : base(context)
        {
        }
    }
}
