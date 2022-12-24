using Blog.Application.Repositories.Contacts;
using Blog.Domain.Entities;
using Blog.Persistence.Contexts;

namespace Blog.Persistence.Repositories.Contacts
{
    public class ContactWriteRepository : WriteRepository<Contact>, IContactWriteRepository
    {
        public ContactWriteRepository(BlogDbContext context) : base(context)
        {
        }
    }
}
