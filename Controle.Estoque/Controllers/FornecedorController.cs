using Controle.Estoque.DTOs;
using Controle.Estoque.Repositorys.FornecedorRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Controle.Estoque.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedorController : ControllerBase
    {
        private IFornecedorRepository _repository;

        public FornecedorController(IFornecedorRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<ActionResult<FornecedorDTO>> FindAll()
        {
            var fornecedores = await _repository.FindAll();
            return Ok(fornecedores);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FornecedorDTO>> FindById(long id)
        {
            var fornecedores = await _repository.FindById(id);
            if(fornecedores == null) return NotFound("Id do Fornecedor não Encontrado : "+ id);
            return Ok(fornecedores);
        }

        [HttpPost]
        public async Task<ActionResult<FornecedorDTO>> Create([FromBody] FornecedorDTO fornecedorDTO)
        {
            if(fornecedorDTO == null) return BadRequest();
            var fornecedor = await _repository.Create(fornecedorDTO);
            return Ok(fornecedor);
        }

        [HttpPut]
        public async Task<ActionResult<FornecedorDTO>> Update([FromBody] FornecedorDTO fornecedorDTO)
        {
            if (fornecedorDTO == null) return BadRequest();
            var fornecedor = await _repository.Update(fornecedorDTO);
            return Ok(fornecedor);
        }
    }
}
