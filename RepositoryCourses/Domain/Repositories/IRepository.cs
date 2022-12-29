using System.Linq.Expressions;

namespace RepositoryCourses.Domain.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task <T?> Get(int id);
        Task <IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> Find(Expression<Func<T,bool>> predicate);
        Task Add(T entity);
        Task AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        void Update(T entity);
        
    }
}
