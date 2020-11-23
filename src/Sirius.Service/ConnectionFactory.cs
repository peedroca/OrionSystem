using Microsoft.EntityFrameworkCore;
using Sirius.Infra.Data.Contexts;

namespace Sirius.Service
{
    internal class ConnectionFactory
    {
        public static SiriusDbContext SiriusDbContext;

        public ConnectionFactory(string connectionString)
        {
            SiriusDbContext = new SiriusDbContext(new DbContextOptionsBuilder()
                .UseSqlServer(connectionString)
                .Options);
        }
    }
}
