﻿// <auto-generated />
using System;
using BacFitGym.FuenteDatos.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BacFitGym.FuenteDatos.Migrations
{
    [DbContext(typeof(FitGymDb))]
    partial class FitGymDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BacFitGym.Dominio.Models.AfiliadoRutinas", b =>
                {
                    b.Property<int>("Id_RutinaAfiliafo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Id_Afiliado")
                        .HasColumnType("int");

                    b.Property<int>("Id_Rutina")
                        .HasColumnType("int");

                    b.Property<int?>("RutinasId_Rutina")
                        .HasColumnType("int");

                    b.Property<int?>("afiliadosId_Afiliado")
                        .HasColumnType("int");

                    b.HasKey("Id_RutinaAfiliafo");

                    b.HasIndex("RutinasId_Rutina");

                    b.HasIndex("afiliadosId_Afiliado");

                    b.ToTable("AfiliadoRutinas");
                });

            modelBuilder.Entity("BacFitGym.Dominio.Models.Afiliados", b =>
                {
                    b.Property<int>("Id_Afiliado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Edad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EntrenadoresId_Entrenador")
                        .HasColumnType("int");

                    b.Property<string>("Estatura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GimnasiosId_Gimnasio")
                        .HasColumnType("int");

                    b.Property<int>("Id_Entrenador")
                        .HasColumnType("int");

                    b.Property<int>("Id_Gimnasio")
                        .HasColumnType("int");

                    b.Property<int>("Id_Usuario")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Peso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsuariosId")
                        .HasColumnType("int");

                    b.HasKey("Id_Afiliado");

                    b.HasIndex("EntrenadoresId_Entrenador");

                    b.HasIndex("GimnasiosId_Gimnasio");

                    b.HasIndex("UsuariosId");

                    b.ToTable("Afiliados");
                });

            modelBuilder.Entity("BacFitGym.Dominio.Models.Entrenadores", b =>
                {
                    b.Property<int>("Id_Entrenador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Id_Gimnasio")
                        .HasColumnType("int");

                    b.Property<string>("NombreEntrenador")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.Property<int?>("gimnasiosId_Gimnasio")
                        .HasColumnType("int");

                    b.HasKey("Id_Entrenador");

                    b.HasIndex("gimnasiosId_Gimnasio");

                    b.ToTable("Entrenadores");
                });

            modelBuilder.Entity("BacFitGym.Dominio.Models.Gimnasios", b =>
                {
                    b.Property<int>("Id_Gimnasio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contacto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dueño")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HoraFinal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HoraInicial")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Usuario")
                        .HasColumnType("int");

                    b.Property<string>("InformacionDetalle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NommbreGimnasio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<string>("logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("slogan")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Gimnasio");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Gimnasios");
                });

            modelBuilder.Entity("BacFitGym.Dominio.Models.Pagos", b =>
                {
                    b.Property<int>("Id_Pago")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Afiliado")
                        .HasColumnType("int");

                    b.Property<int>("Id_Gimnasio")
                        .HasColumnType("int");

                    b.Property<string>("Monto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("afiliadosId_Afiliado")
                        .HasColumnType("int");

                    b.Property<int?>("gimnasiosId_Gimnasio")
                        .HasColumnType("int");

                    b.HasKey("Id_Pago");

                    b.HasIndex("afiliadosId_Afiliado");

                    b.HasIndex("gimnasiosId_Gimnasio");

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("BacFitGym.Dominio.Models.Precios", b =>
                {
                    b.Property<int>("Id_Precio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GimnasiosId_Gimnasio")
                        .HasColumnType("int");

                    b.Property<int>("IdGimnasio")
                        .HasColumnType("int");

                    b.Property<int>("Valor")
                        .HasColumnType("int");

                    b.HasKey("Id_Precio");

                    b.HasIndex("GimnasiosId_Gimnasio");

                    b.ToTable("Precios");
                });

            modelBuilder.Entity("BacFitGym.Dominio.Models.Roles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("BacFitGym.Dominio.Models.Rutinas", b =>
                {
                    b.Property<int>("Id_Rutina")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_TipoRutina")
                        .HasColumnType("int");

                    b.Property<byte[]>("Imagen")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Instruccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TipoRutinasId_TipoRutina")
                        .HasColumnType("int");

                    b.HasKey("Id_Rutina");

                    b.HasIndex("TipoRutinasId_TipoRutina");

                    b.ToTable("Rutinas");
                });

            modelBuilder.Entity("BacFitGym.Dominio.Models.RutinasGimnasios", b =>
                {
                    b.Property<int>("Id_RutinaGimnasio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("GimnasiosId_Gimnasio")
                        .HasColumnType("int");

                    b.Property<int>("Id_Gimnasio")
                        .HasColumnType("int");

                    b.Property<int>("Id_Rutina")
                        .HasColumnType("int");

                    b.Property<int?>("RutinasId_Rutina")
                        .HasColumnType("int");

                    b.HasKey("Id_RutinaGimnasio");

                    b.HasIndex("GimnasiosId_Gimnasio");

                    b.HasIndex("RutinasId_Rutina");

                    b.ToTable("RutinaGimnasios");
                });

            modelBuilder.Entity("BacFitGym.Dominio.Models.TipoRutinas", b =>
                {
                    b.Property<int>("Id_TipoRutina")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Gimnasio")
                        .HasColumnType("int");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("gimnasiosId_Gimnasio")
                        .HasColumnType("int");

                    b.HasKey("Id_TipoRutina");

                    b.HasIndex("gimnasiosId_Gimnasio");

                    b.ToTable("TipoRutinas");
                });

            modelBuilder.Entity("BacFitGym.Dominio.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CorreoElectronico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("RolesId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("RolesId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("BacFitGym.Dominio.Models.AfiliadoRutinas", b =>
                {
                    b.HasOne("BacFitGym.Dominio.Models.Rutinas", "Rutinas")
                        .WithMany("AfiliadoRutinas")
                        .HasForeignKey("RutinasId_Rutina");

                    b.HasOne("BacFitGym.Dominio.Models.Afiliados", "afiliados")
                        .WithMany("AfiliadoRutinas")
                        .HasForeignKey("afiliadosId_Afiliado");
                });

            modelBuilder.Entity("BacFitGym.Dominio.Models.Afiliados", b =>
                {
                    b.HasOne("BacFitGym.Dominio.Models.Entrenadores", "Entrenadores")
                        .WithMany("Afiliados")
                        .HasForeignKey("EntrenadoresId_Entrenador");

                    b.HasOne("BacFitGym.Dominio.Models.Gimnasios", "Gimnasios")
                        .WithMany("Afiliados")
                        .HasForeignKey("GimnasiosId_Gimnasio");

                    b.HasOne("BacFitGym.Dominio.Models.Usuario", "Usuarios")
                        .WithMany("afiliados")
                        .HasForeignKey("UsuariosId");
                });

            modelBuilder.Entity("BacFitGym.Dominio.Models.Entrenadores", b =>
                {
                    b.HasOne("BacFitGym.Dominio.Models.Gimnasios", "gimnasios")
                        .WithMany("Entrenadores")
                        .HasForeignKey("gimnasiosId_Gimnasio");
                });

            modelBuilder.Entity("BacFitGym.Dominio.Models.Gimnasios", b =>
                {
                    b.HasOne("BacFitGym.Dominio.Models.Usuario", "Usuario")
                        .WithMany("gimnasios")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("BacFitGym.Dominio.Models.Pagos", b =>
                {
                    b.HasOne("BacFitGym.Dominio.Models.Afiliados", "afiliados")
                        .WithMany("Pagos")
                        .HasForeignKey("afiliadosId_Afiliado");

                    b.HasOne("BacFitGym.Dominio.Models.Gimnasios", "gimnasios")
                        .WithMany("Pagos")
                        .HasForeignKey("gimnasiosId_Gimnasio");
                });

            modelBuilder.Entity("BacFitGym.Dominio.Models.Precios", b =>
                {
                    b.HasOne("BacFitGym.Dominio.Models.Gimnasios", "Gimnasios")
                        .WithMany("Precios")
                        .HasForeignKey("GimnasiosId_Gimnasio");
                });

            modelBuilder.Entity("BacFitGym.Dominio.Models.Rutinas", b =>
                {
                    b.HasOne("BacFitGym.Dominio.Models.TipoRutinas", "TipoRutinas")
                        .WithMany("Rutinas")
                        .HasForeignKey("TipoRutinasId_TipoRutina");
                });

            modelBuilder.Entity("BacFitGym.Dominio.Models.RutinasGimnasios", b =>
                {
                    b.HasOne("BacFitGym.Dominio.Models.Gimnasios", "Gimnasios")
                        .WithMany("RutinasGimnasios")
                        .HasForeignKey("GimnasiosId_Gimnasio");

                    b.HasOne("BacFitGym.Dominio.Models.Rutinas", "Rutinas")
                        .WithMany("rutinasGimnasios")
                        .HasForeignKey("RutinasId_Rutina");
                });

            modelBuilder.Entity("BacFitGym.Dominio.Models.TipoRutinas", b =>
                {
                    b.HasOne("BacFitGym.Dominio.Models.Gimnasios", "gimnasios")
                        .WithMany("tipoRutinas")
                        .HasForeignKey("gimnasiosId_Gimnasio");
                });

            modelBuilder.Entity("BacFitGym.Dominio.Models.Usuario", b =>
                {
                    b.HasOne("BacFitGym.Dominio.Models.Roles", "Roles")
                        .WithMany("Usuario")
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
