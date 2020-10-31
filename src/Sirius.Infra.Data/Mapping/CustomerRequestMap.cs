using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sirius.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Infra.Data.Mapping
{
    public class CustomerRequestMap : IEntityTypeConfiguration<CustomerRequestEntity>
    {
        public void Configure(EntityTypeBuilder<CustomerRequestEntity> builder)
        {
            builder.HasKey(k => k.Id);
        }
    }
}
