using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PRO203_Unidad_1.DataAccess.Entities;
using System.Configuration;

namespace PRO203_Unidad_1.DataAccess
{
    public class AppDbContext : DbContext
    {
        public DbSet<Videojuego> Videojuegos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["ConnStringVideojuegos"].ConnectionString);
        }
    }
}
