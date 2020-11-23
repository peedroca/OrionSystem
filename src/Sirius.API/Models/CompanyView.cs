using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sirius.API.Models
{
    /// <summary>
    /// Visualização de Empresa
    /// </summary>
    public class CompanyView
    {
        /// <summary>
        /// Identificação
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Razão Social
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Fantasia
        /// </summary>
        public string Nickname { get; set; }

        /// <summary>
        /// Cadastro nacional de Pessoa Jurídica
        /// </summary>
        public string CNPJ { get; set; }

        /// <summary>
        /// Telefone principal da empresa
        /// </summary>
        public string Phone { get; set; }
    }
}
