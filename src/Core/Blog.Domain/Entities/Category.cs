using Blog.Domain.Entities.Common;

namespace Blog.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Heading> Headings { get; set; }
    }
}
