using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniORM
{
    using System.Data.SqlClient;

    class ConnectionStringBuilder
    {
        private SqlConnectionStringBuilder builder;

        private string connectionString;

        public ConnectionStringBuilder(string databaseName)
        {
            this.builder = new SqlConnectionStringBuilder();
            this.builder["Server"] = "(localdb)\\MSSQLLocalDB";
            this.builder["Integrated Security"] = true;
            this.builder["Trusted_Connection"] = true;
            this.builder["Connect Timeout"] = 1000;
            this.builder["Database"] = databaseName;
            this.connectionString = builder.ToString();
        }

        public string ConnectionString
        {
            get
            {
                return connectionString.ToString();
            }


        }
    }
}
