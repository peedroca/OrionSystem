using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Domain.Entities
{
    // <summary>
    /// Entidade Requisição Cliente
    /// </summary>
    public class CustomerRequestEntity
    {
        /// <summary>
        /// Código de Requisição Cliente
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Primeiro nome de Requisição Cliente
        /// </summary>     
        public string FirstName { get; set; }

        /// <summary>
        /// Ultimo nome de Requisição Cliente
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        ///Apelido de Requisição Cliente
        /// </summary>
        public string Nickname { get; set; }

        /// <summary>
        /// CPF de Requisição Cliente
        /// </summary>
        public string CPF { get; set; }

        /// <summary>
        ///Cadastro de CNPJ de Requisição Cliente
        /// </summary>
        public string CNPJ { get; set; }

        /// <summary>
        /// Telefone de Requisição Cliente
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// E mail de Requisição Cliente
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Data de Aniversário de Requisição Cliente
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Data de criação de Requisição Cliente
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Data de Atualização Requisição Cliente
        /// </summary>
        public DateTime UpdatedOn { get; set; }

        /// <summary>
        /// Deletado
        /// </summary>
        public bool Deleted { get; set; }

        /// <summary>
        /// Rejeição da Requisição Cliente
        /// </summary>  
        public CustomerRefusalEntity CostumerRefusal { get; set; }
    }
}