using BacFitGym.Dominio.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BacFitGym.FuenteDatos.Context
{
    public class FitGymDb : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public FitGymDb(DbContextOptions<FitGymDb> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
