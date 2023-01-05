using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RepositoryCourses.Services;

namespace RepositoryCourses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<T, TDTO> : ControllerBase where T : class where TDTO : class

    {
        public IGenericService<T> _IService { get; set; }
        private readonly IMapper _mapper;

        public GenericController(IGenericService<T> IService, IMapper mapper)
        {
            _IService = IService;
            _mapper = mapper;
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            var data = await _IService.GetAll();
            var result = _mapper.Map<List<TDTO>>(data);
            return Ok(result);


        }
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {


            var singleRecord = await _IService.GetById(id);
            var result = _mapper.Map<TDTO>(singleRecord);
            return Ok(result);


        }
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public async Task<IActionResult> Create(TDTO EntityDTO)
        {


            await _IService.InsertAsync(_mapper.Map<T>(EntityDTO));
            await _IService.CompletedAsync();
            return Ok(EntityDTO);

        }
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {

            var result = await _IService.Delete(id);
            await _IService.CompletedAsync();
            return Ok(result);
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [HttpPut]
        public async Task<IActionResult> Update(TDTO EntityDTO)
        {

            _IService.Update(_mapper.Map<T>(EntityDTO));
            var res = await _IService.CompletedAsync();
            return Ok(res);
        }
    }
}
