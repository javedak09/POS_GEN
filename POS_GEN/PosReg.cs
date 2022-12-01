using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using Microsoft.Reporting.WinForms;

namespace POS_GEN
{
    public partial class PosReg : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["POS_GEN.Properties.Settings.POS_GenConnectionString"].ConnectionString;

        DataTable dc = new DataTable();

        private static List<Stream> m_streams;
        private static int m_currentPageIndex = 0;

        DataTable dt = new DataTable();
        DataRow dr;

        public PosReg()
        {
            InitializeComponent();
                        
            dt.Columns.Add("Name");
            dt.Columns.Add("Qty");
            dt.Columns.Add("Rate");
            dt.Columns.Add("Discount");
            dt.Columns.Add("Total");
            dt.Columns.Add("P_ID");

            timer1.Start();
        }

        private void PosReg_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.SalePayView' table. You can move, or remove it, as needed.
            this.SalePayViewTableAdapter.Fill(this.dataSet1.SalePayView);
            // TODO: This line of code loads data into the 'dataSet1.CustomerInfo' table. You can move, or remove it, as needed.
            this.customerInfoTableAdapter.Fill(this.dataSet1.CustomerInfo);
            // TODO: This line of code loads data into the 'dataSet1.POS_View' table. You can move, or remove it, as needed.
            this.POS_ViewTableAdapter.Fill(this.dataSet1.POS_View);
            // TODO: This line of code loads data into the 'dataSet1.Pos_Pay_Info' table. You can move, or remove it, as needed.
            this.Pos_Pay_InfoTableAdapter.Fill(this.dataSet1.Pos_Pay_Info);
            this.SalePayViewTableAdapter.Fill(this.dataSet1.SalePayView);
            txtbarcode.Focus();
            //   AllProducts();
            this.category_InfoTableAdapter.Fill(this.dataSet1.Category_Info);
            txtreturned.Enabled = false;          
          
            //   CreateDynamicButton();

            autonumber();

