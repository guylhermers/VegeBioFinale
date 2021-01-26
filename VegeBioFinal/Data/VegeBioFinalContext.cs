using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VegeBioFinal.Models;

namespace VegeBioFinal.Data
{
    public class VegeBioFinalContext : DbContext
    {
        public VegeBioFinalContext (DbContextOptions<VegeBioFinalContext> options)
            : base(options)
        {
        }

        public DbSet<VegeBioFinal.Models.Produto> Produto { get; set; }
        public DbSet<VegeBioFinal.Models.Cabaz> Cabaz { get; set; }
        public DbSet<VegeBioFinal.Models.Cliente> Cliente { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().ToTable("Product");
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
        }
    }
}
