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
                da = new SQLiteDataAdapter(qry, cn.cn);
                ds = new DataSet();
                da.Fill(ds);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Blank Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
