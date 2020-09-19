using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sirius.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Infra.Data.Mapping
{
    public class SmartContractMap : IEntityTypeConfiguration<SmartContractEntity>
    {
        public void Configure(EntityTypeBuilder<SmartContractEntity> builder)
        {
            builder.HasKey(k => k.Id); //definir chave primária

            builder.Property(p => p.Title)
                   .HasMaxLength(255) //Definir tamanho do campo
                   .IsRequired(); //Campo obrigatório (not null)

            builder.Property(p => p.Description)
                   .HasMaxLength(600)
                   .IsRequired();

            builder.Property(p => p.TerminationCondition)
                   .HasMaxLength(400);

            builder.Property(p => p.Value)
                   .HasMaxLength(10);//.HasColumnType("2");

            builder.Property(p => p.AuthKey)
                   .HasMaxLength(255);

            builder.Property(p => p.CodePayment)
                   .HasMaxLength(255);

            builder.Property(p => p.ReasonTermination)
                   .HasMaxLength(400);
        }
    }
}
