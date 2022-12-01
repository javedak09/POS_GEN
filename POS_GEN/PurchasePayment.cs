using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_GEN
{
    public partial class PurchasePayment : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["POS_GEN.Properties.Settings.POS_GenConnectionString"].ConnectionString;

        public PurchasePayment()
        {
            InitializeComponent();
        }

        private void purchase_Pay_InfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.purchase_Pay_InfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void PurchasePayment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Vendor_Info' table. You can move, or remove it, as needed.
            this.vendor_InfoTableAdapter.Fill(this.dataSet1.Vendor_Info);
            // TODO: This line of code loads data into the 'dataSet1.Purchase_Pay_Info' table. You can move, or remove it, as needed.
            this.purchase_Pay_InfoTableAdapter.Fill(this.dataSet1.Purchase_Pay_Info);


            dt1.Enabled = false;
            pay_IDTextBox.Enabled = false;
            cmbvendor.Enabled = false;
            prev_AmountTextBox.Enabled = false;
            current_AmountTextBox.Enabled = false;
            total_AmountTextBox.Enabled = false;
            recieved_AmountTextBox.Enabled = false;
            balanceTextBox.Enabled = false;
            mOPComboBox.Enabled = false;
            reg_DateDateTimePicker.Enabled = false;

            btnsave.Enabled = false;

        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            prev_AmountTextBox.Focus();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            dt1.Enabled = true;
            cmbvendor.Enabled = true;
            prev_AmountTextBox.Enabled = true;
            recieved_AmountTextBox.Enabled = true;
            balanceTextBox.Enabled = true;
            mOPComboBox.Enabled = true;
            reg_DateDateTimePicker.Enabled = true;

            

            btnsave.Enabled = true;
            btnadd.Enabled = false;
            btnedit.Enabled = false;
            btndelete.Enabled = false;
            btnfirst.Enabled = false;
            btnnext.Enabled = false;
            btnprevious.Enabled = false;
            btnlast.Enabled = false;

            purchase_Pay_InfoBindingSource.AddNew();

            reg_DateDateTimePicker.ResetText();
            reg_DateDateTimePicker.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            purchase_Pay_InfoBindingSource.EndEdit();
            purchase_Pay_InfoTableAdapter.Update(dataSet1.Purchase_Pay_Info);
            dataSet1.Purchase_Pay_Info.AcceptChanges();

            string title = "Operation Completed";
            MessageBox.Show("Record Saved/ Updated Successfully.", title);

            dt1.Enabled = false;
            cmbvendor.Enabled = false;
            prev_AmountTextBox.Enabled = false;
            current_AmountTextBox.Enabled = false;
            total_AmountTextBox.Enabled = false;
            recieved_AmountTextBox.Enabled = false;
            balanceTextBox.Enabled = false;
            mOPComboBox.Enabled = false;
            reg_DateDateTimePicker.Enabled = false;
            
            btnsave.Enabled = false;
            btnadd.Enabled = true;
            btnedit.Enabled = true;
            btndelete.Enabled = true;
            btnfirst.Enabled = true;
            btnnext.Enabled = true;
            btnprevious.Enabled = true;
            btnlast.Enabled = true;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {

            cmbvendor.Enabled = true;
            prev_AmountTextBox.Enabled = true;
            recieved_AmountTextBox.Enabled = true;
            reg_DateDateTimePicker.Enabled = true;
            mOPComboBox.Enabled = true;

            btnedit.Enabled = false;
            btnadd.Enabled = false;
            btndelete.Enabled = false;
            btnsave.Enabled = true;
            btnfirst.Enabled = false;
            btnnext.Enabled = false;
            btnprevious.Enabled = false;
            btnlast.Enabled = false;

            dt1.Enabled = true;


            SqlConnection con = new SqlConnection(cs);

            SqlDataAdapter sda = new SqlDataAdapter("SELECT SUM(CAST(Total_Price as float)) as Amount FROM Purchase_Info WHERE Vendor_ID='" + cmbvendor.SelectedValue + "' AND Reg_Date BETWEEN '" + dt1.Text + "' AND '" + dt1.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                current_AmountTextBox.Text = dt.Rows[0]["Amount"].ToString();
            }
            else
            {
                current_AmountTextBox.Text = "0";
            }

            recieved_AmountTextBox.Text = "";
            balanceTextBox.Text = "";

            try
            {
                total_AmountTextBox.Text = (float.Parse(prev_AmountTextBox.Text) + float.Parse(current_AmountTextBox.Text)).ToString();
            }
            catch
            {

            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            purchase_Pay_InfoBindingSource.RemoveCurrent();

            purchase_Pay_InfoBindingSource.EndEdit();
            purchase_Pay_InfoTableAdapter.Update(dataSet1.Purchase_Pay_Info);
            dataSet1.Purchase_Pay_Info.AcceptChanges();

            string title = "Operation Completed";
            MessageBox.Show("Record Deleted Successfully.", title);
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            purchase_Pay_InfoBindingSource.MoveFirst();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            purchase_Pay_InfoBindingSource.MoveNext();
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            purchase_Pay_InfoBindingSource.MovePrevious();
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            purchase_Pay_InfoBindingSource.MoveLast();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            this.purchase_Pay_InfoTableAdapter.FillByvendor(this.dataSet1.Purchase_Pay_Info,Convert.ToInt32(cmbsearchvendor.SelectedValue));
        }

        private void prev_AmountTextBox_Leave(object sender, EventArgs e)
        {
            recieved_AmountTextBox.Focus();
        }

        private void dt1_ValueChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);

            SqlDataAdapter sda = new SqlDataAdapter("SELECT SUM(CAST(Total_Price as float)) as Amount FROM Purchase_Info WHERE Vendor_ID='" + cmbvendor.SelectedValue + "' AND Reg_Date BETWEEN '" + dt1.Text + "' AND '" + dt1.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count <= 0 || dt.Rows[0]["Amount"].ToString() == string.Empty || dt.Rows[0]["Amount"].ToString() == "0")
            {
                current_AmountTextBox.Text = "0";
            }
            else
            {

                current_AmountTextBox.Text = dt.Rows[0]["Amount"].ToString();
            }


            SqlDataAdapter sda1 = new SqlDataAdapter("SELECT Balance FROM Purchase_Pay_Info WHERE Vendor_ID='" + cmbvendor.SelectedValue + "' ORDER BY Pay_ID DESC", con);
            DataTable dt2 = new DataTable();
            sda1.Fill(dt2);

            try
            {
                if (dt2.Rows.Count <= 0 || dt2.Rows[0]["Balance"].ToString() == string.Empty || dt2.Rows[0]["Balance"].ToString() == "0")
                {
                    string title = "Information";
                    MessageBox.Show("There is no Balance of " + cmbvendor.Text + "", title);

                    prev_AmountTextBox.Text = "0";

                }
                else
                {
                    prev_AmountTextBox.Text = dt2.Rows[0]["Balance"].ToString();
                }
            }
            catch
            {
            }


            try
            {
                total_AmountTextBox.Text = (float.Parse(prev_AmountTextBox.Text) + float.Parse(current_AmountTextBox.Text)).ToString();
            }
            catch
            {

            }
        }

        private void cmbvendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);

            SqlDataAdapter sda = new SqlDataAdapter("SELECT SUM(CAST(Total_Price as float)) as Amount FROM Purchase_Info WHERE Vendor_ID='" + cmbvendor.SelectedValue + "' AND Reg_Date BETWEEN '" + dt1.Text + "' AND '" + dt1.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count <= 0 || dt.Rows[0]["Amount"].ToString() == string.Empty || dt.Rows[0]["Amount"].ToString() == "0")
            {
                current_AmountTextBox.Text = "0";
            }
            else
            {

                current_AmountTextBox.Text = dt.Rows[0]["Amount"].ToString();
            }


            SqlDataAdapter sda1 = new SqlDataAdapter("SELECT Balance FROM Purchase_Pay_Info WHERE Vendor_ID='" + cmbvendor.SelectedValue + "' ORDER BY Pay_ID DESC", con);
            DataTable dt2 = new DataTable();
            sda1.Fill(dt2);

            try
            {
                if (dt2.Rows.Count <= 0 || dt2.Rows[0]["Balance"].ToString() == string.Empty || dt2.Rows[0]["Balance"].ToString() == "0")
                {
                    string title = "Information";
                    MessageBox.Show("There is no Balance of " + cmbvendor.Text + "", title);

                    prev_AmountTextBox.Text = "0";

                }
                else
                {
                    prev_AmountTextBox.Text = dt2.Rows[0]["Balance"].ToString();
                }
            }
            catch
            {
            }


            try
            {
                total_AmountTextBox.Text = (float.Parse(prev_AmountTextBox.Text) + float.Parse(current_AmountTextBox.Text)).ToString();
            }
            catch
            {

            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void recieved_AmountTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                balanceTextBox.Text = (float.Parse(total_AmountTextBox.Text) - float.Parse(recieved_AmountTextBox.Text)).ToString();
            }
            catch
            {

            }
        }

        private void prev_AmountTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                total_AmountTextBox.Text = (float.Parse(prev_AmountTextBox.Text) + float.Parse(current_AmountTextBox.Text)).ToString();
            }
            catch
            {

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
