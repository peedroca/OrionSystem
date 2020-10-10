namespace Sirius.Domain.Enums
{
    /// <summary>
    /// Status do contrato inteligente 
    /// </summary>
    public enum EStatusSmartContract
    {
        /// <summary>
        /// Nenhum
        /// </summary>
        None,

        /// <summary>
        /// Pago
        /// </summary>
        Payed,

        /// <summary>
        /// Aguardando pagamento
        /// </summary>
        AwaitingPayment,

        /// <summary>
        /// Rescindido
        /// </summary>
        Terminated,

        /// <summary>
        /// Finalizado
        /// </summary>
        Finished,

        /// <summary>
        /// Expirado
        /// </summary>
        Expired

    }
}
