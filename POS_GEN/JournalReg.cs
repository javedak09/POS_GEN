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
    public partial class JournalReg : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["POS_GEN.Properties.Settings.POS_GenConnectionString"].ConnectionString;

        DataTable table = new DataTable();
        DataRow dr;

        public JournalReg()
        {
            InitializeComponent();

            table.Columns.Add("Entry_No");
            table.Columns.Add("Entry_Name");
            table.Columns.Add("Title");
            table.Columns.Add("Title_Name");
            table.Columns.Add("Desc");
            table.Columns.Add("Debit_Amount");
            table.Columns.Add("Credit_Amount");
            table.Columns.Add("Date");
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (cmbentryname.Text == "" || cmbtitle.Text == "" || txtdesc.Text == "")
            {
                string title = "Operation Abort";
                MessageBox.Show("Please fill all fields in order to Add Record.", title);
            }
            else if (txtdebit.Enabled == true && txtdebit.Text == "")
            {
                string title = "Operation Abort";
                MessageBox.Show("Please Enter Debit Amount in order to Add.", title);
            }

            else if (txtcredit.Enabled == true && txtcredit.Text == "")
            {
                string title = "Operation Abort";
                MessageBox.Show("Please Enter Credit Amount in order to Add.", title);
            }
            else
            {
                dr = table.NewRow();
                dr["Entry_No"] = txtentryno.Text;
                dr["Entry_Name"] = cmbentryname.Text;
                dr["Title"] = cmbtitle.SelectedValue;
                dr["Title_Name"] = cmbtitle.Text;
                dr["Desc"] = txtdesc.Text;
                dr["Debit_Amount"] = txtdebit.Text;
                dr["Credit_Amount"] = txtcredit.Text;
                dr["Date"] = dt.Text;

                table.Rows.Add(dr);
                dataGridView1.DataSource = table;

            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowindex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["POS_GEN.Properties.Settings.POS_GenConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);

            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                string sqlquery = "INSERT INTO Journal_Info VALUES (@entryNo,@name,@title,@desc,@debit,@credit,@date)";
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                if (dr.IsNewRow) continue;
                {
                    sqlcomm.Parameters.AddWithValue("@entryNo", dr.Cells["Entry_No"].Value ?? DBNull.Value);
                    sqlcomm.Parameters.AddWithValue("@name", dr.Cells["Entry_Name"].Value ?? DBNull.Value);
                    sqlcomm.Parameters.AddWithValue("@title", dr.Cells["Title"].Value ?? DBNull.Value);
                    sqlcomm.Parameters.AddWithValue("@desc", dr.Cells["Desc"].Value ?? DBNull.Value);
                    sqlcomm.Parameters.AddWithValue("@debit", dr.Cells["Debit_Amount"].Value ?? DBNull.Value);
                    sqlcomm.Parameters.AddWithValue("@credit", dr.Cells["Credit_Amount"].Value ?? DBNull.Value);
                    sqlcomm.Parameters.AddWithValue("@date", dr.Cells["Date"].Value ?? DBNull.Value);
                }
                sqlconn.Open();
                sqlcomm.ExecuteNonQuery();
                sqlconn.Close();

            }

            string title = "Operation Completed";
            MessageBox.Show("Journal Entry Registered Successfully", title);

            autonumber();

            this.Close();
        }

        private void JournalReg_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Account_Title_Info' table. You can move, or remove it, as needed.
            this.account_Title_InfoTableAdapter.Fill(this.dataSet1.Account_Title_Info);

            autonumber();

            txtentryno.Enabled = false;
            txtdebit.Enabled = false;
            txtcredit.Enabled = false;

        }

        public void autonumber()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand comm = new SqlCommand("SELECT MAX (Entry_No)+1 FROM Journal_Info", con);
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtentryno.Text = dr[0].ToString();
                    if (txtentryno.Text == "")
                    {
                        txtentryno.Text = "1";
                    }

                }
            }
            else
            {
                txtentryno.Text = "1";
            }
            con.Close();

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbentryname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbentryname.Text == "Debit")
            {
                txtdebit.Enabled = true;
                txtcredit.Enabled = false;

                txtdebit.Text = "";
                txtcredit.Text = "";
            }
            else if (cmbentryname.Text == "Credit")
            {
                txtcredit.Enabled = true;
                txtdebit.Enabled = false;

                txtdebit.Text = "";
                txtcredit.Text = "";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
