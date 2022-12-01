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
    public partial class SaleInformation : Form
    {
        public SaleInformation()
        {
            InitializeComponent();
        }

        private void SaleInformation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.CustomerInfo' table. You can move, or remove it, as needed.
            this.customerInfoTableAdapter.Fill(this.DataSet1.CustomerInfo);
            // TODO: This line of code loads data into the 'DataSet1.SalePayView' table. You can move, or remove it, as needed.
            this.SalePayViewTableAdapter.Fill(this.DataSet1.SalePayView);
            // TODO: This line of code loads data into the 'DataSet1.POS_View' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'DataSet1.Pos_Pay_Info' table. You can move, or remove it, as needed.
            this.Pos_Pay_InfoTableAdapter.Fill(this.DataSet1.Pos_Pay_Info);
            // TODO: This line of code loads data into the 'DataSet1.SaleSummaryProcedure' table. You can move, or remove it, as needed.
            //this.SaleSummaryProcedureTableAdapter.Fill(this.DataSet1.SaleSummaryProcedure);
            // TODO: This line of code loads data into the 'DataSet1.Pos_Pay_Info' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'DataSet1.SaleSummaryProcedure' table. You can move, or remove it, as needed.

            //this.reportViewer1.RefreshReport();
            // this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (rbsummary.Checked == false && rbdetail.Checked == false)
            {
                string title = "Operation Aborted";
                MessageBox.Show("Please Select Any filter in order to Generate Report.", title);
            }
            else
            {
                if (rbsummary.Checked == true)
                {
                  
                    this.SaleSummaryProcedureTableAdapter.Filldate(this.DataSet1.SaleSummaryProcedure, Convert.ToDateTime(dt1.Text), Convert.ToDateTime(dt2.Text));
                    this.Pos_Pay_InfoTableAdapter.FillBydate(this.DataSet1.Pos_Pay_Info,Convert.ToDateTime(dt1.Text),Convert.ToDateTime( dt2.Text));
                    ReportParameterCollection reportParameters = new ReportParameterCollection();
                    reportParameters.Add(new ReportParameter("date1", dt1.Text));
                    reportParameters.Add(new ReportParameter("date2", dt2.Text));
                    this.reportViewer1.LocalReport.SetParameters(reportParameters);

                    this.reportViewer1.RefreshReport();
                }
                else if (rbdetail.Checked == true)
                {
                    this.POS_ViewTableAdapter.FillBydate(this.DataSet1.POS_View, Convert.ToDateTime(dt1.Text), Convert.ToDateTime(dt2.Text));
                    this.Pos_Pay_InfoTableAdapter.FillBydate(this.DataSet1.Pos_Pay_Info, Convert.ToDateTime(dt1.Text), Convert.ToDateTime(dt2.Text));

                    ReportParameterCollection reportParameters = new ReportParameterCollection();
                    reportParameters.Add(new ReportParameter("date1", dt1.Text));
                    reportParameters.Add(new ReportParameter("date2", dt2.Text));
                    this.reportViewer2.LocalReport.SetParameters(reportParameters);

                    this.reportViewer2.RefreshReport();
                }
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            this.SalePayViewTableAdapter.FillByName(this.DataSet1.SalePayView, Convert.ToInt32(cmbCustomer.SelectedValue));   

            this.reportViewer3.RefreshReport();

        }
    }
}
