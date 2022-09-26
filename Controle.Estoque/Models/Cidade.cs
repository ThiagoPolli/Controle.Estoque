#nullable disable
using Controle.Estoque.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Controle.Estoque.Models
{
    public class Cidade : BaseEntity
    {
        [Required]
        [Column("cidade")]
        public string NomeCidade { get; set; }

        [Required]
        [Column("uf")]
        public string UF { get; set; }
    }
}
