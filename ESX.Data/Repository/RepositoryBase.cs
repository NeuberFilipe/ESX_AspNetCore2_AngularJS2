using Microsoft.Extensions.Configuration;
using System;
using System.Data.SqlClient;

namespace ESX.Data.Repository
{
    internal class RepositoryBase
    {
        private const string CONNECTIONSTRING_kEY = "ConnectionString";

        protected SqlConnection connection;

        public RepositoryBase(IConfiguration config)
        {
            var connectionString = config.GetSection(CONNECTIONSTRING_kEY);

            if (String.IsNullOrWhiteSpace(connectionString.Value))
                throw new ArgumentNullException("ConnectionString not found");

            connection = new SqlConnection(connectionString.Value);
        }

    }
}
