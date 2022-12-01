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
namespace POS_GEN
{
    public partial class dbBackUp : Form
    {
        SqlConnection con = new SqlConnection(POS_GEN.Properties.Settings.Default.POS_GenConnectionString);

        public dbBackUp()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtlocation.Text = dlg.SelectedPath;
                btnbackup.Enabled = true;

            }
        }

        private void dbBackUp_Load(object sender, EventArgs e)
        {
            btnbackup.Enabled = false;
        }

        private void btnbackup_Click(object sender, EventArgs e)
        {
            string database = con.Database.ToString();
            try
            {
                if (txtlocation.Text == string.Empty)
                {
                    string title = "Operation Denied";
                    MessageBox.Show("Please Enter Backhup File Location.", title);
                }
                else
                {
                    string cmd = "BACKUP DATABASE [" + database + "] TO DISK= '" + txtlocation.Text + "\\" + "Database" + "-" + DateTime.Now.ToString("dd-MM-yyyy--HH-mm-ss") + ".bak'";
                    using (SqlCommand command = new SqlCommand(cmd, con))
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }
                        command.ExecuteNonQuery();
                        con.Close();
                        string title = "Operation Completed";
                        MessageBox.Show("Database Backed Up Successfully.", title);
                        btnbackup.Enabled = false;
                        txtlocation.Text = "";
                    }

                }

            }
            catch
            {

            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
