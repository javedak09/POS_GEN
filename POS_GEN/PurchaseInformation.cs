
using System;
using System.Configuration;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace POS_GEN
{
    public partial class PurchaseInformation : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["POS_GEN.Properties.Settings.POS_GenConnectionString"].ConnectionString;

        public PurchaseInformation()
        {
            InitializeComponent();
        }

        private void PurchaseInformation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.PurchasePay_View' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'DataSet1.Vendor_Info' table. You can move, or remove it, as needed.
            this.vendor_InfoTableAdapter.Fill(this.DataSet1.Vendor_Info);
            // TODO: This line of code loads data into the 'DataSet1.Purchase_View' table. You can move, or remove it, as needed.
            dt1.Enabled = false;
            dt2.Enabled = false;
            cmbvendor.Enabled = false;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btngenerate_Click(object sender, EventArgs e)
        {
            if (rbdatewise.Checked == false && rbvendordate.Checked == false && rbpay.Checked && rbvenpay.Checked)
            {
                string title = "Operation Aborted";
                MessageBox.Show("Please Select Any fikter in order to Generate Report.", title);
            }
            else
            {
                if (rbdatewise.Checked == true)
                {
                    this.Purchase_ViewTableAdapter.FillBydate(this.DataSet1.Purchase_View, dt1.Text, dt2.Text);
                    ReportParameterCollection reportParameters = new ReportParameterCollection();
                    reportParameters.Add(new ReportParameter("date1", dt1.Text));
                    reportParameters.Add(new ReportParameter("date2", dt2.Text));
                    this.reportViewer1.LocalReport.SetParameters(reportParameters);
                    this.reportViewer1.RefreshReport();
                }

                else if (rbvendordate.Checked == true)
                {
                    this.Purchase_ViewTableAdapter.FillByvendordate(this.DataSet1.Purchase_View, Convert.ToInt32(cmbvendor.SelectedValue),dt1.Text, dt2.Text);
                    ReportParameterCollection reportParameters = new ReportParameterCollection();
                    reportParameters.Add(new ReportParameter("date1", dt1.Text));
                    reportParameters.Add(new ReportParameter("date2", dt2.Text));
                    this.reportViewer1.LocalReport.SetParameters(reportParameters);
                    this.reportViewer1.RefreshReport();
                }

                else if (rbpay.Checked == true)
                {
                    this.PurchasePay_ViewTableAdapter.FillBydate(this.DataSet1.PurchasePay_View,dt1.Text,dt2.Text);
                    ReportParameterCollection reportParameters = new ReportParameterCollection();
                    reportParameters.Add(new ReportParameter("date1", dt1.Text));
                    reportParameters.Add(new ReportParameter("date2", dt2.Text));
                    this.reportViewer2.LocalReport.SetParameters(reportParameters);
                    this.reportViewer2.RefreshReport();
                }

                else if (rbvenpay.Checked == true)
                {
                    this.PurchasePay_ViewTableAdapter.FillByvendate(this.DataSet1.PurchasePay_View,Convert.ToInt32(cmbvendor.SelectedValue),dt1.Text, dt2.Text);
                    ReportParameterCollection reportParameters = new ReportParameterCollection();
                    reportParameters.Add(new ReportParameter("date1", dt1.Text));
                    reportParameters.Add(new ReportParameter("date2", dt2.Text));
                    this.reportViewer2.LocalReport.SetParameters(reportParameters);
                    this.reportViewer2.RefreshReport();
                }

            }
        }

        private void rbdatewise_CheckedChanged(object sender, EventArgs e)
        {
            dt1.Enabled = true;
            dt2.Enabled = true;
            cmbvendor.Enabled = false;
        }

        private void rbvendordate_CheckedChanged(object sender, EventArgs e)
        {
            dt1.Enabled = true;
            dt2.Enabled = true;
            cmbvendor.Enabled = true;
        }

        private void rbpay_CheckedChanged(object sender, EventArgs e)
        {
            dt1.Enabled = true;
            dt2.Enabled = true;
            cmbvendor.Enabled = false;
        }

        private void rbvenpay_CheckedChanged(object sender, EventArgs e)
        {
            dt1.Enabled = true;
            dt2.Enabled = true;
            cmbvendor.Enabled = true;
        }
        
    }
}