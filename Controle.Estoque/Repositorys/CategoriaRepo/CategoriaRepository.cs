using AutoMapper;
using Controle.Estoque.DTOs;
using Controle.Estoque.Models;
using Controle.Estoque.Models.Context;
using Microsoft.EntityFrameworkCore;

namespace Controle.Estoque.Repositorys.CategoriaRepo
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly MySQLContext _context;
        private IMapper _mapper;

        public CategoriaRepository(MySQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CategoriasDTO>> FindAll()
        {
            List<CategoriaDTO> categorias = await _context.Categorias.ToListAsync();
            return _mapper.Map<List<CategoriasDTO>>(categorias);
        }

        public async Task<CategoriasDTO> FindById(long id)
        {
            CategoriaDTO? categoria = await _context.Categorias.Where(c => c.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<CategoriasDTO>(categoria);
        }
        public async Task<CategoriasDTO> Create(CategoriasDTO categoriasDTO)
        {
            CategoriaDTO categoria = _mapper.Map<CategoriaDTO>(categoriasDTO);
            _context.Categorias.Add(categoria);
            await _context.SaveChangesAsync();
            return _mapper.Map<CategoriasDTO>(categoria);
        }
        public async Task<CategoriasDTO> Update(CategoriasDTO categoriasDTO)
        {
            CategoriaDTO categoria = _mapper.Map<CategoriaDTO>(categoriasDTO);
            _context.Categorias.Update(categoria);
            await _context.SaveChangesAsync();
            return _mapper.Map<CategoriasDTO>(categoria);
        }
    }
}
