using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoEscolaPeDeChumbo.Migrations
{
    public partial class Aluno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TreinamentoID",
                table: "Treinamento",
                newName: "treinamentoID");

            migrationBuilder.RenameColumn(
                name: "AlunoID",
                table: "Aluno",
                newName: "alunoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "treinamentoID",
                table: "Treinamento",
                newName: "TreinamentoID");

            migrationBuilder.RenameColumn(
                name: "alunoID",
                table: "Aluno",
                newName: "AlunoID");
        }
    }
}
