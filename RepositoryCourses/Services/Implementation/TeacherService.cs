using RepositoryCourses.Domain.Repositories;
using RepositoryCourses.Models;
using RepositoryCourses.Services.Interfaces;

namespace RepositoryCourses.Services.Implementation
{
    public class TeacherService : GenericService<Teachers>, ITeacherSertvice
    {
        public TeacherService(IUnitOfWork unitOfWork, IGenericRepository<Teachers> repository) : base(unitOfWork, repository)
        {

        }
    }
}
