using Flunt.Notifications;
using Flunt.Validations;

namespace Sirius.Domain.Models
{
    /// <summary>
    /// Modelo de criação de contrato inteligente
    /// </summary>
    public class CreateSmartContractModel : Notifiable
    {
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="title">Título do contrato</param>
        /// <param name="description">Descrição do contrato</param>
        /// <param name="terminationCondition">Condições para termino do contrato</param>
        /// <param name="conclusionCondition">Condições para conclusão do contrato</param>
        /// <param name="value">Valor do contrato</param>
        /// <param name="companyModel">Empresa dona do contrato</param>
        public CreateSmartContractModel(string title
            , string description
            , string terminationCondition
            , string conclusionCondition
            , decimal value
            , CompanyModel companyModel)
        {
            Id = 0;
            Title = title;
            Description = description;
            TerminationCondition = terminationCondition;
            ConclusionCondition = conclusionCondition;
            Value = value;
            CompanyModel = companyModel;

            AddNotifications(new Contract()
                .IsNotNullOrEmpty(Title, "Título", "O contrato deve ter um título.")
                .IsNotNullOrEmpty(Description, "Descrição", "O contrato deve ter uma descrição.")
                .IsNotNullOrEmpty(TerminationCondition, "Condição de Término", "A condição de término é obrigatória.")
                .IsGreaterThan(Value, 0, "Valor", "O valor do contrato não pode ser igual a 0 (zero).")
                .IsNull(CompanyModel, "Empresa", "Informe a empresa")
                .IsNotNullOrEmpty(ConclusionCondition, "Condição de Conclusão", "A condição de conclusão é obrigatória."));
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
        /// Empresa dona do Contrato
        /// </summary>
        public CompanyModel CompanyModel { get; }
    }
}
