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
    public partial class PurchaseLog : Form
    {
        public PurchaseLog()
        {
            InitializeComponent();
        }

        private void purchase_LogBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.purchase_LogBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void PurchaseLog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Purchase_Log' table. You can move, or remove it, as needed.
            this.purchase_LogTableAdapter.Fill(this.dataSet1.Purchase_Log);

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            this.purchase_LogTableAdapter.FillBydate(this.dataSet1.Purchase_Log,dt1.Text,dt2.Text);
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            this.purchase_LogTableAdapter.Fill(this.dataSet1.Purchase_Log);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
