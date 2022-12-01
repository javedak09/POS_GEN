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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void customerInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.CustomerInfo' table. You can move, or remove it, as needed.
            this.customerInfoTableAdapter.Fill(this.dataSet1.CustomerInfo);

            customerIDTextBox.Enabled = false;
            nameTextBox.Enabled = false;
            contactNoTextBox.Enabled = false;
            cNICTextBox.Enabled = false;
            regDateDateTimePicker.Enabled = false;
            addressTextBox.Enabled = false;

            btnsave.Enabled = false;
            btnadd.Focus();

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                nameTextBox.Enabled = true;
                contactNoTextBox.Enabled = true;
                cNICTextBox.Enabled = true;
                regDateDateTimePicker.Enabled = true;
                addressTextBox.Enabled = true;

                btnadd.Enabled = false;
                btnsave.Enabled = true;
                btnedit.Enabled = false;
                btndelete.Enabled = false;

                btnfirst.Enabled = false;
                btnnext.Enabled = false;
                btnprevious.Enabled = false;
                btnlast.Enabled = false;

                customerInfoBindingSource.AddNew();
                nameTextBox.Focus();
            }
            catch 
            {

                 
            }
          

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameTextBox.Text==""||contactNoTextBox.Text==""||addressTextBox.Text==""||cNICTextBox.Text==""||regDateDateTimePicker.Text=="")
                {
                    string title1 = "Error";
                    MessageBox.Show("Fill all fields in order to save records", title1);
                }
                else
                {
                    nameTextBox.Enabled = false;
                    contactNoTextBox.Enabled = false;
                    cNICTextBox.Enabled = false;
                    regDateDateTimePicker.Enabled = false;
                    addressTextBox.Enabled = false;

                    btnadd.Enabled = true;
                    btnsave.Enabled = false;
                    btnedit.Enabled = true;
                    btndelete.Enabled = true;

                    btnfirst.Enabled = true;
                    btnnext.Enabled = true;
                    btnprevious.Enabled = true;
                    btnlast.Enabled = true;

                    customerInfoBindingSource.EndEdit();
                    customerInfoTableAdapter.Update(dataSet1.CustomerInfo);
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
                nameTextBox.Enabled = true;
                contactNoTextBox.Enabled = true;
                cNICTextBox.Enabled = true;
                regDateDateTimePicker.Enabled = true;
                addressTextBox.Enabled = true;

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
                customerInfoBindingSource.RemoveCurrent();

                customerInfoBindingSource.EndEdit();
                customerInfoTableAdapter.Update(dataSet1.CustomerInfo);
                dataSet1.CustomerInfo.AcceptChanges();

                string title = "Operation Completed";
                MessageBox.Show("Record Deleted Successfully.", title);
            }
            catch 
            {
                string title = "Error";
                MessageBox.Show("Customer in Use.", title);
            }
            
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            customerInfoBindingSource.MoveFirst();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            customerInfoBindingSource.MoveNext();
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            customerInfoBindingSource.MovePrevious();
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            customerInfoBindingSource.MoveLast();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PosReg PR = new PosReg();
            this.Dispose();
            PR.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCustomer PR = new AddCustomer();
            this.Dispose();
            PR.Show();
        }
    }
}
