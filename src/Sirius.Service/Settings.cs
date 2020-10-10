using Sirius.CrossCutting.Email.Models;
using Sirius.Infra.Data.Contexts;

namespace Sirius.Service
{
    public class Settings
    {
        internal static SenderEmail SenderEmail;
        public static SiriusDbContext SiriusDbContext { get { return ConnectionFactory.SiriusDbContext; } }

        public Settings(string connectionString, SenderEmail senderEmail = null)
        {
            new ConnectionFactory(connectionString);
            SenderEmail = senderEmail;
        }

        public Settings(SenderEmail senderEmail)
        {
            SenderEmail = senderEmail;
        }
    }
}
