namespace Sirius.Domain.Models
{
    /// <summary>
    /// Modelo de Contrato Inteligente
    /// </summary>
    public class SmartContractModel
    {
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="id">Identificação do contrato</param>
        /// <param name="title">Título do contrato</param>
        /// <param name="description">Descrição do contrato</param>
        /// <param name="terminationCondition">Condições para termino do contrato</param>
        /// <param name="conclusionCondition">Condições para conclusão do contrato</param>
        /// <param name="value">Valor do contrato</param>
        /// <param name="companyModel">Modelo da Empresa</param>
        public SmartContractModel(long id
            , string title
            , string description
            , string terminationCondition
            , string conclusionCondition
            , decimal value
            , CompanyModel companyModel)
        {
            Id = id;
            Title = title;
            Description = description;
            TerminationCondition = terminationCondition;
            ConclusionCondition = conclusionCondition;
            Value = value;
            CompanyModel = companyModel;
        }

        /// <summary>
        /// Identificação
        /// </summary>
        public long Id { get; }

        /// <summary>
        /// Título do contrato inteligente
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// Descrição do contrato inteligente
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Motivos de rescisão do contrato.
        /// </summary>
        public string TerminationCondition { get; }

        /// <summary>
        /// Motivos de conclusão do contrato.
        /// </summary>
        public string ConclusionCondition { get; }

        /// <summary>
        /// Valor do contrato.
        /// </summary>
        public decimal Value { get; }

        /// <summary>
        /// Chave de autenticação do Contrato.
        /// </summary>
        public string AuthKey { get; }

        /// <summary>
        /// Empresa dona do Contrato
        /// </summary>
        public CompanyModel CompanyModel { get; }
    }
}
