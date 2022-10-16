using Controle.Estoque.DTOs;

namespace Controle.Estoque.Repositorys.ProdutoRepo
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<ProdutoDTO>> FindAll();
        Task<ProdutoDTO> FindById(long id);
        Task<ProdutoDTO> Create(ProdutoDTO produtoDTO);
        Task<ProdutoDTO> Update(ProdutoDTO produtoDTO);
    }
}
