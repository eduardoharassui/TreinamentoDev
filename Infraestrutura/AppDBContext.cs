using Dominio.Modelos;
using Infraestrutura.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura
{
    public class AppDBContext : DbContext
    {
        public DbSet<VendaModel> Vendas { get; set; }
        public DbSet<ProdutoModel> Produtos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            string connectionString = "";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new VendaMapeamento());
            modelBuilder.ApplyConfiguration(new ProdutoMapeamento());
            base.OnModelCreating(modelBuilder);
        }
    }
}
