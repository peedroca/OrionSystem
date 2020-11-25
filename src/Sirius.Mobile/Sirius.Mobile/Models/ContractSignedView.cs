using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Mobile.Models
{
    public class ContractSignedView
    {
        /// <summary>
        /// Identificação do Contrato Assinado
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Identificação do Contrato
        /// </summary>
        public long IdContract { get; set; }

        /// <summary>
        /// Título do contrato inteligente
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Descrição do contrato inteligente
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Motivos de rescisão do contrato.
        /// </summary>
        public string TerminationCondition { get; set; }

        /// <summary>
        /// Motivos de conclusão do contrato.
        /// </summary>
        public string ConclusionCondition { get; set; }

        /// <summary>
        /// Valor do contrato.
        /// </summary>
        public decimal Value { get; set; }

        /// <summary>
        /// id Cliente
        /// </summary>
        public long IdCustomer { get; set; }

        /// <summary>
        ///  Primeiro Nome de cliente
        /// </summary>
        public string NameCustomer { get; set; }

        /// <summary>
        /// Ultimo nome de cliente
        /// </summary>
        public string NicknameCustomer { get; set; }

        /// <summary>
        /// Documento do cliente
        /// </summary>
        public string DocumentCustomer { get; set; }

        /// <summary>
        /// Telefone do cliente
        /// </summary>
        public string PhoneCustomer { get; set; }

        /// <summary>
        /// E-mail do cliente
        /// </summary>
        public string EmailCustomer { get; set; }

        /// <summary>
        /// id empresa
        /// </summary>
        public long IdCompany { get; set; }

        /// <summary>
        ///  Primeiro Nome da empresa
        /// </summary>
        public string NameCompany { get; set; }

        /// <summary>
        /// Ultimo nome da empresa
        /// </summary>
        public string NicknameCompany { get; set; }

        /// <summary>
        /// Documento da empresa
        /// </summary>
        public string DocumentCompany { get; set; }

        /// <summary>
        /// Telefone da empresa
        /// </summary>
        public string PhoneCompany { get; set; }

        /// <summary>
        /// E-mail da empresa
        /// </summary>
        public string EmailCompany { get; set; }
    }
}
