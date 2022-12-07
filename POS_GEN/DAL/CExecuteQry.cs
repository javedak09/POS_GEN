using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace POS_GEN
{
    internal class CExecuteQry
    {
        public DataSet ExecuteQuery(string qry)
        {
            DataSet ds = null;
            SQLiteDataAdapter da = null;
            CConnection cn = null;

            try
            {
                cn = new CConnection();
                da = new SQLiteDataAdapter(qry, cn.cn);
                ds = new DataSet();
                da.Fill(ds);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception Occur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                da = null;
                cn = null;
            }

            return ds;
        }
    }
}
