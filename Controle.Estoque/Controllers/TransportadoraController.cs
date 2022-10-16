using Controle.Estoque.DTOs;
using Controle.Estoque.Repositorys.TransportadoraRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Controle.Estoque.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransportadoraController : ControllerBase
    {
        private ITransportadoraRepository _repository;

        public TransportadoraController(ITransportadoraRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TransportadoraDTO>>> FindAlll()
        {
            var transportadoras = await _repository.FindAll();
            return Ok(transportadoras);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TransportadoraDTO>> FindById(long id)
        {
            var transportadora = await _repository.FindById(id);
            if(transportadora == null) return NotFound("ID da transportadora nao encontrado : "+ id);
            return Ok(transportadora);
        }

        [HttpPost]
        public async Task<ActionResult<TransportadoraDTO>> Create([FromBody] TransportadoraDTO transportadoraDTO)
        {
            if (transportadoraDTO == null) return BadRequest();
            var transportadora = await _repository.Create(transportadoraDTO);
            return Ok(transportadora);
        }

        [HttpPut]
        public async Task<ActionResult<TransportadoraDTO>> Update([FromBody] TransportadoraDTO transportadoraDTO)
        {
            if(transportadoraDTO == null) return BadRequest();
            var transportadora = await _repository.Update(transportadoraDTO);
            return Ok(transportadora);
        }
    }
}
