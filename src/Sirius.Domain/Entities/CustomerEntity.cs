using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Domain.Entities
{
    /// <summary>
    /// Entidade Cliente
    /// </summary>
    public class CustomerEntity
    {
        /// <summary>
        /// id Cliente
        /// </summary>
        public long Id  { get; set; }

        /// <summary>
        ///  Primeiro Nome de cliente
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Ultimo nome de cliente
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Apelido de Cliente
        /// </summary>
        public string Nickname { get; set; }

        /// <summary>
        /// Cpf de Cliente
        /// </summary>
        public string Cpf { get; set; }

        /// <summary>
        /// Cadastro Nacional de Pessoa Jurídica
        /// </summary
        public string CNPJ { get; set; }

        /// <summary>
        /// Telefone do cliente
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// E-mail do cliente
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Data de nascimento
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Data de Criação do Registro
        /// </summary>

        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Data de Atualização do Registro
        /// </summary>
        public DateTime UpdatedOn { get; set; }

        /// <summary>
        /// Cliente Bloqueado
        /// </summary>
        public bool Blocked { get; set; }

        /// <summary>
        /// Usuário utilizado pelo cliente.
        /// </summary>
        public UserEntity User { get; set; }
    }
}
