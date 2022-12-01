using Microsoft.Reporting.WinForms;
namespace POS_GEN
{
    partial class SaleInformation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.SaleSummaryProcedureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new POS_GEN.DataSet1();
            this.Pos_Pay_InfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.POS_ViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SalePayViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelbottom = new System.Windows.Forms.Panel();
            this.paneltop = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dt2 = new System.Windows.Forms.DateTimePicker();
            this.btnsearch = new System.Windows.Forms.Button();
            this.dt1 = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbdetail = new System.Windows.Forms.RadioButton();
            this.rbsummary = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.customerInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btncustomer = new System.Windows.Forms.Button();
            this.SaleSummaryProcedureTableAdapter = new POS_GEN.DataSet1TableAdapters.SaleSummaryProcedureTableAdapter();
            this.Pos_Pay_InfoTableAdapter = new POS_GEN.DataSet1TableAdapters.Pos_Pay_InfoTableAdapter();
            this.POS_ViewTableAdapter = new POS_GEN.DataSet1TableAdapters.POS_ViewTableAdapter();
            this.SalePayViewTableAdapter = new POS_GEN.DataSet1TableAdapters.SalePayViewTableAdapter();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.customerInfoTableAdapter = new POS_GEN.DataSet1TableAdapters.CustomerInfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SaleSummaryProcedureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos_Pay_InfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.POS_ViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalePayViewBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // SaleSummaryProcedureBindingSource
            // 
            this.SaleSummaryProcedureBindingSource.DataMember = "SaleSummaryProcedure";
            this.SaleSummaryProcedureBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Pos_Pay_InfoBindingSource
            // 
            this.Pos_Pay_InfoBindingSource.DataMember = "Pos_Pay_Info";
            this.Pos_Pay_InfoBindingSource.DataSource = this.DataSet1;
            // 
            // POS_ViewBindingSource
            // 
            this.POS_ViewBindingSource.DataMember = "POS_View";
            this.POS_ViewBindingSource.DataSource = this.DataSet1;
            // 
            // SalePayViewBindingSource
            // 
            this.SalePayViewBindingSource.DataMember = "SalePayView";
            this.SalePayViewBindingSource.DataSource = this.DataSet1;
            // 
            // panelbottom
            // 
            this.panelbottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(8)))), ((int)(((byte)(58)))));
            this.panelbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelbottom.Location = new System.Drawing.Point(0, 526);
            this.panelbottom.Name = "panelbottom";
            this.panelbottom.Size = new System.Drawing.Size(1224, 4);
            this.panelbottom.TabIndex = 25;
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(8)))), ((int)(((byte)(58)))));
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(1224, 4);
            this.paneltop.TabIndex = 24;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(8)))), ((int)(((byte)(58)))));
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(1186, 10);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(28, 27);
            this.btnclose.TabIndex = 26;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.dt2);
            this.groupBox3.Controls.Add(this.btnsearch);
            this.groupBox3.Controls.Add(this.dt1);
            this.groupBox3.Location = new System.Drawing.Point(302, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(496, 101);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Dates To Search";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "From:";
            // 
            // dt2
            // 
            this.dt2.CustomFormat = "yyyy-MM-dd h:mm:ss tt";
            this.dt2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt2.Location = new System.Drawing.Point(65, 60);
            this.dt2.Name = "dt2";
            this.dt2.Size = new System.Drawing.Size(228, 29);
            this.dt2.TabIndex = 7;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnsearch.FlatAppearance.BorderSize = 0;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(299, 58);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(191, 31);
            this.btnsearch.TabIndex = 4;
            this.btnsearch.Text = "GENERATE";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // dt1
            // 
            this.dt1.CustomFormat = "yyyy-MM-dd h:mm:ss tt";
            this.dt1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt1.Location = new System.Drawing.Point(65, 19);
            this.dt1.Name = "dt1";
            this.dt1.Size = new System.Drawing.Size(228, 29);
            this.dt1.TabIndex = 6;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SaleSummaryProcedureBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.Pos_Pay_InfoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "POS_GEN.SaleSummaryRep.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 117);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(395, 401);
            this.reportViewer1.TabIndex = 29;
            // 
            // reportViewer2
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.POS_ViewBindingSource;
            reportDataSource4.Name = "DataSet2";
            reportDataSource4.Value = this.Pos_Pay_InfoBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "POS_GEN.SaleDetailRep.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(415, 117);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(396, 401);
            this.reportViewer2.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbdetail);
            this.groupBox1.Controls.Add(this.rbsummary);
            this.groupBox1.Location = new System.Drawing.Point(13, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 61);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Filter";
            // 
            // rbdetail
            // 
            this.rbdetail.AutoSize = true;
            this.rbdetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdetail.Location = new System.Drawing.Point(160, 19);
            this.rbdetail.Name = "rbdetail";
            this.rbdetail.Size = new System.Drawing.Size(119, 25);
            this.rbdetail.TabIndex = 1;
            this.rbdetail.TabStop = true;
            this.rbdetail.Text = "Detail Report";
            this.rbdetail.UseVisualStyleBackColor = true;
            // 
            // rbsummary
            // 
            this.rbsummary.AutoSize = true;
            this.rbsummary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbsummary.Location = new System.Drawing.Point(7, 19);
            this.rbsummary.Name = "rbsummary";
            this.rbsummary.Size = new System.Drawing.Size(147, 25);
            this.rbsummary.TabIndex = 0;
            this.rbsummary.TabStop = true;
            this.rbsummary.Text = "Summary Report";
            this.rbsummary.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(8)))), ((int)(((byte)(58)))));
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "SALE INFORMATION PANEL";
            // 
            // reportViewer3
            // 
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.SalePayViewBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "POS_GEN.SalePayReportCustomerWise.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(818, 117);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(396, 401);
            this.reportViewer3.TabIndex = 33;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbCustomer);
            this.groupBox2.Controls.Add(this.btncustomer);
            this.groupBox2.Location = new System.Drawing.Point(818, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 61);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Customer Wise";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.DataSource = this.customerInfoBindingSource;
            this.cmbCustomer.DisplayMember = "Name";
            this.cmbCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(17, 18);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(243, 29);
            this.cmbCustomer.TabIndex = 5;
            this.cmbCustomer.ValueMember = "CustomerID";
            // 
            // customerInfoBindingSource
            // 
            this.customerInfoBindingSource.DataMember = "CustomerInfo";
            this.customerInfoBindingSource.DataSource = this.DataSet1;
            // 
            // btncustomer
            // 
            this.btncustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btncustomer.FlatAppearance.BorderSize = 0;
            this.btncustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncustomer.ForeColor = System.Drawing.Color.White;
            this.btncustomer.Location = new System.Drawing.Point(266, 17);
            this.btncustomer.Name = "btncustomer";
            this.btncustomer.Size = new System.Drawing.Size(124, 30);
            this.btncustomer.TabIndex = 4;
            this.btncustomer.Text = "GENERATE";
            this.btncustomer.UseVisualStyleBackColor = false;
            this.btncustomer.Click += new System.EventHandler(this.btncustomer_Click);
            // 
            // SaleSummaryProcedureTableAdapter
            // 
            this.SaleSummaryProcedureTableAdapter.ClearBeforeFill = true;
            // 
            // Pos_Pay_InfoTableAdapter
            // 
            this.Pos_Pay_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // POS_ViewTableAdapter
            // 
            this.POS_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // SalePayViewTableAdapter
            // 
            this.SalePayViewTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.DataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1BindingSource1
            // 
            this.dataSet1BindingSource1.DataSource = this.DataSet1;
            this.dataSet1BindingSource1.Position = 0;
            // 
            // dataSet1BindingSource2
            // 
            this.dataSet1BindingSource2.DataSource = this.DataSet1;
            this.dataSet1BindingSource2.Position = 0;
            // 
            // customerInfoTableAdapter
            // 
            this.customerInfoTableAdapter.ClearBeforeFill = true;
            // 
            // SaleInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1224, 530);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.panelbottom);
            this.Controls.Add(this.paneltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaleInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaleInformation";
            this.Load += new System.EventHandler(this.SaleInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SaleSummaryProcedureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos_Pay_InfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.POS_ViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalePayViewBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelbottom;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt2;
        private System.Windows.Forms.DateTimePicker dt1;
        private System.Windows.Forms.Button btnsearch;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SaleSummaryProcedureBindingSource;
        private DataSet1 DataSet1;
        private System.Windows.Forms.BindingSource Pos_Pay_InfoBindingSource;
        private DataSet1TableAdapters.SaleSummaryProcedureTableAdapter SaleSummaryProcedureTableAdapter;
        private DataSet1TableAdapters.Pos_Pay_InfoTableAdapter Pos_Pay_InfoTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbdetail;
        private System.Windows.Forms.RadioButton rbsummary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource POS_ViewBindingSource;
        private DataSet1TableAdapters.POS_ViewTableAdapter POS_ViewTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource SalePayViewBindingSource;
        private DataSet1TableAdapters.SalePayViewTableAdapter SalePayViewTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Button btncustomer;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.BindingSource dataSet1BindingSource1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource2;
        private System.Windows.Forms.BindingSource customerInfoBindingSource;
        private DataSet1TableAdapters.CustomerInfoTableAdapter customerInfoTableAdapter;
    }
}