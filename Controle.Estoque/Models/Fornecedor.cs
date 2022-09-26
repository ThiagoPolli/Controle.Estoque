#nullable disable
using Controle.Estoque.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Controle.Estoque.Models
{
    public class Fornecedor : BaseEntity
    {
        [Required]
        [Column("fornecedor")]
        public string NomeFornecedor { get; set; }

        [Required]
        [Column("logradouro")]
        public string Logradouro { get; set; }

        [Required]
        [Column("bairro")]
        public string Bairro { get; set; }

        [Required]
        [Column("CEP")]
        public string Cep { get; set; }


        [Column("contato")]
        public string Contato { get; set; }

        [Required]
        [Column("CNPJ")]
        public string Cnpj { get; set; }

        [Required]
        [Column("inscricao")]
        public string Inscao { get; set; }

        [Required]
        [Column("telefone")]
        public string Telefone { get; set; }


        [Column("id_cidade")]
        public long IdCidade { get; set; }

        [ForeignKey("IdCidade")]
        public virtual Cidade Cidade { get; set; }
    }
}
