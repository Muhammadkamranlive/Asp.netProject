using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RepositoryCourses.Data_Access.DTOS;
using RepositoryCourses.Models;
using RepositoryCourses.Services;

namespace RepositoryCourses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : GenericController<Course, CourseDTO>
    {
        private readonly ICourseService _courseService;
        private readonly IMapper _mapper;
        public CourseController(ICourseService courseService, IMapper mapper) : base(courseService, mapper)
        {
            _courseService = courseService;
            _mapper = mapper;

        }
    }
}
