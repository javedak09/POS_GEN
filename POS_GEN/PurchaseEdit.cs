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
    public partial class PurchaseEdit : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["POS_GEN.Properties.Settings.POS_GenConnectionString"].ConnectionString;

        public PurchaseEdit()
        {
            InitializeComponent();
        }

        private void purchase_InfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.purchase_InfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void PurchaseEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Product_Info' table. You can move, or remove it, as needed.
            this.product_InfoTableAdapter.Fill(this.dataSet1.Product_Info);
            // TODO: This line of code loads data into the 'dataSet1.Vendor_Info' table. You can move, or remove it, as needed.
            this.vendor_InfoTableAdapter.Fill(this.dataSet1.Vendor_Info);
            // TODO: This line of code loads data into the 'dataSet1.POS_View' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dataSet1.Purchase_Info' table. You can move, or remove it, as needed.
            this.purchase_InfoTableAdapter.Fill(this.dataSet1.Purchase_Info);

            purchase_IDTextBox.Enabled = false;
            pO_NoTextBox.Enabled = false;
            cmbvendor.Enabled = false;
            cmbproduct.Enabled = false;
            quantityTextBox.Enabled = false;
            unit_PriceTextBox.Enabled = false;
            total_PriceTextBox.Enabled = false;
            reg_DateDateTimePicker.Enabled = false;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (purchase_IDTextBox.Text == "")
            {
                string title = "Operation Aborted";
                MessageBox.Show("Please Select record in order to Edit.", title);
            }
            else
            {
                btnedit.Enabled = false;

                string mainconn = ConfigurationManager.ConnectionStrings["POS_GEN.Properties.Settings.POS_GenConnectionString"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);

                string sqlquery1 = "INSERT INTO Purchase_Log VALUES (@ponum,@vendor, @product,@qty, @unitprice,@totalprice,@purdate,@status, @logdate)";
                SqlCommand sqlcomm1 = new SqlCommand(sqlquery1, sqlconn);
                sqlconn.Open();
                sqlcomm1.Parameters.AddWithValue("@ponum", pO_NoTextBox.Text);
                sqlcomm1.Parameters.AddWithValue("@vendor", cmbvendor.Text);
                sqlcomm1.Parameters.AddWithValue("@product", cmbproduct.Text);
                sqlcomm1.Parameters.AddWithValue("@qty", quantityTextBox.Text);
                sqlcomm1.Parameters.AddWithValue("@unitprice", unit_PriceTextBox.Text);
                sqlcomm1.Parameters.AddWithValue("@totalprice", total_PriceTextBox.Text);
                sqlcomm1.Parameters.AddWithValue("@purdate", reg_DateDateTimePicker.Text);
                sqlcomm1.Parameters.AddWithValue("@status", "Edited");
                sqlcomm1.Parameters.AddWithValue("@logdate", DateTime.Now.ToString("yyyy-MM-dd"));
                sqlcomm1.ExecuteNonQuery();
                sqlconn.Close();

                

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Inventory_Info WHERE Product_ID='" + cmbproduct.SelectedValue + "'", sqlconn);
                DataTable data = new DataTable();
                da.Fill(data);
                if (data.Rows.Count > 0)
                {
                    string sqlquery = "UPDATE Inventory_Info SET Quantity=@Quantity WHERE Product_ID='" + cmbproduct.SelectedValue + "'";
                    SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);

                    double qty = Convert.ToDouble(data.Rows[0]["Quantity"].ToString()) - Convert.ToDouble(quantityTextBox.Text);
                    sqlcomm.Parameters.AddWithValue("@Quantity", qty);


                    sqlconn.Open();
                    sqlcomm.ExecuteNonQuery();
                    sqlconn.Close();
                }

                quantityTextBox.Enabled = true;
                unit_PriceTextBox.Enabled = true;

                quantityTextBox.Text = "";
                unit_PriceTextBox.Text = "";
                total_PriceTextBox.Text = "";

                btndisplay.Enabled = false;

                btnsave.Enabled = true;
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (quantityTextBox.Text == "" || unit_PriceTextBox.Text == "" || total_PriceTextBox.Text == "")
            {
                string title = "Operation Abort";
                MessageBox.Show("Please Fill All Fields.", title);
            }
            else
            {
                purchase_InfoBindingSource.EndEdit();
                purchase_InfoTableAdapter.Update(dataSet1.Purchase_Info);
                dataSet1.Purchase_Info.AcceptChanges();

                string mainconn = ConfigurationManager.ConnectionStrings["POS_GEN.Properties.Settings.POS_GenConnectionString"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Inventory_Info WHERE Product_ID='" + cmbproduct.SelectedValue + "'", sqlconn);
                DataTable data = new DataTable();
                da.Fill(data);
                if (data.Rows.Count > 0)
                {
                    string sqlquery = "UPDATE Inventory_Info SET Quantity=@Quantity WHERE Product_ID='" + cmbproduct.SelectedValue + "'";
                    SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);

                    double qty = Convert.ToDouble(data.Rows[0]["Quantity"].ToString()) + Convert.ToDouble(quantityTextBox.Text);
                    sqlcomm.Parameters.AddWithValue("@Quantity", qty);


                    sqlconn.Open();
                    sqlcomm.ExecuteNonQuery();
                    sqlconn.Close();
                }

                string title = "Operation Completed";
                MessageBox.Show("Purchase Record Updated Successfully.", title);

                quantityTextBox.Enabled = false;
                unit_PriceTextBox.Enabled = false;

                btnedit.Enabled = true;
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            if (pO_NoTextBox.Text == "")
            {
                string title = "Operation Aborted";
                MessageBox.Show("Please select record in order to Delete.", title);
            }
            else
            {

                string mainconn = ConfigurationManager.ConnectionStrings["POS_GEN.Properties.Settings.POS_GenConnectionString"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);

                string sqlquery1 = "INSERT INTO Purchase_Log VALUES (@ponum,@vendor, @product,@qty, @unitprice,@totalprice,@purdate,@status, @logdate)";
                SqlCommand sqlcomm1 = new SqlCommand(sqlquery1, sqlconn);
                sqlconn.Open();
                sqlcomm1.Parameters.AddWithValue("@ponum", pO_NoTextBox.Text);
                sqlcomm1.Parameters.AddWithValue("@vendor", cmbvendor.Text);
                sqlcomm1.Parameters.AddWithValue("@product", cmbproduct.Text);
                sqlcomm1.Parameters.AddWithValue("@qty", quantityTextBox.Text);
                sqlcomm1.Parameters.AddWithValue("@unitprice", unit_PriceTextBox.Text);
                sqlcomm1.Parameters.AddWithValue("@totalprice", total_PriceTextBox.Text);
                sqlcomm1.Parameters.AddWithValue("@purdate", reg_DateDateTimePicker.Text);
                sqlcomm1.Parameters.AddWithValue("@status", "Deleted");
                sqlcomm1.Parameters.AddWithValue("@logdate", DateTime.Now.ToString("yyyy-MM-dd"));
                sqlcomm1.ExecuteNonQuery();
                sqlconn.Close();
               
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Inventory_Info WHERE Product_ID='" + cmbproduct.SelectedValue + "'", sqlconn);
                DataTable data = new DataTable();
                da.Fill(data);
                if (data.Rows.Count > 0)
                {
                    string sqlquery = "UPDATE Inventory_Info SET Quantity=@Quantity WHERE Product_ID='" + cmbproduct.SelectedValue + "'";
                    SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);

                    double qty = Convert.ToDouble(data.Rows[0]["Quantity"].ToString()) - Convert.ToDouble(quantityTextBox.Text);
                    sqlcomm.Parameters.AddWithValue("@Quantity", qty);


                    sqlconn.Open();
                    sqlcomm.ExecuteNonQuery();
                    sqlconn.Close();
                }

                purchase_InfoBindingSource.RemoveCurrent();

                purchase_InfoBindingSource.EndEdit();
                purchase_InfoTableAdapter.Update(dataSet1.Purchase_Info);
                dataSet1.Purchase_Info.AcceptChanges();

                string title = "Operation Completed";
                MessageBox.Show("Purchase Deleted Successfully.", title);

            }
        }

        private void unit_PriceTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                total_PriceTextBox.Text = (float.Parse(quantityTextBox.Text) * float.Parse(unit_PriceTextBox.Text)).ToString();
            }
            catch
            {

            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            this.purchase_InfoTableAdapter.FillByponum(this.dataSet1.Purchase_Info,int.Parse(txtposearch.Text));

        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            this.purchase_InfoTableAdapter.Fill(this.dataSet1.Purchase_Info);

        }
    }
}
