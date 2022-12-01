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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            //foreach (Control ctrl in this.Controls)
            //{
            //    if (ctrl is MdiClient)
            //    {
            //        ctrl.BackColor = Color.FromArgb(41, 30, 40);
            //    }
            //}

            this.BackgroundImage = global::POS_GEN.Properties.Resources.shakes;
                
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;


        }

        private void adToolStripMenuItem_Click(object sender, EventArgs e)
        {
           


        }

        private void purchaseRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseReg pr = new PurchaseReg();
            pr.MdiParent = this;
            pr.Show();
        }

        private void purchasePaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchasePayment pp = new PurchasePayment();
            pp.MdiParent = this;
            pp.Show();
        }

        private void sdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void expenseManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpenseReg er = new ExpenseReg();
            er.MdiParent = this;
            er.Show();
        }

        private void categoryRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryReg cr = new CategoryReg();
            cr.MdiParent = this;
            cr.Show();
        }

        private void productRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductReg prod = new ProductReg();
            prod.MdiParent = this;
            prod.Show();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dbBackUp dbback = new dbBackUp();
            dbback.MdiParent = this;
            dbback.Show();
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dbRestore dr = new dbRestore();
            dr.MdiParent = this;
            dr.Show();
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserReg ur = new UserReg();
            ur.MdiParent = this;
            ur.Show();
        }

        private void inventoryInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventoryView iv = new InventoryView();
            iv.MdiParent = this;
            iv.Show();
        }

        private void purchaseEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseEdit pe = new PurchaseEdit();
            pe.MdiParent = this;
            pe.Show();
        }

        private void purchaseLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseLog pl = new PurchaseLog();
            pl.MdiParent = this;
            pl.Show();
        }

        private void purchaseInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseInformation pi = new PurchaseInformation();
            pi.MdiParent = this;
            pi.Show();
        }

        private void saleReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void saleLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void saleInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void titleOfAccountManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountTitleReg atr = new AccountTitleReg();
            atr.MdiParent = this;
            atr.Show();
        }

        private void journalEntriesManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JournalReg jr = new JournalReg();
            jr.MdiParent = this;
            jr.Show();
        }

        private void trialBalanceLedgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LedgerForm lf = new LedgerForm();
            lf.MdiParent = this;
            lf.Show();
        }

        private void pNLStatementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PNLForm pf = new PNLForm();
            pf.MdiParent = this;
            pf.Show();
        }

        private void salesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void distributerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VendorReg vr = new VendorReg();
            vr.MdiParent = this;
            vr.Show();
        }

        private void pOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PosReg point = new PosReg();
            point.MdiParent = this;
            point.Show();
        }

        private void saleReturnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaleReturn sr = new SaleReturn();
            sr.MdiParent = this;
            sr.Show();
        }

        private void saleLogToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaleLog sl = new SaleLog();
            sl.MdiParent = this;
            sl.Show();
        }

        private void saleInformationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaleInformation saleinfo = new SaleInformation();
            saleinfo.MdiParent = this;
            saleinfo.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer AC = new AddCustomer();
            AC.MdiParent = this;
            AC.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Daily_Sale_Amount_Rep DSAR = new Daily_Sale_Amount_Rep();
            DSAR.MdiParent = this;
            DSAR.Show();
        }
    }
}
