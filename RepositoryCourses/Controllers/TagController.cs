using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RepositoryCourses.Data_Access.DTOS;
using RepositoryCourses.Models;
using RepositoryCourses.Services;

namespace RepositoryCourses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : GenericController<Tag, TagDTO>
    {
        private readonly ITagService _tagService;
        private readonly IMapper _mapper;

        public TagController(ITagService tagService, IMapper mapper) : base(tagService, mapper)
        {
            _tagService = tagService;
            _mapper = mapper;
        }
    }
}
