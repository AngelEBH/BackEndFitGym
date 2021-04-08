using Microsoft.EntityFrameworkCore.Migrations;

namespace BacFitGym.FuenteDatos.Migrations
{
    public partial class rutina : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id_Gimnasio",
                table: "TipoRutinas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "gimnasiosId_Gimnasio",
                table: "TipoRutinas",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TipoRutinas_gimnasiosId_Gimnasio",
                table: "TipoRutinas",
                column: "gimnasiosId_Gimnasio");

            migrationBuilder.AddForeignKey(
                name: "FK_TipoRutinas_Gimnasios_gimnasiosId_Gimnasio",
                table: "TipoRutinas",
                column: "gimnasiosId_Gimnasio",
                principalTable: "Gimnasios",
                principalColumn: "Id_Gimnasio",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TipoRutinas_Gimnasios_gimnasiosId_Gimnasio",
                table: "TipoRutinas");

            migrationBuilder.DropIndex(
                name: "IX_TipoRutinas_gimnasiosId_Gimnasio",
                table: "TipoRutinas");

            migrationBuilder.DropColumn(
                name: "Id_Gimnasio",
                table: "TipoRutinas");

            migrationBuilder.DropColumn(
                name: "gimnasiosId_Gimnasio",
                table: "TipoRutinas");
        }
    }
}
