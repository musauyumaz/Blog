using Blog.Domain.Entities.Common;

namespace Blog.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll(bool tracking = false);
        Task<T> GetByIdAsync(int id, bool tracking = false);
    }
}
