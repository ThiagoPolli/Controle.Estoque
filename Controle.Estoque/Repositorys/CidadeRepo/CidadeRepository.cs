using AutoMapper;
using Controle.Estoque.DTOs;
using Controle.Estoque.Models;
using Controle.Estoque.Models.Context;
using Microsoft.EntityFrameworkCore;

namespace Controle.Estoque.Repositorys.CidadeRepo
{
    public class CidadeRepository : ICidadeRepository
    {
        private readonly MySQLContext _context;
        private IMapper _mapper;

        public CidadeRepository(MySQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CidadeDTO>> FindAll()
        {
            List<Cidade> cidades = await _context.Cidade.ToListAsync();
            return _mapper.Map<List<CidadeDTO>>(cidades);

        }

        public async Task<CidadeDTO> FindById(long id)
        {
            Cidade? cidade = await _context.Cidade.Where(c => c.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<CidadeDTO>(cidade);
        }
        public async Task<CidadeDTO> Create(CidadeDTO cidadeDTO)
        {
            Cidade cidade = _mapper.Map<Cidade>(cidadeDTO);
            _context.Cidade.Add(cidade);
            await _context.SaveChangesAsync();
            return _mapper.Map<CidadeDTO>(cidade);
        }


        public async Task<CidadeDTO> Update(CidadeDTO cidadeDTO)
        {
            Cidade cidade = _mapper.Map<Cidade>(cidadeDTO);
            _context.Cidade.Update(cidade);
            await _context.SaveChangesAsync();
            return _mapper.Map<CidadeDTO>(cidade);
        }
    }
}
