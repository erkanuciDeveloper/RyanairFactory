using Framework.Configuration;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Daper.Repositories.Base
{
    public class BaseRepository
    {
        public readonly string _connectionString;
        private readonly IConfiguration _config;
        public IDbConnection _connection { get { return new SqlConnection(_connectionString); } }


        public BaseRepository()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(ConfigReader.GetConnectionStringsValue("DbConnectionString"));
            _connectionString = builder.ConnectionString;

        }

    }
}
