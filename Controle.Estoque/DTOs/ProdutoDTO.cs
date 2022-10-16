using Controle.Estoque.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Controle.Estoque.DTOs
{
    public class ProdutoDTO
    {
        public long Id { get; set; }
        public string Nome { get; set; }      
        public string Descricao { get; set; }
        public double Peso { get; set; }
        public int QtdMin { get; set; }
        public decimal PrecoUnitario { get; set; }
        public long IdCategoria { get; set; }
        public long IdFornecedor { get; set; }
        public virtual CategoriaDTO? Categoria { get; set; }
        public virtual FornecedorDTO? Fornecedor { get; set; }
    }
}
