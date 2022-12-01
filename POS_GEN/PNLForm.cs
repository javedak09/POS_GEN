using Microsoft.Reporting.WinForms;
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
    public partial class PNLForm : Form
    {
        public PNLForm()
        {
            InitializeComponent();
        }

        private void PNLForm_Load(object sender, EventArgs e)
        {
           
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            this.PNLSaleTableAdapter.Fill(this.DataSet1.PNLSale,Convert.ToDateTime(dt1.Text), Convert.ToDateTime(dt2.Text));
            this.PNLPurchaseTableAdapter.Fill(this.DataSet1.PNLPurchase, Convert.ToDateTime(dt1.Text), Convert.ToDateTime(dt2.Text));


            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("date1", dt1.Text));
            reportParameters.Add(new ReportParameter("date2", dt2.Text));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);


            this.reportViewer1.RefreshReport();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
