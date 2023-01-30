namespace RepositoryCourses.Services.Implementation;
using RepositoryCourses.Domain.Repositories;
using RepositoryCourses.Models;
using RepositoryCourses.Services.Interfaces;

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
