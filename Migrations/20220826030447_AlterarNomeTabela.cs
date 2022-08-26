using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MediatRSample.Migrations
{
    public partial class AlterarNomeTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_pessoa",
                table: "pessoa");

            migrationBuilder.RenameTable(
                name: "pessoa",
                newName: "Pessoa");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pessoa",
                table: "Pessoa",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Pessoa",
                table: "Pessoa");

            migrationBuilder.RenameTable(
                name: "Pessoa",
                newName: "pessoa");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pessoa",
                table: "pessoa",
                column: "Id");
        }
    }
}
