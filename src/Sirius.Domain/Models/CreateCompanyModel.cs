using Flunt.Notifications;
using Flunt.Validations;
using Sirius.CrossCutting.Validations;
using Sirius.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Sirius.Domain.Models
{
    /// <summary>
    /// Modelo de criação da empresa
    /// </summary>
    public class CreateCompanyModel : Notifiable
    {
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="name">Razão social da empresa</param>
        /// <param name="nickname">Fantasia da empresa</param>
        /// <param name="cNPJ">CNPJ</param>
        /// <param name="phone">Telefone da empresa</param>
        /// <param name="email">Email da empresa</param>
        public CreateCompanyModel(string name, string nickname, string cNPJ, string phone, string email)
        {
            Id = 0;
            Name = name;
            Nickname = nickname;
            CNPJ = cNPJ;
            Phone = phone;
            Email = email;
            CreatedOn = DateTime.Now;
            UpdatedOn = DateTime.Now;
            Deleted = false;
            Blocked = false;
            SmartContracts = null;
            User = null;

            AddNotifications(new Contract()
                .IsNotNullOrEmpty(Email, "Email", "O e-mail é obrigatório.")
                .IsEmail(Email, "Email", "E-mail incorreto.")
                .IsTrue(CpfCnpjUtils.IsValid(CNPJ), "CNPJ", "O CNPJ informado não é válido")
                .IsNotNullOrEmpty(CNPJ, "CNPJ", "O CNPJ é obrigatório.")
                .IsNotNullOrEmpty(Nickname, "Nickname", "O nome fantasia é obrigatório.")
                .IsNotNullOrEmpty(Name, "Name", "A razão social é obrigatória."));
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
        public UserEntity User { get; private set; }

        /// <summary>
        /// Modificar usuário
        /// </summary>
        /// <param name="userModel"></param>
        public void ChangeUser(UserEntity userModel) =>
            User = userModel;

    }
}
