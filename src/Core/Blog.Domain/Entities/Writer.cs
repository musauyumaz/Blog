using Blog.Domain.Entities.Common;
using Blog.Domain.Entities.Files;

namespace Blog.Domain.Entities
{
    public class Writer : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<WriterImageFile> WriterImageFiles { get; set; }
        public virtual ICollection<Heading> Headings { get; set; }
        public virtual ICollection<Content> Contents { get; set; }

    }
}
