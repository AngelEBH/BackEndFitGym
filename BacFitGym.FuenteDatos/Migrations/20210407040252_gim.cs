using Microsoft.EntityFrameworkCore.Migrations;

namespace BacFitGym.FuenteDatos.Migrations
{
    public partial class gim : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Instrupcion",
                table: "Rutinas");

            migrationBuilder.AddColumn<string>(
                name: "Logo",
                table: "TipoRutinas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Instruccion",
                table: "Rutinas",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Logo",
                table: "TipoRutinas");

            migrationBuilder.DropColumn(
                name: "Instruccion",
                table: "Rutinas");

            migrationBuilder.AddColumn<string>(
                name: "Instrupcion",
                table: "Rutinas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
