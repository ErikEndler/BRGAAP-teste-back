using BRGAAP_teste_back.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BRGAAP_teste_back.Infra.Data.EntitiesConfiguration
{
    public class NotaFiscalConfiguration : IEntityTypeConfiguration<NotaFiscal>
    {
        public void Configure(EntityTypeBuilder<NotaFiscal> builder)
        {
            builder.HasKey(k => k.Id);
            builder.HasOne(k => k.Cliente)
                .WithMany(k => k.NotasFiscais)
                .HasForeignKey(k => k.Cliente.Id)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(k => k.Fornecedor)
                .WithMany(k => k.NotasFiscais)
                .HasForeignKey(k => k.Fornecedor.Id)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
