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
    public partial class CategoryReg : Form
    {
        public CategoryReg()
        {
            InitializeComponent();
        }

        private void category_InfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.category_InfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void CategoryReg_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Category_Info' table. You can move, or remove it, as needed.
            this.category_InfoTableAdapter.Fill(this.dataSet1.Category_Info);

            category_IDTextBox.Enabled = false;
            category_NameTextBox.Enabled = false;

            btnsave.Enabled = false;
            btnadd.Focus();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                category_NameTextBox.Enabled = true;

                btnadd.Enabled = false;
                btnsave.Enabled = true;
                btnedit.Enabled = false;
                btndelete.Enabled = false;

                btnfirst.Enabled = false;
                btnnext.Enabled = false;
                btnprevious.Enabled = false;
                btnlast.Enabled = false;

                category_InfoBindingSource.AddNew();
                category_NameTextBox.Focus();
            }
            catch  
            {

                
            }
          
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (category_NameTextBox.Text=="")
                {
                    string title = "Error";
                    MessageBox.Show("Fill all fields in order to save records.", title);
                }
                else
                {
                    category_NameTextBox.Enabled = false;

                    btnadd.Enabled = true;
                    btnsave.Enabled = false;
                    btnedit.Enabled = true;
                    btndelete.Enabled = true;

                    btnfirst.Enabled = true;
                    btnnext.Enabled = true;
                    btnprevious.Enabled = true;
                    btnlast.Enabled = true;

                    category_InfoBindingSource.EndEdit();
                    category_InfoTableAdapter.Update(dataSet1.Category_Info);
                    dataSet1.Category_Info.AcceptChanges();

                    string title = "Operation Completed";
                    MessageBox.Show("Record Saved/ Updated Successfully.", title);
                }
               
            }
            catch 
            {

                
            }
           
            
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                category_NameTextBox.Enabled = true;

                btnadd.Enabled = false;
                btnsave.Enabled = true;
                btnedit.Enabled = false;
                btndelete.Enabled = false;

                btnfirst.Enabled = false;
                btnnext.Enabled = false;
                btnprevious.Enabled = false;
                btnlast.Enabled = false;
            }
            catch 
            {

               
            }
           
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                category_InfoBindingSource.RemoveCurrent();

                category_InfoBindingSource.EndEdit();
                category_InfoTableAdapter.Update(dataSet1.Category_Info);
                dataSet1.Category_Info.AcceptChanges();

                string title = "Operation Completed";
                MessageBox.Show("Record Deleted Successfully.", title);
            }
            catch  
            {
                string title = "Error";
                MessageBox.Show("Category in use.", title);
            }
           
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            category_InfoBindingSource.MoveFirst();

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            category_InfoBindingSource.MoveNext();
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            category_InfoBindingSource.MovePrevious();
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            category_InfoBindingSource.MoveLast();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void category_NameTextBox_Leave(object sender, EventArgs e)
        {
            btnsave.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoryReg PR = new CategoryReg();
            this.Dispose();
            PR.Show();
        }
    }
}
