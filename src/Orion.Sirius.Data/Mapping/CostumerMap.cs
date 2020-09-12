using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Orion.Sirius.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orion.Sirius.Data.Mapping
{
    internal class CostumerMap : IEntityTypeConfiguration<CostumerEntity>
    {
        public void Configure(EntityTypeBuilder<CostumerEntity> builder)
        {
            builder.ToTable("tbl_costumers")
                   .HasKey(k => k.Id);

            builder.Property(p => p.Name)
                   .HasMaxLength(255)
                   .IsRequired();
        }
    }
}
