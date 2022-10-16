using Controle.Estoque.Models;

namespace Controle.Estoque.DTOs
{
    public class FornecedorDTO
    {
       
        public long Id { get; set; }
        public string NomeFornecedor { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Contato { get; set; }
        public string Cnpj { get; set; }
        public string Inscao { get; set; }
        public string Telefone { get; set; }
        public long IdCidade { get; set; }
        public CidadeDTO? Cidade { get; set; }
    }
}
