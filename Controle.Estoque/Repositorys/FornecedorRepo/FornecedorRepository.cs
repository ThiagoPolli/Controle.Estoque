using AutoMapper;
using Controle.Estoque.DTOs;
using Controle.Estoque.Models;
using Controle.Estoque.Models.Context;
using Microsoft.EntityFrameworkCore;

namespace Controle.Estoque.Repositorys.FornecedorRepo
{
    public class FornecedorRepository : IFornecedorRepository
    {

        private readonly MySQLContext _context;
        private IMapper _mapper;

        public FornecedorRepository(MySQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<FornecedorDTO>> FindAll()
        {
          List<Fornecedor> fornecedores = await _context.Fornecedor.ToListAsync();
            return _mapper.Map<List<FornecedorDTO>>(fornecedores);
        }

        public async Task<FornecedorDTO> FindById(long id)
        {
            Fornecedor? fornecedor = await _context.Fornecedor.Where(f => f.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<FornecedorDTO>(fornecedor);
        }
        public async Task<FornecedorDTO> Create(FornecedorDTO fornecedorDTO)
        {
            Fornecedor fornecedor = _mapper.Map<Fornecedor>(fornecedorDTO);
            _context.Fornecedor.Add(fornecedor);
            await _context.SaveChangesAsync();
            return _mapper.Map<FornecedorDTO>(fornecedor);

        }
        public async Task<FornecedorDTO> Update(FornecedorDTO fornecedorDTO)
        {
            Fornecedor fornecedor = _mapper.Map<Fornecedor>(fornecedorDTO);
            _context.Fornecedor.Update(fornecedor);
            await _context.SaveChangesAsync();
            return _mapper.Map<FornecedorDTO>(fornecedor);

        }
    }
}
