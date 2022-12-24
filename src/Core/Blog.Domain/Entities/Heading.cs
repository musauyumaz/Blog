using Blog.Domain.Entities.Common;

namespace Blog.Domain.Entities
{
    public class Heading : BaseEntity
    {
        public int WriterId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Content> Contents { get; set; }
        public virtual Writer Writer { get; set; }
    }
}
