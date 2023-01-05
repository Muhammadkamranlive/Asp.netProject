using RepositoryCourses.Domain.Repositories;
using RepositoryCourses.Models;
using RepositoryCourses.Services;

namespace RepositoryCourses.CourseServices
{
    public class TeacherService : GenericService<Teachers>, ITeacherSertvice
    {
        public TeacherService(IUnitOfWork unitOfWork, IGenericRepository<Teachers> repository) : base(unitOfWork, repository)
        {

        }
    }
}
