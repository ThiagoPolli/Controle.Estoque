#nullable disable
using Controle.Estoque.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Controle.Estoque.Models
{
    public class Categoria : BaseEntity
    {
        [Required]
        [Column("categoria")]
        public string NomeCategoria { get; set; }
    }
}
