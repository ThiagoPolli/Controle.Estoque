﻿using Microsoft.EntityFrameworkCore;

namespace Controle.Estoque.Models.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() { }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }

    }
}