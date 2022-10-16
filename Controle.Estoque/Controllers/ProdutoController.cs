using Controle.Estoque.DTOs;
using Controle.Estoque.Repositorys.ProdutoRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Controle.Estoque.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private IProdutoRepository _repository;

        public ProdutoController(IProdutoRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProdutoDTO>>> FindAll()
        {
            var produtos = await _repository.FindAll();
            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProdutoDTO>> FindById(long id)
        {
            var produtos = await _repository.FindById(id);
            if (produtos == null) return NotFound("ID do produto nao encontrado : "+ id);
            return Ok(produtos);
        }

        [HttpPost]
        public async Task<ActionResult<ProdutoDTO>> Create([FromBody] ProdutoDTO produtoDTO)
        {
            if (produtoDTO == null) return BadRequest();
            var produto = await _repository.Create(produtoDTO);
            return Ok(produto);
        }

        [HttpPut]
        public async Task<ActionResult<ProdutoDTO>> Update([FromBody] ProdutoDTO produtoDTO)
        {
            if(produtoDTO == null) return BadRequest();
            var produto = await _repository.Update(produtoDTO);
            return Ok(produto);
        }

    }
}
