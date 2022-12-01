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
    public partial class InventoryView : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["POS_GEN.Properties.Settings.POS_GenConnectionString"].ConnectionString;

        public InventoryView()
        {
            InitializeComponent();
        }

        private void InventoryView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Category_Info' table. You can move, or remove it, as needed.
            this.category_InfoTableAdapter.Fill(this.dataSet1.Category_Info);
            // TODO: This line of code loads data into the 'dataSet1.Inventory_View' table. You can move, or remove it, as needed.
            this.inventory_ViewTableAdapter.Fill(this.dataSet1.Inventory_View);

            foreach(DataGridViewRow dr in inventory_ViewDataGridView.Rows)
            {
                if(Convert.ToDouble(dr.Cells[2].Value)< 5)
                {
                    dr.DefaultCellStyle.BackColor = Color.Red;

                    string title = "Warning!";
                    string msg = "'" + dr.Cells[1].Value + "' quantity in less than 5.";
                    MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }

            cmbsearch.Enabled = false;
            txtsearch.Enabled = false;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cmbsearch.Enabled = false;
            txtsearch.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            cmbsearch.Enabled = false;
            txtsearch.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cmbsearch.Enabled = true;
            txtsearch.Enabled = false;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                this.inventory_ViewTableAdapter.FillByname(this.dataSet1.Inventory_View, txtsearch.Text);

                foreach (DataGridViewRow dr in inventory_ViewDataGridView.Rows)
                {
                    if (Convert.ToDouble(dr.Cells[2].Value) < 5)
                    {
                        dr.DefaultCellStyle.BackColor = Color.Red;
                    }

                }
            }
            else if (radioButton3.Checked == true)
            {
                this.inventory_ViewTableAdapter.FillBycode(this.dataSet1.Inventory_View, txtsearch.Text);

                foreach (DataGridViewRow dr in inventory_ViewDataGridView.Rows)
                {
                    if (Convert.ToDouble(dr.Cells[2].Value) < 5)
                    {
                        dr.DefaultCellStyle.BackColor = Color.Red;
                    }

                }
            }

            else if (radioButton2.Checked == true)
            {
                this.inventory_ViewTableAdapter.FillBycategory(this.dataSet1.Inventory_View, cmbsearch.Text);

                foreach (DataGridViewRow dr in inventory_ViewDataGridView.Rows)
                {
                    if (Convert.ToDouble(dr.Cells[2].Value) < 5)
                    {
                        dr.DefaultCellStyle.BackColor = Color.Red;
                    }

                }
            }
            else
            {
                string title = "Operation Aborted";
                MessageBox.Show("Please Select any Filter in order to Search the Record.", title);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PurchaseReg PR = new PurchaseReg();
            this.Dispose();
            PR.Show();
        }
    }
}
