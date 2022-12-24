using Blog.Application.Repositories.Contacts;
using Blog.Domain.Entities;
using Blog.Persistence.Contexts;

namespace Blog.Persistence.Repositories.Contacts
{
    public class ContactReadRepository : ReadRepository<Contact>, IContactReadRepository
    {
        public ContactReadRepository(BlogDbContext context) : base(context)
        {
        }
    }
}
