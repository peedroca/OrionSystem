using Microsoft.EntityFrameworkCore;
using Sirius.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

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
