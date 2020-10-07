namespace Sirius.API.Models
{
    public class Company
    {
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

        /// <summary>
        /// E-mail de contato com a empresa
        /// </summary>
        public string Email { get; set; }
    }
}
