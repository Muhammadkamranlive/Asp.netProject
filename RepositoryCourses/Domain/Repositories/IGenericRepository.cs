using System.Linq.Expressions;

namespace RepositoryCourses.Domain.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T?> Get(int id);
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate);
        Task Add(T entity);
        Task AddRange(IEnumerable<T> entities);
        Task<bool> Remove(int id);
        void RemoveRange(IEnumerable<T> entities);
        void Update(T entity);

    }
}
