using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BacFitGym.FuenteDatos.Migrations
{
    public partial class dbCreacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoRutinas",
                columns: table => new
                {
                    Id_TipoRutina = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoRutinas", x => x.Id_TipoRutina);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 50, nullable: false),
                    CorreoElectronico = table.Column<string>(nullable: false),
                    Password = table.Column<string>(maxLength: 200, nullable: false),
                    RolesId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rutinas",
                columns: table => new
                {
                    Id_Rutina = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Imagen = table.Column<byte[]>(nullable: true),
                    Instrupcion = table.Column<string>(nullable: false),
                    Id_TipoRutina = table.Column<int>(nullable: false),
                    TipoRutinasId_TipoRutina = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rutinas", x => x.Id_Rutina);
                    table.ForeignKey(
                        name: "FK_Rutinas_TipoRutinas_TipoRutinasId_TipoRutina",
                        column: x => x.TipoRutinasId_TipoRutina,
                        principalTable: "TipoRutinas",
                        principalColumn: "Id_TipoRutina",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Gimnasios",
                columns: table => new
                {
                    Id_Gimnasio = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NommbreGimnasio = table.Column<string>(nullable: false),
                    HoraInicial = table.Column<DateTime>(nullable: false),
                    HoraFinal = table.Column<DateTime>(nullable: false),
                    Contacto = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: false),
                    logo = table.Column<byte[]>(nullable: true),
                    InformacionDetalle = table.Column<byte[]>(nullable: true),
                    Dueño = table.Column<string>(nullable: true),
                    slogan = table.Column<string>(nullable: true),
                    Id_Usuario = table.Column<int>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gimnasios", x => x.Id_Gimnasio);
                    table.ForeignKey(
                        name: "FK_Gimnasios_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Entrenadores",
                columns: table => new
                {
                    Id_Entrenador = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEntrenador = table.Column<string>(nullable: false),
                    Telefono = table.Column<int>(nullable: false),
                    Id_Gimnasio = table.Column<int>(nullable: false),
                    gimnasiosId_Gimnasio = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrenadores", x => x.Id_Entrenador);
                    table.ForeignKey(
                        name: "FK_Entrenadores_Gimnasios_gimnasiosId_Gimnasio",
                        column: x => x.gimnasiosId_Gimnasio,
                        principalTable: "Gimnasios",
                        principalColumn: "Id_Gimnasio",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Precios",
                columns: table => new
                {
                    Id_Precio = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(nullable: false),
                    Valor = table.Column<int>(nullable: false),
                    IdGimnasio = table.Column<int>(nullable: false),
                    GimnasiosId_Gimnasio = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Precios", x => x.Id_Precio);
                    table.ForeignKey(
                        name: "FK_Precios_Gimnasios_GimnasiosId_Gimnasio",
                        column: x => x.GimnasiosId_Gimnasio,
                        principalTable: "Gimnasios",
                        principalColumn: "Id_Gimnasio",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RutinaGimnasios",
                columns: table => new
                {
                    Id_RutinaGimnasio = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Gimnasio = table.Column<int>(nullable: false),
                    Id_Rutina = table.Column<int>(nullable: false),
                    RutinasId_Rutina = table.Column<int>(nullable: true),
                    GimnasiosId_Gimnasio = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RutinaGimnasios", x => x.Id_RutinaGimnasio);
                    table.ForeignKey(
                        name: "FK_RutinaGimnasios_Gimnasios_GimnasiosId_Gimnasio",
                        column: x => x.GimnasiosId_Gimnasio,
                        principalTable: "Gimnasios",
                        principalColumn: "Id_Gimnasio",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RutinaGimnasios_Rutinas_RutinasId_Rutina",
                        column: x => x.RutinasId_Rutina,
                        principalTable: "Rutinas",
                        principalColumn: "Id_Rutina",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Afiliados",
                columns: table => new
                {
                    Id_Afiliado = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Gimnasio = table.Column<int>(nullable: false),
                    Id_Usuario = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Apellido = table.Column<string>(nullable: false),
                    Edad = table.Column<string>(nullable: false),
                    Peso = table.Column<string>(nullable: true),
                    Estatura = table.Column<string>(nullable: true),
                    Id_Entrenador = table.Column<int>(nullable: false),
                    UsuariosId = table.Column<int>(nullable: true),
                    GimnasiosId_Gimnasio = table.Column<int>(nullable: true),
                    EntrenadoresId_Entrenador = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Afiliados", x => x.Id_Afiliado);
                    table.ForeignKey(
                        name: "FK_Afiliados_Entrenadores_EntrenadoresId_Entrenador",
                        column: x => x.EntrenadoresId_Entrenador,
                        principalTable: "Entrenadores",
                        principalColumn: "Id_Entrenador",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Afiliados_Gimnasios_GimnasiosId_Gimnasio",
                        column: x => x.GimnasiosId_Gimnasio,
                        principalTable: "Gimnasios",
                        principalColumn: "Id_Gimnasio",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Afiliados_Usuarios_UsuariosId",
                        column: x => x.UsuariosId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AfiliadoRutinas",
                columns: table => new
                {
                    Id_RutinaAfiliafo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Afiliado = table.Column<int>(nullable: false),
                    Id_Rutina = table.Column<int>(nullable: false),
                    afiliadosId_Afiliado = table.Column<int>(nullable: true),
                    RutinasId_Rutina = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AfiliadoRutinas", x => x.Id_RutinaAfiliafo);
                    table.ForeignKey(
                        name: "FK_AfiliadoRutinas_Rutinas_RutinasId_Rutina",
                        column: x => x.RutinasId_Rutina,
                        principalTable: "Rutinas",
                        principalColumn: "Id_Rutina",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AfiliadoRutinas_Afiliados_afiliadosId_Afiliado",
                        column: x => x.afiliadosId_Afiliado,
                        principalTable: "Afiliados",
                        principalColumn: "Id_Afiliado",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AfiliadoRutinas_RutinasId_Rutina",
                table: "AfiliadoRutinas",
                column: "RutinasId_Rutina");

            migrationBuilder.CreateIndex(
                name: "IX_AfiliadoRutinas_afiliadosId_Afiliado",
                table: "AfiliadoRutinas",
                column: "afiliadosId_Afiliado");

            migrationBuilder.CreateIndex(
                name: "IX_Afiliados_EntrenadoresId_Entrenador",
                table: "Afiliados",
                column: "EntrenadoresId_Entrenador");

            migrationBuilder.CreateIndex(
                name: "IX_Afiliados_GimnasiosId_Gimnasio",
                table: "Afiliados",
                column: "GimnasiosId_Gimnasio");

            migrationBuilder.CreateIndex(
                name: "IX_Afiliados_UsuariosId",
                table: "Afiliados",
                column: "UsuariosId");

            migrationBuilder.CreateIndex(
                name: "IX_Entrenadores_gimnasiosId_Gimnasio",
                table: "Entrenadores",
                column: "gimnasiosId_Gimnasio");

            migrationBuilder.CreateIndex(
                name: "IX_Gimnasios_UsuarioId",
                table: "Gimnasios",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Precios_GimnasiosId_Gimnasio",
                table: "Precios",
                column: "GimnasiosId_Gimnasio");

            migrationBuilder.CreateIndex(
                name: "IX_RutinaGimnasios_GimnasiosId_Gimnasio",
                table: "RutinaGimnasios",
                column: "GimnasiosId_Gimnasio");

            migrationBuilder.CreateIndex(
                name: "IX_RutinaGimnasios_RutinasId_Rutina",
                table: "RutinaGimnasios",
                column: "RutinasId_Rutina");

            migrationBuilder.CreateIndex(
                name: "IX_Rutinas_TipoRutinasId_TipoRutina",
                table: "Rutinas",
                column: "TipoRutinasId_TipoRutina");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_RolesId",
                table: "Usuarios",
                column: "RolesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AfiliadoRutinas");

            migrationBuilder.DropTable(
                name: "Precios");

            migrationBuilder.DropTable(
                name: "RutinaGimnasios");

            migrationBuilder.DropTable(
                name: "Afiliados");

            migrationBuilder.DropTable(
                name: "Rutinas");

            migrationBuilder.DropTable(
                name: "Entrenadores");

            migrationBuilder.DropTable(
                name: "TipoRutinas");

            migrationBuilder.DropTable(
                name: "Gimnasios");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
