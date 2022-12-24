using Blog.Domain.Entities.Common;

namespace Blog.Domain.Entities
{
    public class Content : BaseEntity
    {
        public int HeadingId { get; set; }
        public int? WriterId { get; set; }
        public string Value { get; set; }

        public virtual Heading Heading { get; set; }
        public virtual Writer Writer { get; set; }

    }
}
