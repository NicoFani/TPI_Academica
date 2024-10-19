using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Model;
using Microsoft.EntityFrameworkCore;

namespace Datos.Context
{
    internal class CoursesContext: DbContext
    {
        internal DbSet<Courses> Courses { get; set; }
        internal CoursesContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Nico;Database=tp2_net;Trusted_Connection=True;");
        }
    }
}
