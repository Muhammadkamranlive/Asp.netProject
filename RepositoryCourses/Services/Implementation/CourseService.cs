namespace RepositoryCourses.Services.Implementation;
using RepositoryCourses.Domain.Repositories;
using RepositoryCourses.Models;
using RepositoryCourses.Services.Interfaces;

public class CourseService : GenericService<Course>, ICourseService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IGenericRepository<Course> _repository;
    public CourseService(IUnitOfWork unitOfWork, IGenericRepository<Course> genericRepository) : base(unitOfWork, genericRepository)
    {
        _repository = genericRepository;
        _unitOfWork = unitOfWork;
    }
}
