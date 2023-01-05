using RepositoryCourses.Domain.Implementation;
using RepositoryCourses.Domain.Repositories;
using RepositoryCourses.Models;

namespace RepositoryCourses.Data_Access.Implementation
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(CourseContext context) : base(context)
        {

        }
    }
}
