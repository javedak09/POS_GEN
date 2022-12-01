using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_GEN
{
    public partial class ProductReg : Form
    {
        public ProductReg()
        {
            InitializeComponent();
        }

        private void product_InfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.product_InfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void ProductReg_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Category_Info' table. You can move, or remove it, as needed.
            this.category_InfoTableAdapter.Fill(this.dataSet1.Category_Info);
            // TODO: This line of code loads data into the 'dataSet1.Product_Info' table. You can move, or remove it, as needed.
            this.product_InfoTableAdapter.Fill(this.dataSet1.Product_Info);
            warehouseComboBox.Enabled = false;
            barcodeTextBox.Enabled = false;
            product_IDTextBox.Enabled = false;
            product_CodeTextBox.Enabled = false;
            product_NameTextBox.Enabled = false;
            discountTextBox.Enabled = false;
            sale_PriceTextBox.Enabled = false;
            cmbcategory.Enabled = false;
            btnupload.Enabled = false;
            btnsave.Enabled = false;
            btnadd.Focus();
        }

        private void product_InfoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.product_InfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                discountTextBox.Text = "0";
                barcodeTextBox.Text = "0";

                warehouseComboBox.Enabled = true;
                product_CodeTextBox.Enabled = true;
                product_NameTextBox.Enabled = true;
                discountTextBox.Enabled = true;
                sale_PriceTextBox.Enabled = true;
                cmbcategory.Enabled = true;
                btnupload.Enabled = true;
                barcodeTextBox.Enabled = true;

                btnadd.Enabled = false;
                btnsave.Enabled = true;
                btnedit.Enabled = false;
                btndelete.Enabled = false;

                product_InfoBindingSource.AddNew();

                product_CodeTextBox.Focus();
            }
            catch 
            {

               
            }
          
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            discountTextBox.Text = "0";
            barcodeTextBox.Text = "0";
            if (product_CodeTextBox.Text==""||product_NameTextBox.Text==""||cmbcategory.Text=="")
            {
                string title1 = "Error";
                MessageBox.Show("Fill all fields in order to save records.", title1);
            }
            else
            {
               
                warehouseComboBox.Enabled = false;
                product_CodeTextBox.Enabled = false;
                product_NameTextBox.Enabled = false;
                discountTextBox.Enabled = false;
                sale_PriceTextBox.Enabled = false;
                cmbcategory.Enabled = false;
                btnupload.Enabled = false;
                barcodeTextBox.Enabled = false;

                btnadd.Enabled = true;
                btnsave.Enabled = false;
                btnedit.Enabled = true;
                btndelete.Enabled = true;

                product_InfoBindingSource.EndEdit();
                product_InfoTableAdapter.Update(dataSet1.Product_Info);
                dataSet1.Product_Info.AcceptChanges();

                string title = "Operation Completed";
                MessageBox.Show("Record Saved/ Updated Successfully.", title);
            }
          
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                warehouseComboBox.Enabled = true;
                product_CodeTextBox.Enabled = true;
                product_NameTextBox.Enabled = true;
                discountTextBox.Enabled = true;
                sale_PriceTextBox.Enabled = true;
                cmbcategory.Enabled = true;
                btnupload.Enabled = true;
                barcodeTextBox.Enabled = true;

                btnadd.Enabled = false;
                btnsave.Enabled = true;
                btnedit.Enabled = false;
                btndelete.Enabled = false;
            }
            catch 
            {

               
            }
           
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                product_InfoBindingSource.RemoveCurrent();

                product_InfoBindingSource.EndEdit();
                product_InfoTableAdapter.Update(dataSet1.Product_Info);
                dataSet1.Product_Info.AcceptChanges();

                string title = "Error";
                MessageBox.Show("Item in use...", title);
            }
            catch 
            {

                string title = "Operation Completed";
                MessageBox.Show("Record Deleted Successfully.", title);
            }
         
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbcategory_Leave(object sender, EventArgs e)
        {
            btnsave.Focus();
        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opnfd = new OpenFileDialog();
                opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;.*.png;)|*.jpg;*.jpeg;.*.gif;.*.png;";
                if (opnfd.ShowDialog() == DialogResult.OK)
                {
                    prod_ImagePictureBox.Image = new Bitmap(opnfd.FileName);
                }
            }
            catch 
            {
                string title = "error";
                MessageBox.Show("only (png),(jpg)(gif)type you can upload here.", title);

            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductReg pr = new ProductReg();
            this.Dispose();
            pr.Show();
        }
    }
}
