using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sirius.Domain.Entities;

namespace Sirius.Infra.Data.Mapping
{
    /// <summary>
    /// Mapeamento da entidade Empresa
    /// </summary>
    public class CompanyMap : IEntityTypeConfiguration<CompanyEntity>
    {
        public void Configure(EntityTypeBuilder<CompanyEntity> builder)
        {
            builder.HasKey(k => k.Id);
        }
    }
}
