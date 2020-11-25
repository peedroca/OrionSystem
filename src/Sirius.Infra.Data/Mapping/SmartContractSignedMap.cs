using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sirius.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Infra.Data.Mapping
{
    public class SmartContractSignedMap : IEntityTypeConfiguration<SmartContractEntity>
    {
        public void Configure(EntityTypeBuilder<SmartContractEntity> builder)
        {
            builder.HasKey(k => k.Id);
        }
    }
}
