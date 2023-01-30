using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RepositoryCourses.Data_Access.DTOS;
using RepositoryCourses.Models;
using RepositoryCourses.Services.Interfaces;

namespace RepositoryCourses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : GenericController<Category, CategoryDTO>
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        public CategoryController(ICategoryService categoryService, IMapper mapper) : base(categoryService, mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
    }
}
