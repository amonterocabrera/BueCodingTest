using GestionEmpleados.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEmpleados.Context
{
    public class EmpleadosDbContext : DbContext
    {
        public EmpleadosDbContext( DbContextOptions<EmpleadosDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source =.\SQLEXPRESS;Initial Catalog=Empleados;Integrated Security=true");
            }
        }

        public DbSet<Empleados> Empleados { get; set; }
    }
}
