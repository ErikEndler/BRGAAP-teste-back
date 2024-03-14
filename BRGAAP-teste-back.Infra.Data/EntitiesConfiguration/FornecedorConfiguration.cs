using BRGAAP_teste_back.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRGAAP_teste_back.Infra.Data.EntitiesConfiguration
{
    public class FornecedorConfiguration : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(k => k.Nome).IsRequired().HasMaxLength(250);
        }
    }
}
