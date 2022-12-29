using RepositoryCourses.Domain.Implementation;
using RepositoryCourses.Domain.Repositories;
using RepositoryCourses.Models;

namespace RepositoryCourses.Data_Access.Implementation
{
    public class TeacherRepository:Repository<Teachers>,ITeacherRepository
    {
        public TeacherRepository(CourseContext context) : base(context)
        {

        }
    }
}
