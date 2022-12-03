using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_GEN
{
    public class DataAccess
    {
        string ConnectionString;

        public DataAccess()
        {
            //ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["POS_GEN"].ConnectionString;
            ConnectionString = System.Configuration.ConfigurationManager.AppSettings["cnStr"].ToString();
        }

    }
}
