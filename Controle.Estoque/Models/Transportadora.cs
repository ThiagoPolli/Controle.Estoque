
using Controle.Estoque.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Controle.Estoque.Models
{
    public class Transportadora : BaseEntity
    {
        [Required]
        [Column("nome")]
        public string Nome { get; set; }

        [Required]
        [Column("endereco")]
        public string Endereco { get; set; }

        [Required]
        [Column("bairro")]
        public string Bairro { get; set; }

        [Required]
        [Column("cep")]
        public string Cep { get; set; }

        [Required]
        [Column("cnpj")]
        public string Cnpj { get; set; }

        [Required]
        [Column("inscricao")]
        public string Inscricao { get; set; }

        [Required]
        [Column("contato")]
        public string Contato { get; set; }

        [Required]
        [Column("telefone")]
        public string Telefone { get; set; }

        [Column("id_cidade")]
        public long IdCidade { get; set; }

        [ForeignKey("IdCidade")]
        public virtual Cidade Cidade { get; set; }


    }
}
