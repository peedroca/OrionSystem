using Flunt.Notifications;
using Flunt.Validations;
using System;

namespace Sirius.Domain.Models
{
    /// <summary>
    /// Modelo de criação de contrato inteligente
    /// </summary>
    public class UpdateSmartContractModel : Notifiable
    {
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="id">Identificação do Cliente</param>
        /// <param name="title">Título do contrato</param>
        /// <param name="description">Descrição do contrato</param>
        /// <param name="terminationCondition">Condições para termino do contrato</param>
        /// <param name="conclusionCondition">Condições para conclusão do contrato</param>
        /// <param name="value">Valor do contrato</param>
        /// <param name="deleted">Contrato deletado</param>
        /// <param name="inactived">Contrato inativado</param>
        public UpdateSmartContractModel(long id
            , string title
            , string description
            , string terminationCondition
            , string conclusionCondition
            , decimal value
            , bool deleted
            , bool inactived)
        {
            Id = id;
            Title = title;
            Description = description;
            TerminationCondition = terminationCondition;
            ConclusionCondition = conclusionCondition;
            Value = value;
            UpdatedOn = DateTime.Now;
            Deleted = deleted;
            Inactived = inactived;

            AddNotifications(new Contract()
                .IsGreaterThan(Id, 0, "Id", "Id inválido")
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
        /// Chave de autenticação do Contrato.
        /// </summary>
        public string AuthKey { get; }

        /// <summary>
        /// Empresa dona do Contrato
        /// </summary>
        public CompanyModel CompanyModel { get; private set; }

        /// <summary>
        /// Data de Criação do Registro
        /// </summary>
        public DateTime CreatedOn { get; private set; }

        /// <summary>
        /// Data de Atualização do Registro
        /// </summary>
        public DateTime UpdatedOn { get; }

        /// <summary>
        /// Registro Apagado
        /// </summary>
        public bool Deleted { get; }

        /// <summary>
        /// Inativo
        /// </summary>
        public bool Inactived { get; }

        /// <summary>
        /// Carrega a empresa dona do contrato
        /// </summary>
        /// <param name="company">Empresa dona do contrato</param>
        public void LoadCompanyModel(CompanyModel company) =>
            CompanyModel = company;

        public void LoadCreatedOn(DateTime dateTime) =>
            CreatedOn = dateTime;
    }
}
