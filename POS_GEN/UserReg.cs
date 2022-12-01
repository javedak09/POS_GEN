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
    public partial class UserReg : Form
    {
        public UserReg()
        {
            InitializeComponent();
        }

        private void user_InfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.user_InfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void UserReg_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.User_Info' table. You can move, or remove it, as needed.
            this.user_InfoTableAdapter.Fill(this.dataSet1.User_Info);

            user_IDTextBox.Enabled = false;
            usernameTextBox.Enabled = false;
            passwordTextBox.Enabled = false;
            roleComboBox.Enabled = false;

            btnsave.Enabled = false;


        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            user_InfoBindingSource.AddNew();

            usernameTextBox.Enabled = true;
            passwordTextBox.Enabled = true;
            roleComboBox.Enabled = true;

            btnsave.Enabled = true;
            btnadd.Enabled = false;
            btnedit.Enabled = false;
            btndelete.Enabled = false;

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            user_InfoBindingSource.EndEdit();
            user_InfoTableAdapter.Update(dataSet1.User_Info);
            dataSet1.User_Info.AcceptChanges();

            string title = "Operation Completed";
            MessageBox.Show("Record Saved/ Updated Successfully.", title);


            usernameTextBox.Enabled = false;
            passwordTextBox.Enabled = false;
            roleComboBox.Enabled = false;

            btnsave.Enabled = false;
            btnadd.Enabled = true;
            btnedit.Enabled = true;
            btndelete.Enabled = true;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            usernameTextBox.Enabled = true;
            passwordTextBox.Enabled = true;
            roleComboBox.Enabled = true;

            btnsave.Enabled = true;
            btnadd.Enabled = false;
            btnedit.Enabled = false;
            btndelete.Enabled = false;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            user_InfoBindingSource.RemoveCurrent();

            user_InfoBindingSource.EndEdit();
            user_InfoTableAdapter.Update(dataSet1.User_Info);
            dataSet1.User_Info.AcceptChanges();

            string title = "Operation Completed";
            MessageBox.Show("Record Deleted Successfully.", title);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserReg PR = new UserReg();
            this.Dispose();
            PR.Show();
        }
    }
}
