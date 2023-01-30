using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RepositoryCourses.Data_Access.DTOS;
using RepositoryCourses.Models;
using RepositoryCourses.Services.Interfaces;

namespace RepositoryCourses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoverController : GenericController<Cover, CoverDTO>
    {
        private readonly ICoverService _coverService;
        private readonly IMapper mapper;
        public CoverController(ICoverService coverService, IMapper mapper) : base(coverService, mapper)
        {
            _coverService = coverService;
            this.mapper = mapper;
        }
    }
}
