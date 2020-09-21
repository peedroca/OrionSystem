using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Domain.Entities
{
    /// <summary>
    /// Entidade Empresa
    /// </summary>
    public class CompanyEntity
    {
        /// <summary>
        /// Identificação
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Razão Social    
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Fantasia
        /// </summary>
        public string Nickname { get; set; }

        /// <summary>
        /// Cadastro nacional de Pessoa Jurídica
        /// </summary>
        public string CNPJ { get; set; }

        /// <summary>
        /// Telefone principal da empresa
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// E-mail de contato com a empresa
        /// </summary>
        public string Email { get; set; }
                
        /// <summary>
        /// Data de Criação do Registro
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Data de Atualização do Registro
        /// </summary>
        public DateTime UpdatedOn { get; set; }

        /// <summary>
        /// Registro Apagado
        /// </summary>
        public bool Deleted { get; set; }

        /// <summary>
        /// Bloqueado
        /// </summary>
        public bool Blocked { get; set; }

        /// <summary>
        /// Lista com os contratos inteligentes da empresa.
        /// </summary>
        public IEnumerable<SmartContractEntity> SmartContracts { get; set; }

        /// <summary>
        /// Usuário utilizado pela empresa.
        /// </summary>
        public UserEntity User { get; set; }
    }
}
