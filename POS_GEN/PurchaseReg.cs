using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace POS_GEN
{
    public partial class PurchaseReg : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["POS_GEN.Properties.Settings.POS_GenConnectionString"].ConnectionString;

        DataTable dt = new DataTable();
        DataRow dr;

        public PurchaseReg()
        {
            InitializeComponent();

            dt.Columns.Add("Ven_ID");
            dt.Columns.Add("Ven_Name");
            dt.Columns.Add("Prod_ID");
            dt.Columns.Add("Prod_Name");
            dt.Columns.Add("Qty");
            dt.Columns.Add("Rate");
            dt.Columns.Add("Total");
            dt.Columns.Add("Date");

            timer1.Start();
        }

        private void PurchaseReg_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Category_Info' table. You can move, or remove it, as needed.
            this.category_InfoTableAdapter.Fill(this.dataSet1.Category_Info);
            // TODO: This line of code loads data into the 'dataSet1.Vendor_Info' table. You can move, or remove it, as needed.
            this.vendor_InfoTableAdapter.Fill(this.dataSet1.Vendor_Info);
            // TODO: This line of code loads data into the 'dataSet1.Product_Info' table. You can move, or remove it, as needed.
            this.product_InfoTableAdapter.Fill(this.dataSet1.Product_Info);

            autonumber();

            SqlConnection con = new SqlConnection(cs);

            SqlDataAdapter sda = new SqlDataAdapter("SELECT Product_ID, Product_Name FROM Product_Info WHERE Category_ID='" + cmbcategory.SelectedValue + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            cmbprod.ValueMember = "Product_ID";
            cmbprod.DisplayMember = "Product_Name";
            cmbprod.DataSource = dt;

        }

        public void autonumber()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand comm = new SqlCommand("SELECT MAX (PO_No)+1 FROM Purchase_Info", con);
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lblponum.Text = dr[0].ToString();
                    if (lblponum.Text == "")
                    {
                        lblponum.Text = "1";
                    }

                }
            }
            else
            {
                lblponum.Text = "1";
            }
            con.Close();
        }

        private void btncart_Click(object sender, EventArgs e)
        {
            if (cmbvendor.Text == "" || cmbprod.Text == "" || txtqty.Text == "" || txtunit.Text == "" || txttotal.Text == "")
            {
                string title = "Operation Abort";
                MessageBox.Show("Please Fill all Fields in order to Cart.", title);
            }
            else
            {
                SqlConnection con = new SqlConnection(cs);
                SqlDataAdapter sda1 = new SqlDataAdapter("SELECT Product_Name FROM Product_Info WHERE Product_ID='" + cmbprod.SelectedValue + "'", con);
                DataTable tbl1 = new DataTable();
                sda1.Fill(tbl1);

                SqlDataAdapter sda2 = new SqlDataAdapter("SELECT Vendor_Name FROM Vendor_Info WHERE Vendor_ID='" + cmbvendor.SelectedValue + "'", con);
                DataTable tbl2 = new DataTable();
                sda2.Fill(tbl2);

                dr = dt.NewRow();
                dr["Ven_ID"] = cmbvendor.SelectedValue;
                dr["Ven_Name"] = tbl2.Rows[0]["Vendor_Name"].ToString();
                dr["Prod_ID"] = cmbprod.SelectedValue;
                dr["Prod_Name"] = tbl1.Rows[0]["Product_Name"].ToString();
                dr["Qty"] = txtqty.Text;
                dr["Rate"] = txtunit.Text;
                dr["Total"] = txttotal.Text;
                dr["Date"] = date1.Text;

                dt.Rows.Add(dr);
                dataGridView1.DataSource = dt;

                int sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value);
                }
                try
                {
                    decimal tot = 0;
                    for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
                    {
                        tot += Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value);
                    }
                    if (tot == 0)
                    {

                    }
                    lblamount.Text = tot.ToString();
                }
                catch
                {

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null)
            {
                string title = "Operation Aborted";
                MessageBox.Show("Unable to Create Purchase Order, there are no records in Cart.", title);
            }
            else
            {
                string mainconn = ConfigurationManager.ConnectionStrings["POS_GEN.Properties.Settings.POS_GenConnectionString"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);

                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    string sqlquery = "INSERT INTO Purchase_Info VALUES (@PONum,@VendorID,@ProductID,@qty,@UnitPrice,@TotalCost,@PurchasingDate)";
                    SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                    if (dr.IsNewRow) continue;
                    {
                        sqlcomm.Parameters.AddWithValue("@PONum", lblponum.Text);
                        sqlcomm.Parameters.AddWithValue("@VendorID", dr.Cells["Ven_ID"].Value ?? DBNull.Value);
                        sqlcomm.Parameters.AddWithValue("@ProductID", dr.Cells["Prod_ID"].Value ?? DBNull.Value);
                        sqlcomm.Parameters.AddWithValue("@qty", dr.Cells["Qty"].Value ?? DBNull.Value);
                        sqlcomm.Parameters.AddWithValue("@UnitPrice", dr.Cells["Rate"].Value ?? DBNull.Value);
                        sqlcomm.Parameters.AddWithValue("@TotalCost", dr.Cells["Total"].Value ?? DBNull.Value);
                        sqlcomm.Parameters.AddWithValue("@PurchasingDate", dr.Cells["Date"].Value ?? DBNull.Value);
                    }
                    sqlconn.Open();
                    sqlcomm.ExecuteNonQuery();
                    sqlconn.Close();

                }

                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Inventory_Info WHERE Product_ID='" + dr.Cells["Prod_ID"].Value + "'", sqlconn);
                    DataTable data = new DataTable();
                    da.Fill(data);
                    if (data.Rows.Count > 0)
                    {
                        string sqlquery = "UPDATE Inventory_Info SET Quantity=@Quantity WHERE Product_ID='" + dr.Cells["Prod_ID"].Value + "'";
                        SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                        if (dr.IsNewRow) continue;
                        {
                            double qty = Convert.ToDouble(data.Rows[0]["Quantity"].ToString()) + Convert.ToDouble(dr.Cells["Qty"].Value);
                            sqlcomm.Parameters.AddWithValue("@Quantity", qty);

                        }
                        sqlconn.Open();
                        sqlcomm.ExecuteNonQuery();
                        sqlconn.Close();
                    }
                    else
                    {
                        string sqlquery = "INSERT INTO Inventory_Info VALUES (@ProdID,@Quantity)";
                        SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                        if (dr.IsNewRow) continue;
                        {
                            sqlcomm.Parameters.AddWithValue("@ProdID", dr.Cells["Prod_ID"].Value ?? DBNull.Value);
                            sqlcomm.Parameters.AddWithValue("@Quantity", dr.Cells["Qty"].Value ?? DBNull.Value);
                        }
                        sqlconn.Open();
                        sqlcomm.ExecuteNonQuery();
                        sqlconn.Close();
                    }
                }
                string title = "Operation Completed";
                MessageBox.Show("Purchase Order Created Successfully", title);

                this.Close();
            }
        }

        private void txtunit_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txttotal.Text = (float.Parse(txtqty.Text) * float.Parse(txtunit.Text)).ToString();
            }
            catch
            {

            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.lbldatetime.Text = datetime.ToString("yyyy-MM-dd h:mm:ss tt");
        }

        private void cmbvendor_Leave(object sender, EventArgs e)
        {
            cmbcategory.Focus();
        }

        private void cmbcategory_Leave(object sender, EventArgs e)
        {
            cmbprod.Focus();
        }

        private void cmbcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);

            SqlDataAdapter sda = new SqlDataAdapter("SELECT Product_ID, Product_Name FROM Product_Info WHERE Category_ID='"+cmbcategory.SelectedValue+"'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            cmbprod.DataSource = null;
            cmbprod.ValueMember = "Product_ID";
            cmbprod.DisplayMember = "Product_Name";
            cmbprod.DataSource = dt;

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lblamount_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            InventoryView IV = new InventoryView();
            this.Dispose();
            IV.Show();
        }
    }
}
