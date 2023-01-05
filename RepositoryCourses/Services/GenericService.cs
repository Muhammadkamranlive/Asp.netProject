using AutoMapper;
using Microsoft.VisualBasic;
using RepositoryCourses.Domain.Repositories;

namespace RepositoryCourses.Services
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<T> _repository;
        private readonly IMapper _mapper;
        public GenericService(IUnitOfWork unitOfWork, IMapper mapper,IRepository<T> repository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;   
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
           var record= await _repository.Get(id);
            if (record == null)
            {
                throw new Exception($"{typeof(T).Name} ({id}) not found");
            }

            return record;
        }

        public async Task InsertAsync(T entity)
        {
           await  _repository.Add(entity);
           await _unitOfWork.Save();
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
            
        }
    }
}
