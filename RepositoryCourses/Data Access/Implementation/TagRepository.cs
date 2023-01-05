using RepositoryCourses.Domain.Implementation;
using RepositoryCourses.Domain.Repositories;
using RepositoryCourses.Models;

namespace RepositoryCourses.Data_Access.Implementation
{
    public class TagRepository : GenericRepository<Tag>, ITagsRepository
    {
        public TagRepository(CourseContext context) : base(context)
        {

        }
    }
}
