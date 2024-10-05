using Microsoft.EntityFrameworkCore;
using Datos.Model;

namespace Datos.Context
{
    internal class SpecialitiesContext : DbContext
    {
        internal DbSet<Specialities> Specialities { get; set; }

        internal SpecialitiesContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Nico;Database=tp2_net;Trusted_Connection=True;");
        }
    }
}
