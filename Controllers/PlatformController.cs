using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PlatformService.Dtos;
using platfromServices.Data;
using platfromServices.Models;

namespace platfromServices.Controllers
{
    [Route("Api/[controller]")]
    [ApiController]

    public class PlatformController : ControllerBase
    {
        private IPlatformRepo _repository;
        private IMapper _mapper;

        public PlatformController(IPlatformRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<IEnumerable<platformReadDto>> GetPlatforms()
        {
            var result = _mapper.Map<List<platformReadDto>>(_repository.GetAll());
            return Ok(result);
        }

        [HttpGet("{id}" , Name ="GetPlatfromById")]
        public ActionResult<platformReadDto> GetPlatfromById(int id)
        {
            var result = _repository.GetById(id);
            if (result is null)
                return NotFound();
            return Ok(_mapper.Map<platformReadDto>(result));
        }
        [HttpPost]

        public ActionResult <platformReadDto> Create (PlatformCreateDto request)
        {
            var platform = _mapper.Map<Platform>(request);            
            _repository.createPlatform(platform);
            _repository.SaveChanges();
            var platformReadDto = _mapper.Map<platformReadDto>(platform);
            return  CreatedAtRoute(nameof(GetPlatfromById),new {id= platformReadDto.Id},platformReadDto);
        }
    }

}