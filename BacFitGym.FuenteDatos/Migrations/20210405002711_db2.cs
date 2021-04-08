using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BacFitGym.FuenteDatos.Migrations
{
    public partial class db2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    Id_Pago = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(nullable: false),
                    Monto = table.Column<string>(nullable: true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Id_Gimnasio = table.Column<int>(nullable: false),
                    Id_Afiliado = table.Column<int>(nullable: false),
                    gimnasiosId_Gimnasio = table.Column<int>(nullable: true),
                    afiliadosId_Afiliado = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.Id_Pago);
                    table.ForeignKey(
                        name: "FK_Pagos_Afiliados_afiliadosId_Afiliado",
                        column: x => x.afiliadosId_Afiliado,
                        principalTable: "Afiliados",
                        principalColumn: "Id_Afiliado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pagos_Gimnasios_gimnasiosId_Gimnasio",
                        column: x => x.gimnasiosId_Gimnasio,
                        principalTable: "Gimnasios",
                        principalColumn: "Id_Gimnasio",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_afiliadosId_Afiliado",
                table: "Pagos",
                column: "afiliadosId_Afiliado");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_gimnasiosId_Gimnasio",
                table: "Pagos",
                column: "gimnasiosId_Gimnasio");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pagos");
        }
    }
}
