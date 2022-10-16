using Controle.Estoque.DTOs;

namespace Controle.Estoque.Repositorys.TransportadoraRepo
{
    public interface ITransportadoraRepository
    {
        Task<IEnumerable<TransportadoraDTO>> FindAll();
        Task<TransportadoraDTO> FindById(long id);
        Task<TransportadoraDTO> Create(TransportadoraDTO transportadoraDTO);
        Task<TransportadoraDTO> Update(TransportadoraDTO transportadoraDTO);
    }
}
