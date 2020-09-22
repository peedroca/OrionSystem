using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.CrossCutting.Email.Models
{
    /// <summary>
    /// Conteúdo do Email
    /// </summary>
    public class ContentEmail
    {
        public ContentEmail(string subject, string message, bool isHTML, bool isSSL)
        {
            Subject = subject;
            Message = message;
            IsHTML = isHTML;
            IsSSL = isSSL;
        }

        /// <summary>
        /// Assunto
        /// </summary>
        public string Subject { get; }

        /// <summary>
        /// Mensagem
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// Usa HTML
        /// </summary>
        public bool IsHTML { get; }

        /// <summary>
        /// Usa SSL
        /// </summary>
        public bool IsSSL { get; }
    }
}
