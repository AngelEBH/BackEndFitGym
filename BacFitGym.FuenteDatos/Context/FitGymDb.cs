using BacFitGym.Dominio.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BacFitGym.FuenteDatos.Context
{
    public class FitGymDb : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Gimnasios> Gimnasios { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Afiliados> Afiliados { get; set; }
        public DbSet<RutinasGimnasios> RutinaGimnasios { get; set; }
        public DbSet<Rutinas> Rutinas { get; set; }
        public DbSet<TipoRutinas> TipoRutinas { get; set; }
        public DbSet<AfiliadoRutinas> AfiliadoRutinas { get; set; }
        public DbSet<Entrenadores> Entrenadores { get; set; }
        public DbSet<Precios> Precios { get; set; }



        public FitGymDb(DbContextOptions<FitGymDb> options) : base(options)
        { }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
