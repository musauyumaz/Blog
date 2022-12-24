using Blog.Domain.Entities.Common;

namespace Blog.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<T> AddAsync(T model);
        Task<int> SaveAsync();
        T Remove(T model);
        T Update(T model);
        Task<T> RemoveAsync(int id);
    }
}
