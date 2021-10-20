using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoEscolaPeDeChumbo.Migrations
{
    public partial class novo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    FuncionarioID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dtAmissao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SalBruto = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.FuncionarioID);
                });

            migrationBuilder.CreateTable(
                name: "Treinamento",
                columns: table => new
                {
                    TreinamentoID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TipoTreinamento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DtInicio = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treinamento", x => x.TreinamentoID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcionario");

            migrationBuilder.DropTable(
                name: "Treinamento");
        }
    }
}
