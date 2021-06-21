using Microsoft.EntityFrameworkCore;
using RegistroOrdenesDetalle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroOrdenesDetalle.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Suplidores> Suplidores { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Ordenes> Ordenes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source = Data/Ordenes.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Suplidores>().HasData(new Suplidores
            {
                SuplidorId = 1,
                Nombre = "Bill"
            });

            modelBuilder.Entity<Productos>().HasData(new Productos
            {
                ProductosId = 1,
                Descripcion = "Tomates",
                Costo = 50,
                Inventario = 30,
                SuplidorId = 1
            });
        }
    }
}
