using Controle.Estoque.DTOs;

namespace Controle.Estoque.Repositorys.FornecedorRepo
{
    public interface IFornecedorRepository
    {
        Task<IEnumerable<FornecedorDTO>> FindAll();
        Task<FornecedorDTO> FindById(long id);
        Task<FornecedorDTO> Create(FornecedorDTO fornecedorDTO);
        Task<FornecedorDTO> Update(FornecedorDTO fornecedorDTO);


    }
}
