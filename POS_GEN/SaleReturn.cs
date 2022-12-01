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
    public partial class SaleReturn : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["POS_GEN.Properties.Settings.POS_GenConnectionString"].ConnectionString;
        public SaleReturn()
        {
            InitializeComponent();

            timer1.Start();
        }

        private void SaleReturn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Product_Info' table. You can move, or remove it, as needed.
            this.product_InfoTableAdapter.Fill(this.dataSet1.Product_Info);
            // TODO: This line of code loads data into the 'dataSet1.Pos_Pay_Info' table. You can move, or remove it, as needed.
            //this.pos_Pay_InfoTableAdapter.Fill(this.dataSet1.Pos_Pay_Info);
            // TODO: This line of code loads data into the 'dataSet1.POS_Info' table. You can move, or remove it, as needed.
           // this.pOS_InfoTableAdapter.Fill(this.dataSet1.POS_Info);
            // TODO: This line of code loads data into the 'dataSet1.POS_View' table. You can move, or remove it, as needed.
            this.pOS_ViewTableAdapter.Fill(this.dataSet1.POS_View);

            btnreturn.Enabled = false;

            sale_IDTextBox.Enabled = false;
            bill_NoTextBox.Enabled = false;
            cmbproduct.Enabled = false;
            //unitTextBox.Enabled = false;
            quantityTextBox.Enabled = false;
            //unitTextBox.Enabled = false;
            uPriceTextBox.Enabled = false;
            discountTextBox.Enabled = false;
            tPriceTextBox.Enabled = false;
            reg_DateDateTimePicker.Enabled = false;

            pay_IDTextBox.Enabled = false;
            bill_NoTextBox1.Enabled = false;
            total_AmountTextBox.Enabled = false;
            discountTextBox1.Enabled = false;
            grand_AmountTextBox.Enabled = false;
            rec_AmountTextBox.Enabled = false;
            balanceTextBox.Enabled = false;
            customerIDTextBox.Enabled = false;
            cust_DescTextBox.Enabled = false;
            reg_DateDateTimePicker1.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            this.pOS_InfoTableAdapter.FillByid(this.dataSet1.POS_Info, int.Parse(sale_IDLabel2.Text));

            this.pos_Pay_InfoTableAdapter.FillBybillno(this.dataSet1.Pos_Pay_Info,int.Parse(bill_NoTextBox.Text));

            btnreturn.Enabled = true;
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            double a, b, c;
            bool b1 = double.TryParse(tPriceTextBox.Text, out a);
            bool b2 = double.TryParse(grand_AmountTextBox.Text, out b);

            try
            {
                c = b - a;
                grand_AmountTextBox.Text = c.ToString();
                rec_AmountTextBox.Text = c.ToString();
            }
            catch
            {

            }

            string mainconn = ConfigurationManager.ConnectionStrings["POS_GEN.Properties.Settings.POS_GenConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);

            string sqlquery1 = "INSERT INTO Sale_Log VALUES (@BillNo,@ProdID,@qty,@unitprice,@discount,@totalprice,@saledate,@returnDate)";
            SqlCommand sqlcomm1 = new SqlCommand(sqlquery1, sqlconn);
            sqlconn.Open();
            sqlcomm1.Parameters.AddWithValue("@BillNo", bill_NoTextBox.Text);
            sqlcomm1.Parameters.AddWithValue("@ProdID", cmbproduct.Text);
            sqlcomm1.Parameters.AddWithValue("@qty", quantityTextBox.Text);
            sqlcomm1.Parameters.AddWithValue("@unitprice", uPriceTextBox.Text);
            sqlcomm1.Parameters.AddWithValue("@discount", discountTextBox.Text);
            sqlcomm1.Parameters.AddWithValue("@totalprice", tPriceTextBox.Text);
            sqlcomm1.Parameters.AddWithValue("@saledate", reg_DateDateTimePicker.Text);
            sqlcomm1.Parameters.AddWithValue("@returnDate", lbldatetime.Text);
            sqlcomm1.ExecuteNonQuery();
            sqlconn.Close();

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


            if (total_AmountTextBox.Text == "0")
            {
                pos_Pay_InfoBindingSource.RemoveCurrent();

                pos_Pay_InfoBindingSource.EndEdit();
                pos_Pay_InfoTableAdapter.Update(dataSet1.Pos_Pay_Info);
                dataSet1.Pos_Pay_Info.AcceptChanges();
            }
            else
            {
                pos_Pay_InfoBindingSource.EndEdit();
                pos_Pay_InfoTableAdapter.Update(dataSet1.Pos_Pay_Info);
                dataSet1.Pos_Pay_Info.AcceptChanges();
            }

            pOS_InfoBindingSource.RemoveCurrent();

            pOS_InfoBindingSource.EndEdit();
            pOS_InfoTableAdapter.Update(dataSet1.POS_Info);
            dataSet1.POS_Info.AcceptChanges();

            string title = "Operation Completed";
            MessageBox.Show("Sale Returned Successfully", title);

            this.pOS_ViewTableAdapter.Fill(this.dataSet1.POS_View);

            pay_IDTextBox.Text = "";
            bill_NoTextBox1.Text = "";
            total_AmountTextBox.Text = "";
            rec_AmountTextBox.Text = "";
            balanceTextBox.Text = "";
            cust_DescTextBox.Text = "";
            customerIDTextBox.Text = "";
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            this.pOS_ViewTableAdapter.FillBybillno(this.dataSet1.POS_View,int.Parse(txtsearchbill.Text));

        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            this.pOS_ViewTableAdapter.Fill(this.dataSet1.POS_View);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.lbldatetime.Text = datetime.ToString("yyyy-MM-dd h:mm:ss tt");
        }

        private void rec_AmountTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {

                balanceTextBox.Text = (double.Parse(grand_AmountTextBox.Text) - double.Parse(rec_AmountTextBox.Text)).ToString();

            }
            catch
            {

            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
