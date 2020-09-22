namespace Sirius.CrossCutting.Email.Models
{
    /// <summary>
    /// Email do Remetente
    /// </summary>
    public class SenderEmail
    {
        public SenderEmail(string accountName, string sMTP, int port, string accountEmail, string password)
        {
            AccountName = accountName;
            SMTP = sMTP;
            Port = port;
            AccountEmail = accountEmail;
            Password = password;
        }

        /// <summary>
        /// Dono do email
        /// </summary>
        public string AccountName { get; }

        /// <summary>
        /// SMTP - Simple Mail Transfer Protocor - Endereço do servidor de Email
        /// </summary>
        public string SMTP { get; }

        /// <summary>
        /// Porta do servidor
        /// </summary>
        public int Port { get; }

        /// <summary>
        /// E-mail da conta
        /// </summary>
        public string AccountEmail { get; }

        /// <summary>
        /// Senha do email
        /// </summary>
        public string Password { get; }
    }
}
