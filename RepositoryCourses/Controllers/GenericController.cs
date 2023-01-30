using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RepositoryCourses.Services.Interfaces;

namespace RepositoryCourses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<T, DTOENTITY> : ControllerBase where T : class where DTOENTITY : class

    {
        public IGenericService<T> _IService { get; set; }
        private readonly IMapper _mapper;

        public GenericController(IGenericService<T> IService, IMapper mapper)
        {
            _IService = IService;
            _mapper = mapper;
        }

        // [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            var data = await _IService.GetAll();
            var result = _mapper.Map<List<DTOENTITY>>(data);
            return Ok(result);


        }
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {


            var singleRecord = await _IService.GetById(id);
            var result = _mapper.Map<DTOENTITY>(singleRecord);
            return Ok(result);


        }
        // [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPost]
        public async Task<IActionResult> Create(DTOENTITY EntityDTO)
        {


            await _IService.InsertAsync(_mapper.Map<T>(EntityDTO));
            await _IService.CompletedAsync();
            return Ok(EntityDTO);

        }
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {

            var result = await _IService.Delete(id);
            await _IService.CompletedAsync();
            return Ok(result);
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPut]
        public async Task<IActionResult> Update(DTOENTITY EntityDTO)
        {

            _IService.Update(_mapper.Map<T>(EntityDTO));
            var res = await _IService.CompletedAsync();
            return Ok(res);
        }
    }
}
