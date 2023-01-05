using RepositoryCourses.Domain.Implementation;
using RepositoryCourses.Domain.Repositories;
using RepositoryCourses.Models;

namespace RepositoryCourses.Data_Access.Implementation
{
    public class UserRepository:GenericRepository<User>,IUserRepository
    {
        public UserRepository(CourseContext context):base(context)
        {

        }
    }
}
