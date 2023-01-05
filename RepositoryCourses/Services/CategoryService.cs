using RepositoryCourses.Domain.Repositories;
using RepositoryCourses.Models;

namespace RepositoryCourses.Services
{
    public class CategoryService : GenericService<Category>, ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepository<Category> _repository;
        public CategoryService(IUnitOfWork unitOfWork, IGenericRepository<Category> genericRepository) : base(unitOfWork, genericRepository)
        {
            _repository = genericRepository;
            _unitOfWork = unitOfWork;
        }
    }
}
