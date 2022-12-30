namespace Blog.Application.Abstractions.Storage
{
    public interface IStorageService : IStorage
    {
        string StorageName { get; }
    }
}
