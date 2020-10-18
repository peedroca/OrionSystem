using Microsoft.EntityFrameworkCore;
using Sirius.Domain.Entities;

namespace Sirius.Infra.Data.Contexts
{
    /// <summary>
    /// Contexto do banco de dados
    /// </summary>
    public class SiriusDbContext : DbContext
    {
        public SiriusDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated(); //garante que o banco foi criado
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configuração de Chaves Estrangeiras

            modelBuilder.Entity<SmartContractEntity>()
                        .HasOne(s => s.CompanyEntity)
                        .WithMany(g => g.SmartContracts)
                        .HasForeignKey(s => s.CurrentCompanyEntityId);
        }

        /// <summary>
        /// Tabela Usuários
        /// </summary>
        public DbSet<UserEntity> Users { get; set; } //Para definir as tabelas do banco

        /// <summary>
        /// tabela Smart Contract
        /// </summary>
        public DbSet<SmartContractEntity> SmartContracts { get; set; }

        /// <summary>
        /// Tabela Empresas
        /// </summary>
        public DbSet<CompanyEntity> Companies { get; set; }

        /// <summary>
        /// Tabela Cliente
        /// </summary>
            
        public DbSet<CustomerEntity> Customers{ get; set; }
    }
}
