using Sirius.CrossCutting.Email.Models;
using Sirius.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Sirius.CrossCutting.Email
{
    public class IntegrationEmail
    {
        #region Private Fields

        private SenderEmail senderEmail;

        #endregion

        #region Constructor

        public IntegrationEmail(SenderEmail sender)
        {
            senderEmail = sender;
            Exceptions = new List<Exception>();
        }

        #endregion

        #region Attributes

        public static List<Exception> Exceptions { get; internal set; }

        #endregion

        #region Public Methods

        public void SendEmailToUser(UserEntity userEntity, string email, string name)
        {
            var receiver = new ReceiverEmail(name, email);
            var content = new ContentEmail("Conta Sirius Criada Com Sucesso!"
                , $"Sua conta Sirius foi criada.\n\nUsuário: {userEntity.Username}\nSenha: {userEntity.Password}."
                , false
                , true);

            SendingEmail(receiver, content);
        }

        public void SendEmailToUser(string message, string email, string name)
        {
            var receiver = new ReceiverEmail(name, email);
            var content = new ContentEmail("Conta Sirius Criada Com Sucesso!"
                , message
                , false
                , true);

            SendingEmail(receiver, content);
        }

        public void SendingEmail(List<ReceiverEmail> receivers, ContentEmail content)
        {
            Parallel.ForEach(receivers, i =>
            {
                MailMessage message = null;

                try
                {
                    message = new MailMessage();

                    message.IsBodyHtml = content.IsHTML;
                    message.From = new MailAddress(senderEmail.AccountEmail, senderEmail.AccountName);
                    message.To.Add(new MailAddress(i.AccountEmail, i.AccountName));
                    message.Subject = content.Subject;
                    message.Body = content.Message;

                    using (var client = new SmtpClient(senderEmail.SMTP, senderEmail.Port))
                    {
                        client.Credentials =
                            new NetworkCredential(senderEmail.AccountEmail, senderEmail.Password);

                        client.EnableSsl = content.IsSSL;
                        client.Send(message);
                    }
                }
                catch (Exception e)
                {
                    Exceptions.Add(e);
                }
                finally
                {
                    message = null;
                }
            });
        }

        public void SendingEmail(ReceiverEmail receiver, ContentEmail content)
        {
            MailMessage message = null;

            try
            {
                message = new MailMessage();

                message.IsBodyHtml = content.IsHTML;
                message.From = new MailAddress(senderEmail.AccountEmail, senderEmail.AccountName);
                message.To.Add(new MailAddress(receiver.AccountEmail, receiver.AccountName));
                message.Subject = content.Subject;
                message.Body = content.Message;

                using (var client = new SmtpClient(senderEmail.SMTP, senderEmail.Port))
                {
                    client.Credentials =
                        new NetworkCredential(senderEmail.AccountEmail, senderEmail.Password);

                    client.EnableSsl = content.IsSSL;
                    client.Send(message);
                }
            }
            catch (Exception e)
            {
                Exceptions.Add(e);
            }
            finally
            {
                message = null;
            }
        }

        #endregion
    }
}
