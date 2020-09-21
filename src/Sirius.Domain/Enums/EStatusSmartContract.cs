using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Domain.Enums
{
    /// <summary>
    /// Status do contrato inteligente 
    /// </summary>
    public enum EStatusSmartContract
    {
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
