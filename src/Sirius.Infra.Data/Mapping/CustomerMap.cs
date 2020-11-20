using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sirius.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Infra.Data.Mapping
{
    /// <summary>
    /// mapeamento da tabela cliente
    /// </summary>
    public class CustomerMap : IEntityTypeConfiguration<CustomerEntity>
    {
        public void Configure(EntityTypeBuilder<CustomerEntity> builder)
        {
            builder.HasKey(k => k.Id);

            builder.Property(p => p.FirstName)
                   .HasMaxLength(100)
                   .IsRequired();// Campoobrigatorio

            builder.Property(p => p.LastName)
                   .HasMaxLength(100)
                   .IsRequired();
        }         
    }
}
 