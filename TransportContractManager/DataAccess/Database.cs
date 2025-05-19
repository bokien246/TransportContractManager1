using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace TransportContractManager.DataAccess
{
    public static class Database
    {
        private static readonly string connectionString =
            @"Data Source=KIENLUXURY\SQLEXPRESS;Initial Catalog=TransportCompany;Integrated Security=True;TrustServerCertificate=True";


        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}

