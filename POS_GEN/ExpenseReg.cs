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
    public partial class ExpenseReg : Form
    {
        public ExpenseReg()
        {
            InitializeComponent();
        }

        private void expense_InfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.expense_InfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void ExpenseReg_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Expense_Info' table. You can move, or remove it, as needed.
            this.expense_InfoTableAdapter.Fill(this.dataSet1.Expense_Info);

            expense_IDTextBox.Enabled = false;
            titleTextBox.Enabled = false;
            descriptionTextBox.Enabled = false;
            amountTextBox.Enabled = false;
            reg_DateDateTimePicker.Enabled = false;

            btnsave.Enabled = false;






        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            expense_InfoBindingSource.AddNew();

            titleTextBox.Enabled = true;
            descriptionTextBox.Enabled = true;
            amountTextBox.Enabled = true;
            reg_DateDateTimePicker.Enabled = true;

            reg_DateDateTimePicker.ResetText();
            reg_DateDateTimePicker.Text = DateTime.Now.ToString("yyyy-MM-dd");

            btnsave.Enabled = true;
            btnadd.Enabled = false;
            btnedit.Enabled = false;
            btndelete.Enabled = false;

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            expense_InfoBindingSource.EndEdit();
            expense_InfoTableAdapter.Update(dataSet1.Expense_Info);
            dataSet1.Expense_Info.AcceptChanges();

            string title = "Operation Completed";
            MessageBox.Show("Record Saved/ Updated Successfully.", title);

            btnsave.Enabled = false;
            btnadd.Enabled = true;
            btnedit.Enabled = true;
            btndelete.Enabled = true;

            titleTextBox.Enabled = false;
            descriptionTextBox.Enabled = false;
            amountTextBox.Enabled = false;
            reg_DateDateTimePicker.Enabled = false;

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            titleTextBox.Enabled = true;
            descriptionTextBox.Enabled = true;
            amountTextBox.Enabled = true;
            reg_DateDateTimePicker.Enabled = true;

            btnsave.Enabled = true;
            btnadd.Enabled = false;
            btnedit.Enabled = false;
            btndelete.Enabled = false;

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            expense_InfoBindingSource.RemoveCurrent();

            expense_InfoBindingSource.EndEdit();
            expense_InfoTableAdapter.Update(dataSet1.Expense_Info);
            dataSet1.Expense_Info.AcceptChanges();

            string title = "Operation Completed";
            MessageBox.Show("Record Deleted Successfully.", title);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
