using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Model;

namespace Datos.Context
{
    public class ComissionsContext : DbContext
    {
        public DbSet<Comissions> Comissions { get; set; } // Changed 'internal' to 'public'
        public ComissionsContext() // Changed 'internal' to 'public'
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=NICO;Initial Catalog=tp2_net;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comissions>()
                .ToTable("comisiones") // Especifica el nombre de la tabla
                .HasKey(c => c.IdCommission); // Define 'IdCommission' como clave primaria
        }
    }
}

