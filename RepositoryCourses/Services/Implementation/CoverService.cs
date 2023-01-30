namespace RepositoryCourses.Services.Implementation;
using RepositoryCourses.Domain.Repositories;
using RepositoryCourses.Models;
using RepositoryCourses.Services.Interfaces;

public class CoverService : GenericService<Cover>, ICoverService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IGenericRepository<Cover> _repository;
    public CoverService(IUnitOfWork unitOfWork, IGenericRepository<Cover> genericRepository) : base(unitOfWork, genericRepository)
    {
        _repository = genericRepository;
        _unitOfWork = unitOfWork;
    }

}
