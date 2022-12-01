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
    public partial class SaleLog : Form
    {
        public SaleLog()
        {
            InitializeComponent();
        }

        private void sale_LogBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sale_LogBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void SaleLog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Sale_Log' table. You can move, or remove it, as needed.
            this.sale_LogTableAdapter.Fill(this.dataSet1.Sale_Log);

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            this.sale_LogTableAdapter.FillBydate(this.dataSet1.Sale_Log,dt1.Text,dt2.Text);
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            this.sale_LogTableAdapter.Fill(this.dataSet1.Sale_Log);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
