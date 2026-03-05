using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SQL_Practice.DataAccess
{
    public class DbHelper
    {
        public SqlConnection GetConnection()
        {
            string connect = ConfigurationManager.ConnectionStrings["PracticeDB"].ConnectionString;
            return new SqlConnection(connect);
        }
    }

}