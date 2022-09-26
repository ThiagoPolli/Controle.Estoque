using Controle.Estoque.DTOs;

namespace Controle.Estoque.Repositorys.CategoriaRepo
{
    public interface ICategoriaRepository
    {
        Task<IEnumerable<CategoriasDTO>> FindAll();
        Task<CategoriasDTO> FindById(long id);
        Task<CategoriasDTO> Create(CategoriasDTO categoriasDTO);
        Task<CategoriasDTO> Update(CategoriasDTO categoriasDTO);
    }
}
