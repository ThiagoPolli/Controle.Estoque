using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Controle.Estoque.Migrations
{
    public partial class produtoalterarPeso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "cidade",
                table: "Produto",
                newName: "peso");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "peso",
                table: "Produto",
                newName: "cidade");
        }
    }
}
