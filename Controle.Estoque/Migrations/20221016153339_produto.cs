using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Controle.Estoque.Migrations
{
    public partial class produto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cidade = table.Column<double>(type: "float", nullable: false),
                    qtdminimo = table.Column<int>(type: "int", nullable: false),
                    precounitario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    id_categoria = table.Column<long>(type: "bigint", nullable: false),
                    id_fornecedor = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.id);
                    table.ForeignKey(
                        name: "FK_Produto_Categorias_id_categoria",
                        column: x => x.id_categoria,
                        principalTable: "Categorias",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produto_Fornecedor_id_fornecedor",
                        column: x => x.id_fornecedor,
                        principalTable: "Fornecedor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produto_id_categoria",
                table: "Produto",
                column: "id_categoria");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_id_fornecedor",
                table: "Produto",
                column: "id_fornecedor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produto");
        }
    }
}
