using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Domain.Models
{
    public class CustomerRequestModel
    {
        public CustomerRequestModel(long id, string firstName, string lastName, string nickname, string cPF, string cNPJ, string phone, string email, DateTime birthDate, DateTime createdOn, DateTime updatedOn, bool deleted, CustomerRefusalModel costumerRefusal)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Nickname = nickname;
            CPF = cPF;
            CNPJ = cNPJ;
            Phone = phone;
            Email = email;
            BirthDate = birthDate;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
            Deleted = deleted;
            CostumerRefusal = costumerRefusal;
        }

        /// <summary>
        /// Código de Requisição Cliente
        /// </summary>
        public long Id { get; }

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

        /// <summary>
        /// Data de criação de Requisição Cliente
        /// </summary>
        public DateTime CreatedOn { get; }

        /// <summary>
        /// Data de Atualização Requisição Cliente
        /// </summary>
        public DateTime UpdatedOn { get; }

        /// <summary>
        /// Deletado
        /// </summary>
        public bool Deleted { get; }

        /// <summary>
        /// Rejeição da Requisição Cliente
        /// </summary>  
        public CustomerRefusalModel CostumerRefusal { get; }
    }
}
