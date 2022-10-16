#nullable disable
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Controle.Estoque.Models;

namespace Controle.Estoque.DTOs
{
    public class TransportadoraDTO
    {
        public long Id { get; set; }
        public string Nome { get; set; }

        public string Endereco { get; set; }

        public string Bairro { get; set; }

        public string Cep { get; set; }

        public string Cnpj { get; set; }

        public string Inscricao { get; set; }

        public string Contato { get; set; }

        public string Telefone { get; set; }

        public long IdCidade { get; set; }

        public Cidade? Cidade { get; set; }
    }
}
