using RepositoryCourses.Domain.Implementation;
using RepositoryCourses.Domain.Repositories;
using RepositoryCourses.Models;

namespace RepositoryCourses.Data_Access.Implementation
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(CourseContext context) : base(context)
        {

        }
    }
}
