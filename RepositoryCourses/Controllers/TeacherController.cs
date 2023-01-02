using Microsoft.AspNetCore.Mvc;
using RepositoryCourses.CourseServices;
using RepositoryCourses.Data_Access.DTOS;

namespace RepositoryCourses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        public ITeacherSertvice _teacherService { get; set; }
        public TeacherController(ITeacherSertvice teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var result = await _teacherService.GetAllTeachers();
                return Ok(result);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {

                var result = await _teacherService.GetById(id);
                return Ok(result);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateTeacher(TeachersDTO teachersDTO)
        {
            try
            {
                await _teacherService.InsertAsync(teachersDTO);
                await _teacherService.CompletedAsync();
                return Ok(teachersDTO);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public async Task<IActionResult>  DeleteTeacher(int id)
        {
            try
            {
                var result= await _teacherService.Delete(id);
                            await _teacherService.CompletedAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTeacherProfile(TeachersDTO teachersDTO)
        {
            try
            {
                _teacherService.Update(teachersDTO);
                var res=await _teacherService.CompletedAsync();
                return Ok(res);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
