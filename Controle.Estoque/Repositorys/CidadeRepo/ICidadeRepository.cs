using Controle.Estoque.DTOs;

namespace Controle.Estoque.Repositorys.CidadeRepo
{
    public interface ICidadeRepository
    {
        Task<IEnumerable<CidadeDTO>> FindAll();
        Task<CidadeDTO> FindById(long id);
        Task<CidadeDTO> Create(CidadeDTO cidadeDTO);
        Task<CidadeDTO> Update(CidadeDTO cidadeDTO);
    }
}
