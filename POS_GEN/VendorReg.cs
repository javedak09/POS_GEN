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
    public partial class VendorReg : Form
    {
        public VendorReg()
        {
            InitializeComponent();
        }

        private void vendor_InfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendor_InfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void VendorReg_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Vendor_Info' table. You can move, or remove it, as needed.
            this.vendor_InfoTableAdapter.Fill(this.dataSet1.Vendor_Info);

            vendor_IDTextBox.Enabled = false;
            vendor_NameTextBox.Enabled = false;
            contact_NoTextBox.Enabled = false;
            emailTextBox.Enabled = false;
            addressTextBox.Enabled = false;

            btnsave.Enabled = false;
            btnadd.Focus();

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            vendor_NameTextBox.Enabled = true;
            contact_NoTextBox.Enabled = true;
            emailTextBox.Enabled = true;
            addressTextBox.Enabled = true;

            btnadd.Enabled = false;
            btnsave.Enabled = true;
            btnedit.Enabled = false;
            btndelete.Enabled = false;

            vendor_InfoBindingSource.AddNew();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            vendor_NameTextBox.Enabled = false;
            contact_NoTextBox.Enabled = false;
            emailTextBox.Enabled = false;
            addressTextBox.Enabled = false;

            btnadd.Enabled = true;
            btnsave.Enabled = false;
            btnedit.Enabled = true;
            btndelete.Enabled = true;

            vendor_InfoBindingSource.EndEdit();
            vendor_InfoTableAdapter.Update(dataSet1.Vendor_Info);
            dataSet1.Vendor_Info.AcceptChanges();

            string title = "Operation Completed";
            MessageBox.Show("Record Saved/ Updated Successfully.", title);
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            vendor_NameTextBox.Enabled = true;
            contact_NoTextBox.Enabled = true;
            emailTextBox.Enabled = true;
            addressTextBox.Enabled = true;

            btnadd.Enabled = false;
            btnsave.Enabled = true;
            btnedit.Enabled = false;
            btndelete.Enabled = false;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            vendor_InfoBindingSource.RemoveCurrent();

            vendor_InfoBindingSource.EndEdit();
            vendor_InfoTableAdapter.Update(dataSet1.Vendor_Info);
            dataSet1.Vendor_Info.AcceptChanges();

            string title = "Operation Completed";
            MessageBox.Show("Record Deleted Successfully.", title);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addressTextBox_Leave(object sender, EventArgs e)
        {
            btnsave.Focus();
        }
    }
}
