using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sirius.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Infra.Data.Mapping
{
    /// <summary>
    /// mapeamento da tabela usuario
    /// </summary>
    public class UserMap : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.HasKey(k => k.Id); //definir chave primária

            builder.Property(p => p.Username)
                   .HasMaxLength(100) //Definir tamanho do campo
                   .IsRequired(); //Campo obrigatório (not null)
            builder.Property(p => p.Password)
                   .HasMaxLength(50)
                   .IsRequired();                    
        }
    }
}
