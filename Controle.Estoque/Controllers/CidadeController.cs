using Controle.Estoque.DTOs;
using Controle.Estoque.Repositorys.CidadeRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Controle.Estoque.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CidadeController : ControllerBase
    {
        private readonly ICidadeRepository _repository;

        public CidadeController(ICidadeRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<ActionResult<CidadeDTO>> FindAll()
        {
            var cidades = await _repository.FindAll();
            return Ok(cidades);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CidadeDTO>> FindById(long id)
        {
            var cidade = await _repository.FindById(id);
            if(cidade == null) return NotFound("Id "+ id + " não encontrado");
            return Ok(cidade);
        }

        [HttpPost]
        public async Task<ActionResult<CidadeDTO>> Create([FromBody] CidadeDTO cidadeDTO)
        {
            if(cidadeDTO == null) return BadRequest();
            var cidade = await _repository.Create(cidadeDTO);
            return Ok(cidade);
        }
        [HttpPut]
        public async Task<ActionResult<CidadeDTO>> Update([FromBody] CidadeDTO cidadeDTO)
        {
            if (cidadeDTO == null) return BadRequest();
            var cidade = await _repository.Update(cidadeDTO);
            return Ok(cidade);
        }


    }
}
