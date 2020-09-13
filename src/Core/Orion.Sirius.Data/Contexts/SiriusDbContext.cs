using Microsoft.EntityFrameworkCore;
using Orion.Sirius.Data.Mapping;
using Orion.Sirius.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orion.Sirius.Data.Contexts
{
    /// <summary>
    /// Contexto do banco de dados Sirius
    /// </summary>
    public class SiriusDbContext : DbContext
    {
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="options"></param>
        public SiriusDbContext(DbContextOptions options) 
            : base(options)
        {
            Database.EnsureCreated();
        }

        /// <summary>
        /// Tabela Clientes.
        /// </summary>
        public DbSet<CostumerEntity> Costumers { get; set; }

        /// <summary>
        /// Tabela Contatos
        /// </summary>
        public DbSet<ContactEntity> Contacts { get; set; }

        /// <summary>
        /// Configuração das Criações da Tabela.
        /// </summary>
        /// <param name="modelBuilder">Use a parameter modelBuilder of type <see cref="ModelBuilder"/> to configure domain classes</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CostumerMap());
            modelBuilder.ApplyConfiguration(new ContactMap());
        }
    }
}
