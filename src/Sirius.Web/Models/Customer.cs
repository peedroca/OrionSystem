using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sirius.Web.Models
{
    /// <summary>
    /// Cliente
    /// </summary>
    public class Customer
    {
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
    }
}
