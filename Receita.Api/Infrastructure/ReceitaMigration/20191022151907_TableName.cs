using Microsoft.EntityFrameworkCore.Migrations;

namespace Receita.Api.Infrastructure.ReceitaMigration
{
    public partial class TableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receita_Categoria_IdCategoria",
                table: "Receita");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Receita",
                table: "Receita");

            migrationBuilder.RenameTable(
                name: "Receita",
                newName: "Receitas");

            migrationBuilder.RenameIndex(
                name: "IX_Receita_IdCategoria",
                table: "Receitas",
                newName: "IX_Receitas_IdCategoria");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Receitas",
                table: "Receitas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Receitas_Categoria_IdCategoria",
                table: "Receitas",
                column: "IdCategoria",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receitas_Categoria_IdCategoria",
                table: "Receitas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Receitas",
                table: "Receitas");

            migrationBuilder.RenameTable(
                name: "Receitas",
                newName: "Receita");

            migrationBuilder.RenameIndex(
                name: "IX_Receitas_IdCategoria",
                table: "Receita",
                newName: "IX_Receita_IdCategoria");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Receita",
                table: "Receita",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Receita_Categoria_IdCategoria",
                table: "Receita",
                column: "IdCategoria",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
