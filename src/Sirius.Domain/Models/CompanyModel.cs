using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Domain.Models
{
    /// <summary>
    /// Modelo de Empresa
    /// </summary>
    public class CompanyModel
    {
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="id">Identificação da empresa</param>
        /// <param name="name">Razão Social da empresa</param>
        /// <param name="nickname">Fantasia da empresa</param>
        /// <param name="cNPJ">CNPJ</param>
        /// <param name="phone">Telefone da empresa</param>
        /// <param name="email">Email da empresa</param>
        /// <param name="smartContracts">Lista de contratos inteligentes</param>
        /// <param name="user">Usuário da empresa</param>
        public CompanyModel(long id, string name, string nickname, string cNPJ, string phone, string email, IEnumerable<SmartContractModel> smartContracts, UserModel user, DateTime createdOn, DateTime updatedOn, bool deleted, bool blocked)
        {
            Id = id;
            Name = name;
            Nickname = nickname;
            CNPJ = cNPJ;
            Phone = phone;
            Email = email;
            SmartContracts = smartContracts;
            User = user;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
            Deleted = deleted;
            Blocked = blocked;
        }

        /// <summary>
        /// Identificação
        /// </summary>
        public long Id { get; }

        /// <summary>
        /// Razão Social
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Fantasia
        /// </summary>
        public string Nickname { get; }

        /// <summary>
        /// Cadastro nacional de Pessoa Jurídica
        /// </summary>
        public string CNPJ { get; }

        /// <summary>
        /// Telefone principal da empresa
        /// </summary>
        public string Phone { get; }

        /// <summary>
        /// E-mail de contato com a empresa
        /// </summary>
        public string Email { get; }

        /// <summary>
        /// Data de Criação do Registro
        /// </summary>
        public DateTime CreatedOn { get; }

        /// <summary>
        /// Data de Atualização do Registro
        /// </summary>
        public DateTime UpdatedOn { get; }

        /// <summary>
        /// Registro Apagado
        /// </summary>
        public bool Deleted { get; }

        /// <summary>
        /// Bloqueado
        /// </summary>
        public bool Blocked { get; }

        /// <summary>
        /// Lista com os contratos inteligentes da empresa.
        /// </summary>
        public IEnumerable<SmartContractModel> SmartContracts { get; }

        /// <summary>
        /// Usuário utilizado pela empresa.
        /// </summary>
        public UserModel User { get; }
    }
}
