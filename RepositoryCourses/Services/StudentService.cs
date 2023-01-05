using RepositoryCourses.Domain.Repositories;
using RepositoryCourses.Models;

namespace RepositoryCourses.Services
{
    public class StudentService : GenericService<Student>, IStudentService
    {
        public StudentService(IUnitOfWork unitOfWork, IGenericRepository<Student> repository) : base(unitOfWork, repository)
        {

        }
    }
}
