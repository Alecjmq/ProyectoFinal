using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProjectContext : DbContext
    {
        public DbSet<Students> Students { get; set; }
        public DbSet<Products> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server= DESKTOP-H1OH6CU; Database=ProjectDBB;User Id=sa;Password=12345aA");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Students>().HasData(
                new Students { StudentId = 1, StudentNombre = "Lucia", StudentApellido = "Rodriguez", StudentFacultad = "Ingenieria", StudentPrograma = "Quimica" }
             
                );

            modelBuilder.Entity<Products>().HasData(
                new Products { ProductoCodigo = 3, ProductoCategoria = "Electrónica", ProductoMarca = "Apple", ProductoDescripcion = "Celular Inteligente", ProductoPrecio = 100 }
                );
        }
    }
}