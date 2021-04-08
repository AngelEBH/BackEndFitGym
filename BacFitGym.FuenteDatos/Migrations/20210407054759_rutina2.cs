using Microsoft.EntityFrameworkCore.Migrations;

namespace BacFitGym.FuenteDatos.Migrations
{
    public partial class rutina2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id_Gimnasio",
                table: "TipoRutinas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id_Gimnasio",
                table: "TipoRutinas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
