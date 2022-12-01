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
    public partial class AccountTitleReg : Form
    {
        public AccountTitleReg()
        {
            InitializeComponent();
        }

        private void account_Title_InfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.account_Title_InfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void AccountTitleReg_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Account_Title_Info' table. You can move, or remove it, as needed.
            this.account_Title_InfoTableAdapter.Fill(this.dataSet1.Account_Title_Info);

            title_IDTextBox.Enabled = false;
            account_TitleTextBox.Enabled = false;
            account_TypeComboBox.Enabled = false;

            btnsave.Enabled = false;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            account_Title_InfoBindingSource.AddNew();

            account_TitleTextBox.Enabled = true;
            account_TypeComboBox.Enabled = true;

            btnsave.Enabled = true;
            btnadd.Enabled = false;
            btnedit.Enabled = false;
            btndelete.Enabled = false;
            btnfirst.Enabled = false;
            btnnext.Enabled = false;
            btnprevious.Enabled = false;
            btnlast.Enabled = false;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            account_Title_InfoBindingSource.EndEdit();
            account_Title_InfoTableAdapter.Update(dataSet1.Account_Title_Info);
            dataSet1.Account_Title_Info.AcceptChanges();

            string title = "Operation Completed";
            MessageBox.Show("Record Saved/ Updated Successfully.", title);

            account_TitleTextBox.Enabled = false;
            account_TypeComboBox.Enabled = false;

            btnsave.Enabled = false;
            btnadd.Enabled = true;
            btnedit.Enabled = true;
            btndelete.Enabled = true;
            btnfirst.Enabled = true;
            btnnext.Enabled = true;
            btnprevious.Enabled = true;
            btnlast.Enabled = true;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            account_TitleTextBox.Enabled = true;
            account_TypeComboBox.Enabled = true;

            btnsave.Enabled = true;
            btnadd.Enabled = false;
            btnedit.Enabled = false;
            btndelete.Enabled = false;
            btnfirst.Enabled = false;
            btnnext.Enabled = false;
            btnprevious.Enabled = false;
            btnlast.Enabled = false;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            account_Title_InfoBindingSource.RemoveCurrent();

            account_Title_InfoBindingSource.EndEdit();
            account_Title_InfoTableAdapter.Update(dataSet1.Account_Title_Info);
            dataSet1.Account_Title_Info.AcceptChanges();

            string title = "Operation Completed";
            MessageBox.Show("Record Deleted Successfully.", title);
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            account_Title_InfoBindingSource.MoveFirst();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            account_Title_InfoBindingSource.MoveNext();
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            account_Title_InfoBindingSource.MovePrevious();
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            account_Title_InfoBindingSource.MoveLast();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void account_Title_InfoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
