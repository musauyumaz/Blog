namespace Blog.Domain.Entities.Files
{
    public class WriterImageFile : File
    {
        public virtual ICollection<Writer> Writers { get; set; }
    }
}
