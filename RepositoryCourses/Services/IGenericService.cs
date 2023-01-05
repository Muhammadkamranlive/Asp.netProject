using RepositoryCourses.Data_Access.DTOS;

namespace RepositoryCourses.Services
{
    public interface IGenericService<T> where T:class
    {

        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task<bool> Delete(int id);
        void Update(T entity);
        Task InsertAsync(T entity);
        Task<int> CompletedAsync();

    }

}
