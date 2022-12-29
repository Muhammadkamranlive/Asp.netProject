using AutoMapper;
using RepositoryCourses.Data_Access.DTOS;
using RepositoryCourses.Models;

namespace RepositoryCourses.Helper
{
    public class HandleProfile : Profile
    {
        public HandleProfile()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<Teachers, TeachersDTO>().ReverseMap();
            CreateMap<Student, StudentDTO>().ReverseMap();
            CreateMap<Course, CourseDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Tag, TagDTO>().ReverseMap();
            CreateMap<Cover, CoverDTO>().ReverseMap();
        }
    }
}
