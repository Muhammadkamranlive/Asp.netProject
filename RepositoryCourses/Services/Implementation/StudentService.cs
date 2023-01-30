namespace RepositoryCourses.Services.Implementation;
using RepositoryCourses.Domain.Repositories;
using RepositoryCourses.Models;
using RepositoryCourses.Services.Interfaces;

public class StudentService : GenericService<Student>, IStudentService
{
    public StudentService(IUnitOfWork unitOfWork, IGenericRepository<Student> repository) : base(unitOfWork, repository)
    {

    }
}
