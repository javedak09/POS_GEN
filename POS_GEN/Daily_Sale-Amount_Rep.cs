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
    public partial class Daily_Sale_Amount_Rep : Form
    {
        public Daily_Sale_Amount_Rep()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Daily_Sale_Amount_Rep_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.Daily_Sale_Amount' table. You can move, or remove it, as needed.
            //this.Daily_Sale_AmountTableAdapter.Fillbydate(this.DataSet1.Daily_Sale_Amount);

            //this.reportViewer1.RefreshReport();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            this.Daily_Sale_AmountTableAdapter.Fillbydate(this.DataSet1.Daily_Sale_Amount, Convert.ToDateTime(dt1.Text), Convert.ToDateTime(dt2.Text));
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("date1", dt1.Text));
            reportParameters.Add(new ReportParameter("date2", dt2.Text));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);

            this.reportViewer1.RefreshReport();
        }
    }
}
