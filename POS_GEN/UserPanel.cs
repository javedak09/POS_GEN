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
    public partial class UserPanel : Form
    {
        public UserPanel()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void sdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PosReg point = new PosReg();
            point.MdiParent = this;
            point.Show();
        }

        private void saleReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleReturn sr = new SaleReturn();
            sr.MdiParent = this;
            sr.Show();
        }

        private void saleLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleLog sl = new SaleLog();
            sl.MdiParent = this;
            sl.Show();
        }

        private void saleInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleInformation saleinfo = new SaleInformation();
            saleinfo.MdiParent = this;
            saleinfo.Show();
        }
    }
}
