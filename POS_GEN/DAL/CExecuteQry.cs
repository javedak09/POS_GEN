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
        public DataTable ExecuteQuery(string qry)
        {
            DataTable dt = null;
            SQLiteDataAdapter da = null;
            CConnection cn = null;

            try
            {
                cn = new CConnection();
                da = new SQLiteDataAdapter(qry, cn.cn);
                dt = new DataTable();
                da.Fill(dt);
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

            return dt;
        }
    }
}
