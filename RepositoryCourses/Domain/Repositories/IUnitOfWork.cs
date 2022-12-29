namespace RepositoryCourses.Domain.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        public ICourseRespository Course { get; }
        public ITeacherRepository Teacher { get; }
        public ICoverRepository Cover { get; }
        public ICategoryRepository Category { get; }
        public IStudentRepository Student { get; }
        public ITagsRepository Tags { get; }
        public IUserRepository User { get; }
        Task<int> Save();
    }
}
