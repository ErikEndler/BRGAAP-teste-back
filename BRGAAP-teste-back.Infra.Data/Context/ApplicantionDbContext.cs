using BRGAAP_teste_back.Domain.Entities;
using BRGAAP_teste_back.Infra.Data.EntitiesConfiguration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRGAAP_teste_back.Infra.Data.Context
{
    public class ApplicantionDbContext : DbContext
    {
        public ApplicantionDbContext(DbContextOptions options):base(options) { }
        
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<NotaFiscal> NotaFiscal { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
        }

    }
}
