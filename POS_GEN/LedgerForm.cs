using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_GEN
{
    public partial class LedgerForm : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["POS_GEN.Properties.Settings.POS_GenConnectionString"].ConnectionString;

        public LedgerForm()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void LedgerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.LedgerProcedure' table. You can move, or remove it, as needed.
            
        }

        private void btnsgenerate_Click(object sender, EventArgs e)
        {
            this.LedgerProcedureTableAdapter.Fill(this.DataSet1.LedgerProcedure,Convert.ToDateTime(dt1.Text), Convert.ToDateTime(dt2.Text));

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
