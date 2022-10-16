using Microsoft.EntityFrameworkCore;

namespace Controle.Estoque.Models.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() { }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<CategoriaDTO> Categorias { get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Transportadora> Transportadora { get; set; }

    }
}
