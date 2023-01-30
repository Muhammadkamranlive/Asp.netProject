using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RepositoryCourses.Data_Access.DTOS;
using RepositoryCourses.Models;
using RepositoryCourses.Services.Interfaces;

namespace RepositoryCourses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : GenericController<Student, StudentDTO>
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
        public StudentController(IStudentService studentService, IMapper mapper) : base(studentService, mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }
    }
}
