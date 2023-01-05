using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryCourses.CourseServices;
using RepositoryCourses.Data_Access.DTOS;
using RepositoryCourses.Models;
using RepositoryCourses.Services;

namespace RepositoryCourses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<T,TDTO> : ControllerBase where T: class where TDTO : class

    {
        public IGenericService<T> _IService { get; set; }
        private readonly IMapper _mapper;

        public GenericController(IGenericService<T> IService, IMapper mapper)
        {
            _IService = IService;
            _mapper = mapper;
        }
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            
                var result = await _IService.GetAll();

                return Ok(result);
            
          
        }
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            

                var result = await _IService.GetById(id);
                return Ok(result);
            
           
        }
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPost]
        public async Task<IActionResult> CreateTeacher(TDTO EntityDTO)
        {
           

                await _IService.InsertAsync(_mapper.Map<T>(EntityDTO));
                await _IService.CompletedAsync();
                return Ok(EntityDTO);
           
        }
        // [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpDelete]
        public async Task<IActionResult> DeleteTeacher(int id)
        {
            
                var result = await _IService.Delete(id);
                await _IService.CompletedAsync();
                return Ok(result);
        }
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPut]
        public async Task<IActionResult> UpdateTeacherProfile(TDTO EntityDTO)
        {
        
                _IService.Update(_mapper.Map<T>(EntityDTO));
                var res = await _IService.CompletedAsync();
                return Ok(res);
        }
    }
}
