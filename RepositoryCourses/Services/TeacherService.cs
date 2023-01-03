using AutoMapper;
using RepositoryCourses.Data_Access.DTOS;
using RepositoryCourses.Domain.Repositories;
using RepositoryCourses.Models;
using RepositoryCourses.Services;

namespace RepositoryCourses.CourseServices
{
    public class TeacherService : GenericService<Teachers>,ITeacherSertvice
    {
        public TeacherService(IUnitOfWork unitOfWork,IMapper mapper,IRepository<Teachers> repository):base(unitOfWork,mapper,repository)
        {

        }   
    }
}
