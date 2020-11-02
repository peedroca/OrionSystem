using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Domain.Models
{
    public class CreateCustomerRequestModel : Notifiable
    {
        public CreateCustomerRequestModel(string firstName
            , string lastName
            , string nickname
            , string cPF
            , string cNPJ
            , string phone
            , string email
            , DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            Nickname = nickname;
            CPF = cPF;
            CNPJ = cNPJ;
            Phone = phone;
            Email = email;
            BirthDate = birthDate;
        }

        /// <summary>
        /// Primeiro nome de Requisição Cliente
        /// </summary>     
        public string FirstName { get; }

        /// <summary>
        /// Ultimo nome de Requisição Cliente
        /// </summary>
        public string LastName { get; }

        /// <summary>
        ///Apelido de Requisição Cliente
        /// </summary>
        public string Nickname { get; }

        /// <summary>
        /// CPF de Requisição Cliente
        /// </summary>
        public string CPF { get; }

        /// <summary>
        ///Cadastro de CNPJ de Requisição Cliente
        /// </summary>
        public string CNPJ { get; }

        /// <summary>
        /// Telefone de Requisição Cliente
        /// </summary>
        public string Phone { get; }

        /// <summary>
        /// E mail de Requisição Cliente
        /// </summary>
        public string Email { get; }

        /// <summary>
        /// Data de Aniversário de Requisição Cliente
        /// </summary>
        public DateTime BirthDate { get; }
    }
}
