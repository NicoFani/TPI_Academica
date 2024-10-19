using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Model;

namespace Datos.Context
{
    internal class TeacherCoursesContext: DbContext
    {
        internal DbSet<TeacherCourses> TeacherCourses { get; set; }
        internal TeacherCoursesContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Nico;Database=tp2_net;Trusted_Connection=True;");
        }
    }
}
