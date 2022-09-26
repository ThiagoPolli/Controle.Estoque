using Controle.Estoque.DTOs;
using Controle.Estoque.Repositorys.CategoriaRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Controle.Estoque.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private ICategoriaRepository _repository;

        public CategoriaController(ICategoriaRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<ActionResult<CategoriasDTO>> FindAll()
        {
            var categorias = await _repository.FindAll();
            return Ok(categorias);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CategoriasDTO>> FindById(long id)
        {
            var categorias = await _repository.FindById(id);
            if(categorias == null) return NotFound("ID "+ id + " Não encontrado!");

            return Ok(categorias);
        }
        [HttpPost]
        public async Task<ActionResult<CategoriasDTO>> Create([FromBody] CategoriasDTO categoriasDTO)
        {
            if (categoriasDTO == null) return BadRequest();
            var categoria = await _repository.Create(categoriasDTO);
            return Ok(categoria);
        }

        [HttpPut]
        public async Task<ActionResult<CategoriasDTO>> Update([FromBody] CategoriasDTO categoriasDTO)
        {
            if (categoriasDTO == null) return BadRequest();
            var categoria = await _repository.Update(categoriasDTO);
            return Ok(categoria);
        }
    }
}
