﻿using Microsoft.EntityFrameworkCore;
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
            optionsBuilder.UseSqlServer("Server=Nico;Database=tp2_net;Trusted_Connection=True;");
        }
    }
}