using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace ShoeEcommers.LogicLayer.DataObjects
{
    public class ConnectionProvider
    {
        public static SqlConnection GetConnection()
        {
            string strCn = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            SqlConnection cn = new SqlConnection(strCn);
            cn.Open();
            return cn;
        }
    }
}