            //txtproddiscount.Text = "0";
            TotalItems();
            btndelete.Enabled = false;
            btnsettle.Enabled = false;
            btngenerate.Enabled = false;
        }
       
        public void AllProducts()
        {
           
        }

        public void autonumber()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand comm = new SqlCommand("SELECT MAX (Bill_No)+1 FROM POS_Info", con);
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lblbillnum.Text = dr[0].ToString();
                    if (lblbillnum.Text == "")
                    {
                        lblbillnum.Text = "1";
                    }
                }
            }
            else
            {
                lblbillnum.Text = "1";
            }
            con.Close();
        }

        public void TotalItems()
        {
            int items = dataGridView1.Rows.Count;

            if (items > 0)
            {
                lbltotalitems.Text = items.ToString();
            }
            else
            {
                lbltotalitems.Text = "0";
            }
        }

        private void CreateDynamicButton()
        {
            int i = 0;
            int x = 0;
            panelprod.Controls.Clear();
            panelprod.ResetText();

            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "SELECT Product_ID,Product_Name,Prod_Image FROM Product_Info WHERE Category_ID = '" + categorylist.SelectedValue+"' ";
            SqlCommand comm = new SqlCommand(query, con);
            SqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                Button btn = new Button();

                btn.Location = new Point(i, x);
                btn.BackColor = System.Drawing.Color.Transparent;
                btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                btn.TextImageRelation = TextImageRelation.ImageAboveText;
                btn.Font = new Font(btn.Font.FontFamily, 12, FontStyle.Bold);
                btn.ForeColor = System.Drawing.Color.Black;
                btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
                btn.FlatAppearance.BorderSize = 1;
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.Text = dr["Product_Name"].ToString();
                btn.Width = 100;
                btn.Height = 100;
                btn.Name = dr["Product_ID"].ToString();

                try
                {
                    MemoryStream ms = new MemoryStream((byte[])dr["Prod_Image"]);
                    btn.Image = new Bitmap(ms);

                    btn.Image = Image.FromStream(ms);
                    btn.Image = new Bitmap(btn.Image, btn.Size);
                }
                catch
                {

                }

                btn.Click += new System.EventHandler(this.DynamicButton_Click);
                panelprod.Controls.Add(btn);

                if (i >= 500)
                {
                    x += 140;
                    i = 0;
                }
                else
                {
                    i += 140;
                }
            }
            con.Close();
        }          

        private void DynamicButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string text = button.Text;
            string name = button.Name;

            SqlConnection con = new SqlConnection(cs);

            //SqlDataAdapter adapt = new SqlDataAdapter("SELECT Quantity FROM Inventory_Info WHERE Product_ID='" + name + "'", con);
            //DataTable datatable = new DataTable();
            //adapt.Fill(datatable);

            //if (datatable.Rows.Count == 0)
            //{
            //    string title = "Operation Aborted";
            //    MessageBox.Show("Not enough Quantity in Inventory.", title);
            //}
            //else
            //{
            //lblqty.Text = datatable.Rows[0]["Quantity"].ToString();

            SqlDataAdapter dataadapter = new SqlDataAdapter("SELECT Product_ID,Product_Name, Discount, Sale_Price FROM Product_Info WHERE Product_ID='" + name + "'", con);
            DataTable datatbl = new DataTable();
            dataadapter.Fill(datatbl);

            //double qty = Convert.ToDouble(lblqty.Text);

            //if (qty >= 1)
            //{
                if (dataGridView1.Rows.Count > 0)
                        {
                            var IsExist = false;
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (name == Convert.ToString(row.Cells[5].Value))
                                {
                                    double a, m;
                                    row.Cells[3].Value = Convert.ToString(double.Parse(row.Cells[3].Value.ToString()) + double.Parse(datatbl.Rows[0]["Discount"].ToString()));
                                    row.Cells[1].Value = Convert.ToString(1 + double.Parse(row.Cells[1].Value.ToString()));
                                    a = (Convert.ToDouble(row.Cells[dataGridView1.Columns["Qty"].Index].Value) * Convert.ToDouble(row.Cells[dataGridView1.Columns["Rate"].Index].Value));
                                    m = a - Convert.ToDouble(row.Cells[dataGridView1.Columns["Discount"].Index].Value);
                                    //n = m * Convert.ToDouble(row.Cells[dataGridView1.Columns["Discount"].Index].Value);
                                    //discount = Convert.ToDouble((a - n).ToString());
                                    row.Cells[dataGridView1.Columns["Total"].Index].Value = m;

                                    //row.Cells[2].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[2].Value));
                                    //row.Cells[dataGridView1.Columns["Total"].Index].Value = (Convert.ToDouble(row.Cells[dataGridView1.Columns["Qty"].Index].Value) * Convert.ToDouble(row.Cells[dataGridView1.Columns["Rate"].Index].Value));

                                    //double invqty = Convert.ToDouble(lblqty.Text);
                                    //double reqqty = Convert.ToDouble(row.Cells[1].Value);

                                    //if (reqqty > invqty)
                                    //{
                                    //    string title = "Operation Aborted";
                                    //    MessageBox.Show("alert(\"WARNING !! (Not Enough Quantity.)\");", title);

                                    //}

                                    IsExist = true;
                                }
                            }
                            if (!IsExist)
                            {
                                //string discounted;
                                double a, g, h;
                                bool bool1 = double.TryParse(datatbl.Rows[0]["Sale_Price"].ToString(), out a);
                                bool bool2 = double.TryParse(datatbl.Rows[0]["Discount"].ToString(), out g);
                                try
                                {
                                    h = a - g;
                                    // i = h * g;
                                    //discounted = (a - i).ToString();

                                    dr = dt.NewRow();

                                    dr["Name"] = text;
                                    //dr["Unit"] = datatbl.Rows[0]["Unit"].ToString();
                                    dr["Qty"] = 1;
                                    dr["Rate"] = datatbl.Rows[0]["Sale_Price"].ToString();
                                    dr["Discount"] = datatbl.Rows[0]["Discount"].ToString();
                                    dr["Total"] = h.ToString();
                                    dr["P_ID"] = name;
                                    dt.Rows.Add(dr);
                                    dataGridView1.DataSource = dt;
                                }
                                catch
                                {

                                }
                            }

                            string mainconn = ConfigurationManager.ConnectionStrings["POS_GEN.Properties.Settings.POS_GenConnectionString"].ConnectionString;
                            SqlConnection sqlconn = new SqlConnection(mainconn);

                            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Inventory_Info WHERE Product_ID='" + name + "'", sqlconn);
                            DataTable datat = new DataTable();
                            da.Fill(datat);

                            if (datat.Rows.Count > 0)
                            {
                                string sqlquery = "UPDATE Inventory_Info SET Quantity=@Quantity WHERE Product_ID='" + name + "'";
                                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);

                                double qty1 = Convert.ToDouble(lblqty.Text) - 1;

                                sqlcomm.Parameters.AddWithValue("@Quantity", qty1);

                                sqlconn.Open();
                                sqlcomm.ExecuteNonQuery();
                                sqlconn.Close();

                                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Quantity FROM Inventory_Info WHERE Product_ID='" + name + "'", mainconn);
                                DataTable datatabl = new DataTable();
                                adapter.Fill(datatabl);
                                lblqty.Text = datatabl.Rows[0]["Quantity"].ToString();
                            }
                        }
                        else
                        {
                            //string discounted;
                            double a, j, k;
                            bool boolean1 = double.TryParse(datatbl.Rows[0]["Sale_Price"].ToString(), out a);
                            bool boolean2 = double.TryParse(datatbl.Rows[0]["Discount"].ToString(), out j);

                            try
                            {
                                k = a - j;
                                // l = k * j;
                                //discounted = (a - l).ToString();

                                dr = dt.NewRow();

                                dr["Name"] = text;
                                //dr["Unit"] = datatbl.Rows[0]["Unit"].ToString();
                                dr["Qty"] = 1;
                                dr["Rate"] = datatbl.Rows[0]["Sale_Price"].ToString();
                                dr["Discount"] = datatbl.Rows[0]["Discount"].ToString();
                                dr["Total"] = k.ToString();
                                dr["P_ID"] = name;
                                dt.Rows.Add(dr);
                                dataGridView1.DataSource = dt;
                            }
                            catch
                            {

                            }

                            //string mainconn = ConfigurationManager.ConnectionStrings["POS_GEN.Properties.Settings.POS_GenConnectionString"].ConnectionString;
                            //SqlConnection sqlconn = new SqlConnection(mainconn);

                            //SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Inventory_Info WHERE Product_ID='" + name + "'", sqlconn);
                            //DataTable datat = new DataTable();
                            //da.Fill(datat);

                            //if (datat.Rows.Count > 0)
                            //{
                            //    string sqlquery = "UPDATE Inventory_Info SET Quantity=@Quantity WHERE Product_ID='" + name + "'";
                            //    SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);

                            //    double qty1 = Convert.ToDouble(lblqty.Text) - 1;

                            //    sqlcomm.Parameters.AddWithValue("@Quantity", qty1);

                            //    sqlconn.Open();
                            //    sqlcomm.ExecuteNonQuery();
                            //    sqlconn.Close();

                            //    SqlDataAdapter adapter = new SqlDataAdapter("SELECT Quantity FROM Inventory_Info WHERE Product_ID='" + name + "'", mainconn);
                            //    DataTable datatabl = new DataTable();
                            //    adapter.Fill(datatabl);
                            //    lblqty.Text = datatabl.Rows[0]["Quantity"].ToString();
                            //}
                        }
                            //}

                            //else
                            //{
                            //    lblqty.Text = "0";
                            //    string title = "Operation Aborted";
                            //    MessageBox.Show("There is not enough quantity in Inventory.", title);
                            //}

                    decimal sum = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                    }
                    try
                    {
                        decimal tot = 0;
                        for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
                        {
                            tot += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                        }
                        if (tot == 0)
                        {

                        }
                        lbltotal.Text = tot.ToString();
                    }
                    catch
                    {

                    }

                    // txtproddiscount.Text = "0";
                    // txtdiscount.Focus();
                    txtdiscount.Text = "0";

                    double f, b, c,hk,jk;
                    bool b1 = double.TryParse(lbltotal.Text, out f);
                    bool b2 = double.TryParse(txtdiscount.Text, out b);
                    bool b3 = double.TryParse(lblpreviousbalance.Text, out hk);

                    try
                    {
                    c = f - b;
                    //d = c * b;
                    jk = c + hk;
                    lblgrandtotal.Text = jk.ToString();
                    }
                    catch
                    {

                    }
                    txtrecieved.Text = lblgrandtotal.Text;
                    TotalItems();

                    btnsettle.Enabled = true;
                    btngenerate.Enabled = true;
                    btndelete.Enabled = true;
                    txtbarcode.Focus();
            if (cmbcustomer.Text== "Walkin")
            {
                txtrecieved.Enabled = false;
            }
            else
            {
                txtrecieved.Enabled = true;
            }

               // }
            }
        
        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "SELECT Product_Name FROM Product_Info WHERE Category_ID='" + categorylist.SelectedValue + "'";
            SqlCommand comm = new SqlCommand(query, con);
            SqlDataReader dr = comm.ExecuteReader();

            CreateDynamicButton();
            con.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblprodID.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            lblprod.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            lblquantity.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowindex);

            //try
            //{
            //    string mainconn = ConfigurationManager.ConnectionStrings["POS_GEN.Properties.Settings.POS_GenConnectionString"].ConnectionString;
            //    SqlConnection sqlconn = new SqlConnection(mainconn);

            //    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Inventory_Info WHERE Product_ID='" + lblprodID.Text + "'", sqlconn);
            //    DataTable data = new DataTable();
            //    da.Fill(data);

            //    if (data.Rows.Count > 0)
            //    {
            //        string sqlquery = "UPDATE Inventory_Info SET Quantity=@Quantity WHERE Product_ID='" + lblprodID.Text + "'";
            //        SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);

            //        double qty1 = Convert.ToDouble(data.Rows[0]["Quantity"].ToString()) + Convert.ToDouble(lblquantity.Text);

            //        sqlcomm.Parameters.AddWithValue("@Quantity", qty1);

            //        sqlconn.Open();
            //        sqlcomm.ExecuteNonQuery();
            //        sqlconn.Close();

            //        SqlDataAdapter adapt = new SqlDataAdapter("SELECT Quantity FROM Inventory_Info WHERE Product_ID='" + lblprodID.Text + "'", mainconn);
            //        DataTable datatbl = new DataTable();
            //        adapt.Fill(datatbl);
            //        lblqty.Text = datatbl.Rows[0]["Quantity"].ToString();
            //    }
            //}
            //catch
            //{

            //}

            //int sum = 0;
            //for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            //{
            //    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
            //}
            //try
            //{
            //    decimal tot = 0;
            //    for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
            //    {
            //        tot += Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);
            //    }
            //    if (tot == 0)
            //    {

            //    }
            //    lbltotal.Text = tot.ToString();
            //}
            //catch
            //{

            //}

            decimal sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
            }
            try
            {
                decimal tot = 0;
                for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
                {
                    tot += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                }
                if (tot == 0)
                {

                }
                lbltotal.Text = tot.ToString();
            }
            catch
            {

            }

            // txtproddiscount.Text = "0";
            // txtdiscount.Focus();
            txtdiscount.Text = "0";

            double f, b, c, hk, jk;
            bool b1 = double.TryParse(lbltotal.Text, out f);
            bool b2 = double.TryParse(txtdiscount.Text, out b);
            bool b3 = double.TryParse(lblpreviousbalance.Text, out hk);

            try
            {
                c = f - b;
                //d = c * b;
                jk = c + hk;
                lblgrandtotal.Text = jk.ToString();
            }
            catch
            {

            }
            txtrecieved.Text = lblgrandtotal.Text;

            if (dataGridView1.Rows.Count == 0)
            {
                btngenerate.Enabled = false;
            }
            else
            {
                btngenerate.Enabled = true;
            }

            lblprodID.Text = "";
            lblprod.Text = "";
            lblquantity.Text = "";

            btndelete.Enabled = true;
            btnsettle.Enabled = false;
            TotalItems();
        }

        private void btnsettle_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b, c;
                a = Convert.ToDouble(lblgrandtotal.Text);
                txtrecieved.Text = a.ToString();


                b = double.Parse(lblgrandtotal.Text) - double.Parse(txtrecieved.Text);
                if (a < 0)
                {
                    c = -(b);
                    txtreturned.Text = c.ToString();
                }
                else
                {
                    txtreturned.Text = b.ToString();
                }
            }
            catch
            {

            }
        }

        private void btngenerate_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                a = double.Parse(lblgrandtotal.Text) - double.Parse(txtrecieved.Text);
                if (a < 0)
                {
                    b = -(a);
                    txtreturned.Text = b.ToString();
                }
                else
                {
                    txtreturned.Text = a.ToString();
                }
            }
            catch
            {

            }

            string mainconn = ConfigurationManager.ConnectionStrings["POS_GEN.Properties.Settings.POS_GenConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);

            if (txtrecieved.Text == "")
            {
                string title = "Operation Abort";
                MessageBox.Show("Please Enter Recieved Amount.", title);
            }
            else
            {
                if (cmbcustomer.Text== "Walkin")
                {
                    string sqlquery1 = "INSERT INTO Pos_Pay_Info VALUES (@BillNo,@Previous_Balance,@TotalAmount, @discount, @grand, @RecAmount,@BalAmount,@Customer_ID,@Cust_Desc, @date)";
                    SqlCommand sqlcomm1 = new SqlCommand(sqlquery1, sqlconn);
                    sqlconn.Open();
                    sqlcomm1.Parameters.AddWithValue("@BillNo", lblbillnum.Text);
                    sqlcomm1.Parameters.AddWithValue("@Previous_Balance", lblpreviousbalance.Text);
                    sqlcomm1.Parameters.AddWithValue("@TotalAmount", lbltotal.Text);
                    sqlcomm1.Parameters.AddWithValue("@discount", txtdiscount.Text);
                    sqlcomm1.Parameters.AddWithValue("@grand", lblgrandtotal.Text);
                    sqlcomm1.Parameters.AddWithValue("@RecAmount", txtrecieved.Text);
                    sqlcomm1.Parameters.AddWithValue("@BalAmount", txtreturned.Text);
                    sqlcomm1.Parameters.AddWithValue("@Customer_ID", 1);
                    sqlcomm1.Parameters.AddWithValue("@Cust_Desc", 0);
                    sqlcomm1.Parameters.AddWithValue("@date", lbldatetime.Text);
                    sqlcomm1.ExecuteNonQuery();
                    sqlconn.Close();

                    foreach (DataGridViewRow dr in dataGridView1.Rows)
                    {
                        string query = "INSERT INTO POS_Info VALUES (@BillNo,@ProdID, @Quantity,@SalePrice,@discount,@TotalPrice, @date)";
                        SqlCommand comm = new SqlCommand(query, sqlconn);
                        if (dr.IsNewRow) continue;
                        {
                            comm.Parameters.AddWithValue("@BillNo", lblbillnum.Text);
                            comm.Parameters.AddWithValue("@ProdID", dr.Cells["P_ID"].Value ?? DBNull.Value);
                            //comm.Parameters.AddWithValue("@Unit", dr.Cells["Unit"].Value ?? DBNull.Value);
                            comm.Parameters.AddWithValue("@Quantity", dr.Cells["Qty"].Value ?? DBNull.Value);
                            comm.Parameters.AddWithValue("@SalePrice", dr.Cells["Rate"].Value ?? DBNull.Value);
                            comm.Parameters.AddWithValue("@discount", dr.Cells["Discount"].Value ?? DBNull.Value);
                            comm.Parameters.AddWithValue("@TotalPrice", dr.Cells["Total"].Value ?? DBNull.Value);
                            comm.Parameters.AddWithValue("@date", lbldatetime.Text);
                        }
                        sqlconn.Open();
                        comm.ExecuteNonQuery();
                        sqlconn.Close();
                    }
                }
                else
                {
                    string sqlquery1 = "INSERT INTO Pos_Pay_Info VALUES (@BillNo,@Previous_Balance,@TotalAmount, @discount, @grand, @RecAmount,@BalAmount,@Customer_ID,@Cust_Desc, @date)";
                    SqlCommand sqlcomm1 = new SqlCommand(sqlquery1, sqlconn);
                    sqlconn.Open();
                    sqlcomm1.Parameters.AddWithValue("@BillNo", lblbillnum.Text);
                    sqlcomm1.Parameters.AddWithValue("@Previous_Balance", lblpreviousbalance.Text);
                    sqlcomm1.Parameters.AddWithValue("@TotalAmount", lbltotal.Text);
                    sqlcomm1.Parameters.AddWithValue("@discount", txtdiscount.Text);
                    sqlcomm1.Parameters.AddWithValue("@grand", lblgrandtotal.Text);
                    sqlcomm1.Parameters.AddWithValue("@RecAmount", txtrecieved.Text);
                    sqlcomm1.Parameters.AddWithValue("@BalAmount", txtreturned.Text);
                    sqlcomm1.Parameters.AddWithValue("@Customer_ID", cmbcustomer.SelectedValue);
                    sqlcomm1.Parameters.AddWithValue("@Cust_Desc", 0);
                    sqlcomm1.Parameters.AddWithValue("@date", lbldatetime.Text);
                    sqlcomm1.ExecuteNonQuery();
                    sqlconn.Close();

                    foreach (DataGridViewRow dr in dataGridView1.Rows)
                    {
                        string query = "INSERT INTO POS_Info VALUES (@BillNo,@ProdID, @Quantity,@SalePrice,@discount,@TotalPrice, @date)";
                        SqlCommand comm = new SqlCommand(query, sqlconn);
                        if (dr.IsNewRow) continue;
                        {
                            comm.Parameters.AddWithValue("@BillNo", lblbillnum.Text);
                            comm.Parameters.AddWithValue("@ProdID", dr.Cells["P_ID"].Value ?? DBNull.Value);
                            //comm.Parameters.AddWithValue("@Unit", dr.Cells["Unit"].Value ?? DBNull.Value);
                            comm.Parameters.AddWithValue("@Quantity", dr.Cells["Qty"].Value ?? DBNull.Value);
                            comm.Parameters.AddWithValue("@SalePrice", dr.Cells["Rate"].Value ?? DBNull.Value);
                            comm.Parameters.AddWithValue("@discount", dr.Cells["Discount"].Value ?? DBNull.Value);
                            comm.Parameters.AddWithValue("@TotalPrice", dr.Cells["Total"].Value ?? DBNull.Value);
                            comm.Parameters.AddWithValue("@date", lbldatetime.Text);
                        }
                        sqlconn.Open();
                        comm.ExecuteNonQuery();
                        sqlconn.Close();
                    }           
                }
                btngenerate.Enabled = false;
                panelprod.Enabled = false;
                btndelete.Enabled = false;
                dataGridView1.Enabled = false;
            }

            string sql1 = "SELECT * FROM POS_View WHERE Bill_No='" + lblbillnum.Text + "'";
            string sql2 = "SELECT * FROM Pos_Pay_Info WHERE Bill_No='" + lblbillnum.Text + "'";
            var dt1 = GetDataTable1(sql1);
            var dt2 = GetDataTable2(sql2);
            LocalReport report = new LocalReport();
            //string path = Path.GetDirectoryName(Application.ExecutablePath);         
            //string fullpath = Path.GetDirectoryName(Application.ExecutablePath).Remove(path.Length - 10) + @"\PosRep.rdlc";
            //report.ReportPath = fullpath;
            //report.ReportPath = path;
            report.DataSources.Add(new ReportDataSource("DataSet1", dt1));
            report.DataSources.Add(new ReportDataSource("DataSet2", dt2));

            this.POS_ViewTableAdapter.FillBybillno(this.dataSet1.POS_View, int.Parse(lblbillnum.Text));
            this.Pos_Pay_InfoTableAdapter.FillBybillno(this.dataSet1.Pos_Pay_Info, int.Parse(lblbillnum.Text));
            this.SalePayViewTableAdapter.FillBybillno(this.dataSet1.SalePayView, int.Parse(lblbillnum.Text));
            //this.reportViewer1.RefreshReport();

            report.ReportPath = "C:\\Users\\Mirza Ghazanfar Baig\\Desktop\\New folder\\report\\PosRep.rdlc";
            PrintToPrinter(report);
            
            PosReg PR = new PosReg();
            this.Dispose();
            PR.Show();
        }

        private void txtrecieved_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                a = double.Parse(lblgrandtotal.Text) - double.Parse(txtrecieved.Text);
                if (a < 0)
                {
                    b = -(a);
                    txtreturned.Text = b.ToString();
                }
                else
                {
                    txtreturned.Text = a.ToString();
                }
            }
            catch
            {

            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            PosReg PR = new PosReg();
            this.Dispose();
            PR.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.lbldatetime.Text = datetime.ToString("yyyy-MM-dd h:mm:ss tt");
        }

        private void txtbarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{ENTER}");

                Button button = sender as Button;

                SqlConnection con = new SqlConnection(cs);
                SqlDataAdapter adapt1 = new SqlDataAdapter("SELECT Product_ID, Product_Code, Product_Name FROM Product_Info WHERE Barcode='" + txtbarcode.Text + "'", con);
                DataTable datatable1 = new DataTable();
                adapt1.Fill(datatable1);              

                if (datatable1.Rows.Count == 0)
                {
                    string title = "Operation Aborted";
                    MessageBox.Show("No Products registered against this Product Code.", title);
                    txtbarcode.Text = "";
                    txtbarcode.Focus();

                }
                else
                {
                    string text = datatable1.Rows[0]["Product_Name"].ToString();
                    string name = datatable1.Rows[0]["Product_ID"].ToString();

                    SqlDataAdapter adapt = new SqlDataAdapter("SELECT Quantity FROM Inventory_Info WHERE Product_ID='" + name + "'", con);
                    DataTable datatable = new DataTable();
                    adapt.Fill(datatable);

                    if (datatable.Rows.Count == 0)
                    {
                        string title = "Operation Aborted";
                        MessageBox.Show("Not enough Quantity in Inventory.", title);
                    }
                    else
                    {
                        lblqty.Text = datatable.Rows[0]["Quantity"].ToString();

                        SqlDataAdapter dataadapter = new SqlDataAdapter("SELECT Product_ID,Product_Name, Discount, Sale_Price FROM Product_Info WHERE Product_ID='" + name + "'", con);
                        DataTable datatbl = new DataTable();
                        dataadapter.Fill(datatbl);

                        double qty = Convert.ToDouble(lblqty.Text);

                        if (qty >= 1)
                        {
                            if (dataGridView1.Rows.Count > 0)
                            {
                                var IsExist = false;
                                foreach (DataGridViewRow row in dataGridView1.Rows)
                                {
                                    if (name == Convert.ToString(row.Cells[5].Value))
                                    {
                                        double a, m;
                                        row.Cells[3].Value = Convert.ToString(double.Parse(row.Cells[3].Value.ToString()) + double.Parse(datatbl.Rows[0]["Discount"].ToString()));
                                        row.Cells[1].Value = Convert.ToString(1 + double.Parse(row.Cells[1].Value.ToString()));
                                        a = (Convert.ToDouble(row.Cells[dataGridView1.Columns["Qty"].Index].Value) * Convert.ToDouble(row.Cells[dataGridView1.Columns["Rate"].Index].Value));
                                        m = a - Convert.ToDouble(row.Cells[dataGridView1.Columns["Discount"].Index].Value);
                                        row.Cells[dataGridView1.Columns["Total"].Index].Value = m;
                                        IsExist = true;
                                    }
                                }
                                if (!IsExist)
                                {
                                    //string discounted;
                                    double a, g, h;
                                    bool bool1 = double.TryParse(datatbl.Rows[0]["Sale_Price"].ToString(), out a);
                                    bool bool2 = double.TryParse(datatbl.Rows[0]["Discount"].ToString(), out g);

                                    try
                                    {
                                        h = a - g;
                                        // i = h * g;
                                        //discounted = (a - i).ToString();

                                        dr = dt.NewRow();

                                        dr["Name"] = text;
                                        //dr["Unit"] = datatbl.Rows[0]["Unit"].ToString();
                                        dr["Qty"] = 1;
                                        dr["Rate"] = datatbl.Rows[0]["Sale_Price"].ToString();
                                        dr["Discount"] = datatbl.Rows[0]["Discount"].ToString();
                                        dr["Total"] = h.ToString();
                                        dr["P_ID"] = name;
                                        dt.Rows.Add(dr);
                                        dataGridView1.DataSource = dt;
                                    }
                                    catch
                                    {

                                    }
                                }

                                //string mainconn = ConfigurationManager.ConnectionStrings["POS_GEN.Properties.Settings.POS_GenConnectionString"].ConnectionString;
                                //SqlConnection sqlconn = new SqlConnection(mainconn);

                                //SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Inventory_Info WHERE Product_ID='" + name + "'", sqlconn);
                                //DataTable datat = new DataTable();
                                //da.Fill(datat);

                                //if (datat.Rows.Count > 0)
                                //{
                                //    string sqlquery = "UPDATE Inventory_Info SET Quantity=@Quantity WHERE Product_ID='" + name + "'";
                                //    SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);

                                //    double qty1 = Convert.ToDouble(lblqty.Text) - 1;

                                //    sqlcomm.Parameters.AddWithValue("@Quantity", qty1);

                                //    sqlconn.Open();
                                //    sqlcomm.ExecuteNonQuery();
                                //    sqlconn.Close();

                                //    SqlDataAdapter adapter = new SqlDataAdapter("SELECT Quantity FROM Inventory_Info WHERE Product_ID='" + name + "'", mainconn);
                                //    DataTable datatabl = new DataTable();
                                //    adapter.Fill(datatabl);
                                //    lblqty.Text = datatabl.Rows[0]["Quantity"].ToString();
                                //}

                            }
                            else
                            {
                                //string discounted;
                                double a, j, k;
                                bool boolean1 = double.TryParse(datatbl.Rows[0]["Sale_Price"].ToString(), out a);
                                bool boolean2 = double.TryParse(datatbl.Rows[0]["Discount"].ToString(), out j);

                                try
                                {
                                    k = a - j;
                                    // l = k * j;
                                    //discounted = (a - l).ToString();

                                    dr = dt.NewRow();

                                    dr["Name"] = text;
                                    //dr["Unit"] = datatbl.Rows[0]["Unit"].ToString();
                                    dr["Qty"] = 1;
                                    dr["Rate"] = datatbl.Rows[0]["Sale_Price"].ToString();
                                    dr["Discount"] = datatbl.Rows[0]["Discount"].ToString();
                                    dr["Total"] = k.ToString();
                                    dr["P_ID"] = name;
                                    dt.Rows.Add(dr);
                                    dataGridView1.DataSource = dt;
                                }
                                catch
                                {

                                }

                                //string mainconn = ConfigurationManager.ConnectionStrings["POS_GEN.Properties.Settings.POS_GenConnectionString"].ConnectionString;
                                //SqlConnection sqlconn = new SqlConnection(mainconn);

                                //SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Inventory_Info WHERE Product_ID='" + name + "'", sqlconn);
                                //DataTable datat = new DataTable();
                                //da.Fill(datat);

                                //if (datat.Rows.Count > 0)
                                //{
                                //    string sqlquery = "UPDATE Inventory_Info SET Quantity=@Quantity WHERE Product_ID='" + name + "'";
                                //    SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);

                                //    double qty1 = Convert.ToDouble(lblqty.Text) - 1;

                                //    sqlcomm.Parameters.AddWithValue("@Quantity", qty1);

                                //    sqlconn.Open();
                                //    sqlcomm.ExecuteNonQuery();
                                //    sqlconn.Close();

                                //    SqlDataAdapter adapter = new SqlDataAdapter("SELECT Quantity FROM Inventory_Info WHERE Product_ID='" + name + "'", mainconn);
                                //    DataTable datatabl = new DataTable();
                                //    adapter.Fill(datatabl);
                                //    lblqty.Text = datatabl.Rows[0]["Quantity"].ToString();
                                //}
                            } 
                        }

                        else
                        {
                            lblqty.Text = "0";
                            string title = "Operation Aborted";
                            MessageBox.Show("There is not enough quantity in Inventory.", title);
                        }

                        decimal sum = 0;
                        for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                        {
                            sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                        }
                        try
                        {
                            decimal tot = 0;
                            for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
                            {
                                tot += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                            }
                            if (tot == 0)
                            {

                            }
                            lbltotal.Text = tot.ToString();
                        }
                        catch
                        {

                        }

                        //txtproddiscount.Text = "0";
                     //   txtdiscount.Focus();
                        txtdiscount.Text = "0";

                        double f, b, c, d, l;
                        bool b1 = double.TryParse(lbltotal.Text, out f);
                        bool b3 = double.TryParse(lblpreviousbalance.Text, out d);
                        bool b2 = double.TryParse(txtdiscount.Text, out b);

                        try
                        {
                            c = f + d;
                            l = c - b;
                            lblgrandtotal.Text = l.ToString();
                        }
                        catch
                        {

                        }

                        TotalItems();
                        btnsettle.Enabled = true;
                        btngenerate.Enabled = true;
                        btndelete.Enabled = true;
                    }
                    txtbarcode.Text = "";
                    txtbarcode.Focus();
                }               
            }
            //txtbarcode.Text = "";
            txtbarcode.Focus();
        }

        private void button_click(object sender, EventArgs e)
        {
            //Button button = (Button)sender;
            //txtrecieved.Text = txtrecieved.Text + button.Text;

            //try
            //{

            //    double a, b;
            //    a = double.Parse(lblgrandtotal.Text) - double.Parse(txtrecieved.Text);
            //    if (a < 0)
            //    {
            //        b = -(a);
            //        txtreturned.Text = b.ToString();
            //    }
            //    else
            //    {
            //        txtreturned.Text = a.ToString();
            //    }
            //}
            //catch
            //{

            //}
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtrecieved.Clear();
            txtreturned.Clear();
        }

         // PRINT INFORMATION POS RECEIPT----------------------------


        //private void btnprint_Click(object sender, EventArgs e)
        //{
        //    string sql1 = "SELECT * FROM POS_View WHERE Bill_No='" + lblbillnum.Text + "'";
        //    string sql2 = "SELECT * FROM Pos_Pay_Info WHERE Bill_No='" + lblbillnum.Text + "'";
        //    var dt1 = GetDataTable1(sql1);
        //    var dt2 = GetDataTable2(sql2);
        //    LocalReport report = new LocalReport();
        //    string path = Path.GetDirectoryName(Application.ExecutablePath);
        //    string fullpath = Path.GetDirectoryName(Application.ExecutablePath).Remove(path.Length - 10) + @"\PosRep.rdlc";
        //    report.ReportPath = fullpath;
        //    report.DataSources.Add(new ReportDataSource("DataSet1", dt1));
        //    report.DataSources.Add(new ReportDataSource("DataSet2", dt2));

        //    PrintToPrinter(report);
        //}

        public DataTable GetDataTable1(string sql1)
        {
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["POS_GEN.Properties.Settings.POS_GenConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(constr);
                var dt1 = new DataTable();
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(sql1, con);
                adapt.Fill(dt1);
                con.Close();
                return dt1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable GetDataTable2(string sql2)
        {
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["POS_GEN.Properties.Settings.POS_GenConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(constr);
                var dt2 = new DataTable();
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(sql2, con);
                adapt.Fill(dt2);
                con.Close();
                return dt2;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // PRINT SETTINGS===========================

        public static void PrintToPrinter(LocalReport report)
        {
            try
            {
                Export(report);
            }
            catch
            {
                string title = "Operation Aborted";
                MessageBox.Show("Error: cannot find the default printer 1.", title);
            }
        }

        public static void Export(LocalReport report, bool print = true)
        {
            try
            {
                string deviceInfo =
             @"<DeviceInfo>
                <OutputFormat>EMF</OutputFormat>
                <PageWidth>3.5in</PageWidth>
                <PageHeight>8in</PageHeight>
                <MarginTop>0in</MarginTop>
                <MarginLeft>0in</MarginLeft>
                <MarginRight>0in</MarginRight>
                <MarginBottom>0in</MarginBottom>
            </DeviceInfo>";



                Warning[] warnings;
                m_streams = new List<Stream>();
                report.Render("Image", deviceInfo, CreateStream, out warnings);
                foreach (Stream stream in m_streams)
                    stream.Position = 0;

                if (print)
                {
                    Print();
                }
            }
            catch
            {
                string title = "Operation Aborted";
                MessageBox.Show("Error: cannot find the default printer 2.", title);
            }
        }

        public static void Print()
        {
            try
            {
                if (m_streams == null || m_streams.Count == 0)
                    throw new Exception("Error: no stream to print.");
                PrintDocument printDoc = new PrintDocument();
                if (!printDoc.PrinterSettings.IsValid)
                {
                    // throw new Exception("Error: cannot find the default printer.");
                    string title = "Operation Aborted";
                    MessageBox.Show("Error: cannot find the default printer 3.", title);
                }
                else
                {
                    printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                    m_currentPageIndex = 0;
                    printDoc.Print();
                }
            }
            catch
            {
                string title = "Operation Aborted";
                MessageBox.Show("Error: cannot find the default printer 4.", title);
            }
        }

        public static Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }

        public static void PrintPage(object sender, PrintPageEventArgs ev)
        {
            try
            {
                Metafile pageImage = new
                Metafile(m_streams[m_currentPageIndex]);

                // Adjust rectangular area with printer margins.
                Rectangle adjustedRect = new Rectangle(
                ev.PageBounds.Left - (int)ev.PageSettings.HardMarginX,
                ev.PageBounds.Top - (int)ev.PageSettings.HardMarginY,
                ev.PageBounds.Width,
                ev.PageBounds.Height);

                // Draw a white background for the report
                ev.Graphics.FillRectangle(Brushes.White, adjustedRect);

                // Draw the report content
                ev.Graphics.DrawImage(pageImage, adjustedRect);

                // Prepare for the next page. Make sure we haven't hit the end.
                m_currentPageIndex++;
                ev.HasMorePages = (m_currentPageIndex < m_streams.Count);

            }
            catch
            {
                string title = "Operation Aborted";
                MessageBox.Show("Error: cannot find the default printer 5.", title);
            }
        }

        public static void DisposePrint()
        {
            try
            {
                if (m_streams != null)
                {
                    foreach (Stream stream in m_streams)
                        stream.Close();
                    m_streams = null;
                }
            }
            catch
            {
                string title = "Operation Aborted";
                MessageBox.Show("Error: cannot find the default printer 6.", title);
            }
        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            //double a, b, c;
            //bool b1 = double.TryParse(lbltotal.Text, out a);
            //bool b2 = double.TryParse(txtdiscount.Text, out b);

            //try
            //{
            //    c = a - b;
            //  //  d = c * b;
            //    lblgrandtotal.Text = c.ToString();
            double f, b, c, d, a;
            bool b1 = double.TryParse(lbltotal.Text, out f);
            bool b3 = double.TryParse(lblpreviousbalance.Text, out d);
            bool b2 = double.TryParse(txtdiscount.Text, out b);

            try
            {
                c = f + d;
                a = c - b;
                lblgrandtotal.Text = a.ToString();
            }
            catch
            {

            }
        }

        private void txtbarcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbarcode_Leave(object sender, EventArgs e)
        {
          //  txtdiscount.Focus();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[dataGridView1.Columns["Total"].Index].Value = (Convert.ToDouble(row.Cells[dataGridView1.Columns["Qty"].Index].Value) * Convert.ToDouble(row.Cells[dataGridView1.Columns["Rate"].Index].Value));
            }

            decimal sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
            }
            try
            {
                decimal tot = 0;
                for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
                {
                    tot += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                }
                if (tot == 0)
                {

                }
                lbltotal.Text = tot.ToString();
            }
            catch
            {

            }
            //   txtdiscount.Focus();
            txtdiscount.Text = "0";

            double f, b, c, d, a;
            bool b1 = double.TryParse(lbltotal.Text, out f);
            bool b3 = double.TryParse(lblpreviousbalance.Text, out d);
            bool b2 = double.TryParse(txtdiscount.Text, out b);

            try
            {
                c = f + d;
                a = c - b;
                lblgrandtotal.Text = a.ToString();
            }
            catch
            {

            }
            TotalItems();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CreateDynamicButton();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddCustomer AC = new AddCustomer();
            this.Dispose();
            AC.Show();           
        }

        private void cmbcustomer_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string prevquery = "SELECT TOP 1 Balance FROM Pos_Pay_Info WHERE CustomerID='" + cmbcustomer.SelectedValue + "' ORDER BY Pay_ID DESC";
            SqlCommand cmd1 = new SqlCommand(prevquery, con);
            SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
            DataTable prevdt = new DataTable();
            sda1.Fill(prevdt);

            if (prevdt.Rows.Count > 0)
            {
                lblpreviousbalance.Text = prevdt.Rows[0]["Balance"].ToString();
            }
            else
            {
                lblpreviousbalance.Text = "0";
            }
            double f, b, c, d, a;
            bool b1 = double.TryParse(lbltotal.Text, out f);
            bool b3 = double.TryParse(lblpreviousbalance.Text, out d);
            bool b2 = double.TryParse(txtdiscount.Text, out b);

            try
            {
                c = f + d;
                a = c - b;
                lblgrandtotal.Text = a.ToString();
                txtrecieved.Text = lblgrandtotal.Text;

            }
            catch
            {

            }

            try
            {
                if (cmbcustomer.Text == "Walkin")
                {
                    txtrecieved.Enabled = false;
                }
                else
                {
                    txtrecieved.Enabled = true;
                }
            }
            catch 
            {

                string title = "Operation Aborted";
                MessageBox.Show("...", title);
            }
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //// TOKEN PRINT INFORMATION

        //private void btnprinttoken_Click(object sender, EventArgs e)
        //{
        //    string sql3 = "SELECT * FROM POS_VIEW WHERE Bill_No='" + txtbillno.Text + "'";
        //    var dt3 = GetDataTable1(sql3);
        //    LocalReport report = new LocalReport();
        //    string path = Path.GetDirectoryName(Application.ExecutablePath);
        //    string fullpath = Path.GetDirectoryName(Application.ExecutablePath).Remove(path.Length - 10) + @"\TokenRep.rdlc";
        //    report.ReportPath = fullpath;
        //    report.DataSources.Add(new ReportDataSource("DataSet1", dt3));

        //    PrintToPrinter(report);
        //}


        //public DataTable GetDataTableToken(string sql3)
        //{
        //    try
        //    {
        //        string constr = ConfigurationManager.ConnectionStrings["FAST_POS.Properties.Settings.FastPOSConnectionString"].ConnectionString;
        //        SqlConnection con = new SqlConnection(constr);
        //        var dt3 = new DataTable();
        //        con.Open();
        //        SqlDataAdapter sda = new SqlDataAdapter(sql3, con);
        //        sda.Fill(dt3);
        //        con.Close();
        //        return dt3;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);

        //    }

        //} 

    }
}
