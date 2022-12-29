using RepositoryCourses.Domain.Repositories;

namespace RepositoryCourses.Data_Access.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CourseContext _courseContext;
        public UnitOfWork(CourseContext context)
        {
            _courseContext = context;
            Course = new CourseRepository(_courseContext);
            Teacher = new TeacherRepository(_courseContext);
            Tags = new TagRepository(_courseContext);
            Category = new CategoryRepository(_courseContext);
            Cover = new CoverRepository(_courseContext);
            Student = new StudentRepository(_courseContext);
            User = new UserRepository(_courseContext);
        }
        public ICourseRespository Course { get; private set; }

        public ITeacherRepository Teacher { get; private set; }

        public ICoverRepository Cover { get; private set; }

        public ICategoryRepository Category { get; private set; }

        public IStudentRepository Student { get; private set; }

        public ITagsRepository Tags { get; private set; }

        public IUserRepository User { get; private set; }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            _courseContext.Dispose();
        }

        public async Task<int> Save()
        {
            return await _courseContext.SaveChangesAsync();
        }
    }
}
