namespace Blog.Domain.Entities.Files
{
    public class AboutImageFile : File
    {
        public virtual ICollection<About> Abouts { get; set; }
    }
}
