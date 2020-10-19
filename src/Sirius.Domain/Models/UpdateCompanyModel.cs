using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;

namespace Sirius.Domain.Models
{
    /// <summary>
    /// Modelo de Atualização de Empresa
    /// </summary>
    public class UpdateCompanyModel : Notifiable
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="nickname"></param>
        /// <param name="cNPJ"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        /// <param name="deleted"></param>
        /// <param name="blocked"></param>
        public UpdateCompanyModel(long id, string name, string nickname, string cNPJ, string phone, string email, bool deleted, bool blocked)
        {
            Id = id;
            Name = name;
            Nickname = nickname;
            CNPJ = cNPJ;
            Phone = phone;
            Email = email;
            UpdatedOn = DateTime.Now;
            Deleted = deleted;
            Blocked = blocked;

            AddNotifications(new Contract()
                .IsGreaterThan(Id, 0, "Id", "Id inválido")
                .IsNotNullOrEmpty(Email, "Email", "O e-mail é obrigatório.")
                .IsEmail(Email, "Email", "E-mail incorreto.")
                .IsNotNullOrEmpty(CNPJ, "CNPJ", "O CNPJ é obrigatório.")
                .IsNotNullOrEmpty(Nickname, "Fantasia", "O nome fantasia é obrigatório.")
                .IsNotNullOrEmpty(Name, "Razão Social", "A razão social é obrigatória."));
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
        public DateTime CreatedOn { get; private set; }

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
        public ICollection<SmartContractModel> SmartContracts { get; private set; }

        /// <summary>
        /// Usuário utilizado pela empresa.
        /// </summary>
        public UserModel User { get; private set; }

        public void LoadCreationDate(DateTime createdOn) =>
            this.CreatedOn = CreatedOn;

        public void LoadSmartContracts(ICollection<SmartContractModel> smartContracts) =>
            this.SmartContracts = smartContracts;

        public void LoadUser(UserModel user) =>
            this.User = user;
    }
}
