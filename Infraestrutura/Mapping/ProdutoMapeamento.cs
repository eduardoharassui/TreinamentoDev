using Dominio.Modelos;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Infraestrutura.Mapping
{
    public class ProdutoMapeamento : IEntityTypeConfiguration<ProdutoModel>
    {
        public void Configure(EntityTypeBuilder<ProdutoModel> builder)
        {
            builder.ToTable("EST_PROD");
            builder.Property(p => p.CdEmpresa).HasColumnName("CD_EMP");
            builder.Property(p => p.Descricao).HasColumnName("DS_PROD");
            builder.Property(p => p.Codigo).HasColumnName("CD_PROD");

            builder.HasKey(p => new {p.CdEmpresa,p.Codigo });
        }
    }
}