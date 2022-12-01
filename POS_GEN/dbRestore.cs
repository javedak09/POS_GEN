using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace POS_GEN
{
    public partial class dbRestore : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["POS_GEN.Properties.Settings.POS_GenConnectionString"].ConnectionString;
        // SqlConnection con = new SqlConnection(POS_GEN.Properties.Settings.Default.POS_GenConnectionString);

        public dbRestore()
        {
            InitializeComponent();
        }

        private void btnproceed_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT DISTINCT Password FROM User_Info WHERE Password='" + txtpass.Text + "' AND Role='Admin'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count <= 0)
            {
                string title = "Invalid Password";
                MessageBox.Show("Your Entered Password in Incorrect.", title);
                txtpass.Text = "";
            }
            else
            {

                groupBox1.Visible = true;
                groupBox2.Visible = false;

            }
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files|*.bak";
            dlg.Title = "Database Restore";
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                txtlocation.Text = dlg.FileName;
                btnrestore.Enabled = true;
            }
        }

        private void btnrestore_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string database = con.Database.ToString();

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            try
            {
                string sqlStmt2 = string.Format("ALTER DATABASE[" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand bu2 = new SqlCommand(sqlStmt2, con);
                bu2.ExecuteNonQuery();

                string sqlStmt3 = "USE MASTER RESTORE DATABASE[" + database + "] FROM DISK='" + txtlocation.Text + "'WITH REPLACE;";
                SqlCommand bu3 = new SqlCommand(sqlStmt3, con);
                bu3.ExecuteNonQuery();

                string sqlStmt4 = string.Format("ALTER DATABASE[" + database + "] SET MULTI_USER");
                SqlCommand bu4 = new SqlCommand(sqlStmt4, con);
                bu4.ExecuteNonQuery();

                string title = "Operation Completed";
                MessageBox.Show("Database Restored Successfully.", title);
                con.Close();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dbRestore_Load(object sender, EventArgs e)
        {
            btnrestore.Enabled = false;

            groupBox2.Visible = true;
            groupBox1.Visible = false;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
