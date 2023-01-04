using AutoMapper;
using RepositoryCourses.Domain.Repositories;
using RepositoryCourses.Models;

namespace RepositoryCourses.Services
{
    public class StudentService:GenericService<Student>,IStudentService
    {
        public StudentService(IUnitOfWork unitOfWork, IMapper mapper, IRepository<Student> repository):base(unitOfWork,mapper,repository)
        {

        }
    }
}
