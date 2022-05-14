using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Crud_ADO_dotnet.Models
{
    public class DBConfig
    {
        public SqlConnection sql { get; set; }

        public DBConfig()
        {
            string Cnn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            sql = new SqlConnection(Cnn);
        }
    }
}