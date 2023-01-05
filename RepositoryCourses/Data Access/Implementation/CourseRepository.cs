using RepositoryCourses.Domain.Implementation;
using RepositoryCourses.Domain.Repositories;
using RepositoryCourses.Models;

namespace RepositoryCourses.Data_Access.Implementation
{
    public class CourseRepository : GenericRepository<Course>, ICourseRespository
    {
        public CourseRepository(CourseContext context) : base(context)
        {

        }
    }
}
