using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using SqlKata.Execution;
using SqlKata.Compilers;
using System;
namespace EvaluacionesEMATEAplicada.Repositories
{
    public class DatabaseConnector
    {
        protected const string CONNECTION_STRING_ENV = "ConnectionString";
        private string connectionString;
        private SqlConnection connection;
        private SqlServerCompiler compiler;
        private QueryFactory factory;


        public DatabaseConnector()
        {
            BuildConnection();
            BuildQueryFactory();
        }

        private void BuildConnection()
        {
            connectionString = Environment.GetEnvironmentVariable(CONNECTION_STRING_ENV);
            connection = new SqlConnection(connectionString);
        }

        private void BuildQueryFactory()
        {
            compiler = new SqlServerCompiler();
            factory = new QueryFactory(connection, compiler);
        }

        public QueryFactory GetFactory()
        {
            return factory;
        }

    }
}
