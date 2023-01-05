using RepositoryCourses.Domain.Repositories;

namespace RepositoryCourses.Services
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepository<T> _repository;

        public GenericService(IUnitOfWork unitOfWork, IGenericRepository<T> repository)
        {
            _unitOfWork = unitOfWork;

            _repository = repository;
        }
        public async Task<int> CompletedAsync()
        {
            return await _unitOfWork.Save();
        }

        public async Task<bool> Delete(int id)
        {
            await _repository.Remove(id);
            return true;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<T> GetById(int id)
        {
            var record = await _repository.Get(id);
            if (record == null)
            {
                throw new Exception($"{typeof(T).Name} ({id}) not found");
            }

            return record;
        }

        public async Task InsertAsync(T entity)
        {
            await _repository.Add(entity);
            await _unitOfWork.Save();
        }

        public void Update(T entity)
        {
            _repository.Update(entity);

        }
    }
}
