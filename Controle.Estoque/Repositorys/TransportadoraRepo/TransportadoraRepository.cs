using AutoMapper;
using Controle.Estoque.DTOs;
using Controle.Estoque.Models;
using Controle.Estoque.Models.Context;
using Microsoft.EntityFrameworkCore;

namespace Controle.Estoque.Repositorys.TransportadoraRepo
{
    public class TransportadoraRepository : ITransportadoraRepository
    {
        private readonly MySQLContext _context;
        private IMapper _mapper;

        public TransportadoraRepository(MySQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TransportadoraDTO>> FindAll()
        {
            List<Transportadora> transportadoras = await _context.Transportadora
                .Include(c => c.Cidade).ToListAsync();
            return _mapper.Map<List<TransportadoraDTO>>(transportadoras);
        }

        public async Task<TransportadoraDTO> FindById(long id)
        {
            Transportadora? transportadora = await _context.Transportadora.Where(t => t.Id == id)
                 .Include(c => c.Cidade)
                 .FirstOrDefaultAsync();
            return _mapper.Map<TransportadoraDTO>(transportadora);
        }
        public async Task<TransportadoraDTO> Create(TransportadoraDTO transportadoraDTO)
        {
            Transportadora transportadora = _mapper.Map<Transportadora>(transportadoraDTO);
            _context.Add(transportadora);
            await _context.SaveChangesAsync();
            return _mapper.Map<TransportadoraDTO>(transportadora);
        }


        public async Task<TransportadoraDTO> Update(TransportadoraDTO transportadoraDTO)
        {
            Transportadora transportadora = _mapper.Map<Transportadora>(transportadoraDTO);
            _context.Update(transportadora);
            await _context.SaveChangesAsync();
            return _mapper.Map<TransportadoraDTO>(transportadora);
        }
    }
}
