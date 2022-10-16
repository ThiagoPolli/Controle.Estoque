using AutoMapper;
using Controle.Estoque.DTOs;
using Controle.Estoque.Models;
using Controle.Estoque.Models.Context;
using Microsoft.EntityFrameworkCore;

namespace Controle.Estoque.Repositorys.ProdutoRepo
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly MySQLContext _context;
        private IMapper _mapper;

        public ProdutoRepository(MySQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProdutoDTO>> FindAll()
        {
            List<Produto> produtos = await _context.Produto
                .Include(c => c.Categoria)
                .Include(c => c.Fornecedor)
                .Include(c => c.Fornecedor.Cidade).ToListAsync();

            return _mapper.Map<List<ProdutoDTO>>(produtos);
        }

        public async Task<ProdutoDTO> FindById(long id)
        {
            Produto? produto = await _context.Produto.Where(p => p.Id == id)
                .Include(c => c.Categoria)
                .Include(c => c.Fornecedor)
                .Include(c => c.Fornecedor.Cidade)
                .FirstOrDefaultAsync();
            return _mapper.Map<ProdutoDTO>(produto);
        }
        public async Task<ProdutoDTO> Create(ProdutoDTO produtoDTO)
        {
            Produto produto = _mapper.Map<Produto>(produtoDTO);
            _context.Add(produto);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProdutoDTO>(produto);
        }

        public async Task<ProdutoDTO> Update(ProdutoDTO produtoDTO)
        {
            Produto produto = _mapper.Map<Produto>(produtoDTO);
            _context.Update(produto);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProdutoDTO>(produto);
        }
    }
}
