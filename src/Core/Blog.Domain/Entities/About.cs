using Blog.Domain.Entities.Common;
using Blog.Domain.Entities.Files;

namespace Blog.Domain.Entities
{
    public class About : BaseEntity
    {
        public string Detail { get; set; }

        public virtual ICollection<AboutImageFile> AboutImageFiles { get; set; }
    }
}
