using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Domain.Models
{
    /// <summary>
    /// Modelo de Cliente
    /// </summary>
    public class CustomerModel
    {
        public CustomerModel(long id
            , string firstName
            , string lastName
            , string nickname
            , string cpf
            , string cNPJ
            , string phone
            , string email
            , DateTime birthDate
            , DateTime createdOn
            , DateTime updatedOn
            , bool blocked
            , UserModel user)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Nickname = nickname;
            Cpf = cpf;
            CNPJ = cNPJ;
            Phone = phone;
            Email = email;
            BirthDate = birthDate;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
            Blocked = blocked;
            User = user;
        }

        /// <summary>
        /// id Cliente
        /// </summary>
        public long Id { get; }

        /// <summary>
        ///  Primeiro Nome de cliente
        /// </summary>
        public string FirstName { get; }

        /// <summary>
        /// Ultimo nome de cliente
        /// </summary>
        public string LastName { get; }

        /// <summary>
        /// Apelido de Cliente
        /// </summary>
        public string Nickname { get; }

        /// <summary>
        /// Cpf de Cliente
        /// </summary>
        public string Cpf { get; }

        /// <summary>
        /// Cadastro Nacional de Pessoa Jurídica
        /// </summary>
        public string CNPJ { get; }

        /// <summary>
        /// Telefone do cliente
        /// </summary>
        public string Phone { get; }

        /// <summary>
        /// E-mail do cliente
        /// </summary>
        public string Email { get; }

        /// <summary>
        /// Data de nascimento
        /// </summary>
        public DateTime BirthDate { get; }

        /// <summary>
        /// Data de Criação do Registro
        /// </summary>

        public DateTime CreatedOn { get; }

        /// <summary>
        /// Data de Atualização do Registro
        /// </summary>
        public DateTime UpdatedOn { get; }

        /// <summary>
        /// Cliente Bloqueado
        /// </summary>
        public bool Blocked { get; }

        /// <summary>
        /// Usuário utilizado pelo cliente.
        /// </summary>
        public UserModel User { get; }
    }
}
