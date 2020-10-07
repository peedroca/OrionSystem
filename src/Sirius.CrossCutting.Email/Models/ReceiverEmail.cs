namespace Sirius.CrossCutting.Email.Models
{
    /// <summary>
    /// Email do Destinatário
    /// </summary>
    public class ReceiverEmail
    {
        public ReceiverEmail(string accountName, string accountEmail)
        {
            AccountName = accountName;
            AccountEmail = accountEmail;
        }

        /// <summary>
        /// Nome do destinatário
        /// </summary>
        public string AccountName { get; }

        /// <summary>
        /// Email do destinatário
        /// </summary>
        public string AccountEmail { get; }
    }
}
