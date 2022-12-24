using Blog.Application.Repositories.Contents;
using Blog.Domain.Entities;
using Blog.Persistence.Contexts;

namespace Blog.Persistence.Repositories.Contents
{
    public class ContentReadRepository : ReadRepository<Content>, IContentReadRepository
    {
        public ContentReadRepository(BlogDbContext context) : base(context)
        {
        }
    }
}
