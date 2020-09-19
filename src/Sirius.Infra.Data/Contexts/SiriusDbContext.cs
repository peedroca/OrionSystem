using Microsoft.EntityFrameworkCore;
using Sirius.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

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

        /// <summary>
        /// Tabela Usuários
        /// </summary>
        public DbSet<UserEntity> Users { get; set; } //Para definir as tabelas do banco

        /// <summary>
        /// tabela Smart Contract
        /// </summary>
        public DbSet<SmartContractEntity> SmartContracts { get; set; } 
    }
}
