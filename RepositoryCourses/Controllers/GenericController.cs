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
        public IService<T> _IService { get; set; }
        private readonly IMapper _mapper;

        public GenericController(IService<T> IService, IMapper mapper)
        {
            _IService = IService;
            _mapper = mapper;
        }
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var result = await _IService.GetAll();

                return Ok(result);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {

                var result = await _IService.GetById(id);
                return Ok(result);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPost]
        public async Task<IActionResult> CreateTeacher(TDTO EntityDTO)
        {
            try
            {

                await _IService.InsertAsync(_mapper.Map<T>(EntityDTO));
                await _IService.CompletedAsync();
                return Ok(EntityDTO);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        // [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpDelete]
        public async Task<IActionResult> DeleteTeacher(int id)
        {
            try
            {
                var result = await _IService.Delete(id);
                await _IService.CompletedAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPut]
        public async Task<IActionResult> UpdateTeacherProfile(TDTO EntityDTO)
        {
            try
            {
                _IService.Update(_mapper.Map<T>(EntityDTO));
                var res = await _IService.CompletedAsync();
                return Ok(res);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
