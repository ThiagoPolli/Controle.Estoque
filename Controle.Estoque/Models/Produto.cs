#nullable disable
using Controle.Estoque.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Controle.Estoque.Models
{
    public class Produto : BaseEntity
    {
        [Required]
        [Column("nome")]
        public string Nome { get; set; }
        [Required]
        [Column("descricao")]
        public string Descricao { get; set; }
        
        [Column("peso")]
        public double Peso { get; set; }
        [Required]
        [Column("qtdminimo")]
        public int QtdMin { get; set; }
        [Required]
        [Column("precounitario")]
        public decimal PrecoUnitario { get; set; }

        [Required]
        [Column("id_categoria")]
        public long IdCategoria { get; set; }

        [Required]
        [Column("id_fornecedor")]
        public long IdFornecedor { get; set; }

        [ForeignKey("IdCategoria")]
        public virtual CategoriaDTO Categoria { get; set; }

        [ForeignKey("IdFornecedor")]
        public virtual Fornecedor Fornecedor { get; set; }
    }
}
