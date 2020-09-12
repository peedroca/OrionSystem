using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Orion.Sirius.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orion.Sirius.Data.Mapping
{
    /// <summary>
    /// Mapeamento do Contato
    /// </summary>
    public class ContactMap : IEntityTypeConfiguration<ContactEntity>
    {
        /// <summary>
        /// Configuração
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<ContactEntity> builder)
        {
            builder.ToTable("tbl_contact");
            
            builder.HasKey(k => k.Code);

            builder.Property(p => p.Code)
                .HasColumnName("Id");
        }
    }
}
