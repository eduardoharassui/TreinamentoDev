using Dominio.Modelos;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Infraestrutura.Mapping
{
    public class VendaMapeamento : IEntityTypeConfiguration<VendaModel>
    {
        public void Configure(EntityTypeBuilder<VendaModel> builder)
        {
            builder.ToTable("PDV_VD");
            builder.Property(p => p.CdEmpresa).HasColumnName("CD_EMP");
            builder.Property(p => p.CdFilial).HasColumnName("CD_FILIAL");
            builder.Property(p => p.CdVenda).HasColumnName("CD_VD");
            builder.Property(p => p.CdCli).HasColumnName("CD_CLI");

            builder.HasKey(p => new { p.CdEmpresa, p.CdFilial, p.CdVenda });
        }
    }
}