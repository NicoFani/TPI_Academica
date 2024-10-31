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
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-EJOQVME\\SQLEXPRESS;Initial Catalog=tp2_net;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}
