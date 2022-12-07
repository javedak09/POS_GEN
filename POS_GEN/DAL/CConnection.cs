using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace POS_GEN
{
    internal class CConnection
    {
        public SQLiteConnection cn;

        public CConnection()
        {
            cn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["cnStr"].ToString());
        }

        public void MConnOpen()
        {
            cn.Open();
        }

        public void MConnClose()
        {
            cn.Close();
        }
        
    }
}
