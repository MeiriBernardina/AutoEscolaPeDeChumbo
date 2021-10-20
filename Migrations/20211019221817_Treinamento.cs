using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoEscolaPeDeChumbo.Migrations
{
    public partial class Treinamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Treinamento",
                table: "Treinamento");

            migrationBuilder.DropColumn(
                name: "treinamentoID",
                table: "Treinamento");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Treinamento",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Treinamento",
                table: "Treinamento",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Treinamento",
                table: "Treinamento");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Treinamento");

            migrationBuilder.AddColumn<string>(
                name: "treinamentoID",
                table: "Treinamento",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Treinamento",
                table: "Treinamento",
                column: "treinamentoID");
        }
    }
}
