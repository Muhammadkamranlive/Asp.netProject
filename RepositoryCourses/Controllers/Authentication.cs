using Microsoft.AspNetCore.Mvc;
using RepositoryCourses.Data_Access.DTOS.Authentications;
using RepositoryCourses.Services.Authentication;

namespace RepositoryCourses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Authentication : ControllerBase
    {
        public IAuthService _authService { get; set; }
        public Authentication(IAuthService authService)
        {
            _authService = authService;
        }


        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] UserRegisterDTOS userRegisterDTOS)
        {
            try
            {
                var result = await _authService.Register(userRegisterDTOS);
                return Ok(result);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }


        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginDTO userLoginDTO)
        {
            try
            {
                var result = await _authService.Login(userLoginDTO);
                return Ok(result);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

    }
}
