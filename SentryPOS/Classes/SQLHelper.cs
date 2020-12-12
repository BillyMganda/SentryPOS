using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Data.SqlClient;


namespace SentryPOS.Classes
{
    class SQLHelper
    {
        SqlConnection cn;
        public SQLHelper(string connectionString)
        {
            cn = new SqlConnection(connectionString);
        }
        public bool IsConnection
        {
            get
            {
                if (cn.State == System.Data.ConnectionState.Closed)
                    cn.Open();
                return true;
            }
        }
    }
}
