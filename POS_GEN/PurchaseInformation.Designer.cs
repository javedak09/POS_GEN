namespace POS_GEN
{
    partial class PurchaseInformation
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Purchase_ViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new POS_GEN.DataSet1();
            this.PurchasePay_ViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelbottom = new System.Windows.Forms.Panel();
            this.paneltop = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Purchase_ViewTableAdapter = new POS_GEN.DataSet1TableAdapters.Purchase_ViewTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbvenpay = new System.Windows.Forms.RadioButton();
            this.rbpay = new System.Windows.Forms.RadioButton();
            this.rbvendordate = new System.Windows.Forms.RadioButton();
            this.rbdatewise = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbvendor = new System.Windows.Forms.ComboBox();
            this.vendorInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dt2 = new System.Windows.Forms.DateTimePicker();
            this.dt1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btngenerate = new System.Windows.Forms.Button();
            this.vendor_InfoTableAdapter = new POS_GEN.DataSet1TableAdapters.Vendor_InfoTableAdapter();
            this.PurchasePay_ViewTableAdapter = new POS_GEN.DataSet1TableAdapters.PurchasePay_ViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Purchase_ViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchasePay_ViewBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfoBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Purchase_ViewBindingSource
            // 
            this.Purchase_ViewBindingSource.DataMember = "Purchase_View";
            this.Purchase_ViewBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PurchasePay_ViewBindingSource
            // 
            this.PurchasePay_ViewBindingSource.DataMember = "PurchasePay_View";
            this.PurchasePay_ViewBindingSource.DataSource = this.DataSet1;
            // 
            // panelbottom
            // 
            this.panelbottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(8)))), ((int)(((byte)(58)))));
            this.panelbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelbottom.Location = new System.Drawing.Point(0, 565);
            this.panelbottom.Name = "panelbottom";
            this.panelbottom.Size = new System.Drawing.Size(882, 4);
            this.panelbottom.TabIndex = 19;
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(8)))), ((int)(((byte)(58)))));
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(882, 4);
            this.paneltop.TabIndex = 18;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(8)))), ((int)(((byte)(58)))));
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(842, 12);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(28, 27);
            this.btnclose.TabIndex = 20;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(8)))), ((int)(((byte)(58)))));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "PURCHASE INFORMATION PANEL";
            // 
            // reportViewer1
            // 
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.Purchase_ViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "POS_GEN.PurchaseDetailRep.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(16, 157);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(424, 402);
            this.reportViewer1.TabIndex = 22;
            // 
            // reportViewer2
            // 
            reportDataSource6.Name = "DataSet1";
            reportDataSource6.Value = this.PurchasePay_ViewBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "POS_GEN.PurchasePayRep.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(446, 157);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(424, 402);
            this.reportViewer2.TabIndex = 23;
            // 
            // Purchase_ViewTableAdapter
            // 
            this.Purchase_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbvenpay);
            this.groupBox1.Controls.Add(this.rbpay);
            this.groupBox1.Controls.Add(this.rbvendordate);
            this.groupBox1.Controls.Add(this.rbdatewise);
            this.groupBox1.Location = new System.Drawing.Point(16, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 90);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Filter";
            // 
            // rbvenpay
            // 
            this.rbvenpay.AutoSize = true;
            this.rbvenpay.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbvenpay.Location = new System.Drawing.Point(112, 43);
            this.rbvenpay.Name = "rbvenpay";
            this.rbvenpay.Size = new System.Drawing.Size(127, 21);
            this.rbvenpay.TabIndex = 3;
            this.rbvenpay.TabStop = true;
            this.rbvenpay.Text = "Vendor Payments";
            this.rbvenpay.UseVisualStyleBackColor = true;
            this.rbvenpay.CheckedChanged += new System.EventHandler(this.rbvenpay_CheckedChanged);
            // 
            // rbpay
            // 
            this.rbpay.AutoSize = true;
            this.rbpay.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbpay.Location = new System.Drawing.Point(112, 22);
            this.rbpay.Name = "rbpay";
            this.rbpay.Size = new System.Drawing.Size(144, 21);
            this.rbpay.TabIndex = 2;
            this.rbpay.TabStop = true;
            this.rbpay.Text = "Payments Date Wise";
            this.rbpay.UseVisualStyleBackColor = true;
            this.rbpay.CheckedChanged += new System.EventHandler(this.rbpay_CheckedChanged);
            // 
            // rbvendordate
            // 
            this.rbvendordate.AutoSize = true;
            this.rbvendordate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbvendordate.Location = new System.Drawing.Point(6, 43);
            this.rbvendordate.Name = "rbvendordate";
            this.rbvendordate.Size = new System.Drawing.Size(100, 21);
            this.rbvendordate.TabIndex = 1;
            this.rbvendordate.TabStop = true;
            this.rbvendordate.Text = "Vendor Wise";
            this.rbvendordate.UseVisualStyleBackColor = true;
            this.rbvendordate.CheckedChanged += new System.EventHandler(this.rbvendordate_CheckedChanged);
            // 
            // rbdatewise
            // 
            this.rbdatewise.AutoSize = true;
            this.rbdatewise.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdatewise.Location = new System.Drawing.Point(7, 20);
            this.rbdatewise.Name = "rbdatewise";
            this.rbdatewise.Size = new System.Drawing.Size(85, 21);
            this.rbdatewise.TabIndex = 0;
            this.rbdatewise.TabStop = true;
            this.rbdatewise.Text = "Date Wise";
            this.rbdatewise.UseVisualStyleBackColor = true;
            this.rbdatewise.CheckedChanged += new System.EventHandler(this.rbdatewise_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbvendor);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dt2);
            this.groupBox2.Controls.Add(this.dt1);
            this.groupBox2.Location = new System.Drawing.Point(294, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 90);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Credentials";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(196, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Select Vendor:";
            // 
            // cmbvendor
            // 
            this.cmbvendor.DataSource = this.vendorInfoBindingSource;
            this.cmbvendor.DisplayMember = "Vendor_Name";
            this.cmbvendor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbvendor.FormattingEnabled = true;
            this.cmbvendor.Location = new System.Drawing.Point(200, 54);
            this.cmbvendor.Name = "cmbvendor";
            this.cmbvendor.Size = new System.Drawing.Size(172, 29);
            this.cmbvendor.TabIndex = 14;
            this.cmbvendor.ValueMember = "Vendor_ID";
            // 
            // vendorInfoBindingSource
            // 
            this.vendorInfoBindingSource.DataMember = "Vendor_Info";
            this.vendorInfoBindingSource.DataSource = this.DataSet1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "From:";
            // 
            // dt2
            // 
            this.dt2.CustomFormat = "yyyy-MM-dd";
            this.dt2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt2.Location = new System.Drawing.Point(65, 54);
            this.dt2.Name = "dt2";
            this.dt2.Size = new System.Drawing.Size(129, 29);
            this.dt2.TabIndex = 11;
            // 
            // dt1
            // 
            this.dt1.CustomFormat = "yyyy-MM-dd";
            this.dt1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt1.Location = new System.Drawing.Point(65, 19);
            this.dt1.Name = "dt1";
            this.dt1.Size = new System.Drawing.Size(129, 29);
            this.dt1.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btngenerate);
            this.groupBox3.Location = new System.Drawing.Point(682, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 90);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operations";
            // 
            // btngenerate
            // 
            this.btngenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btngenerate.FlatAppearance.BorderSize = 0;
            this.btngenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngenerate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerate.ForeColor = System.Drawing.Color.White;
            this.btngenerate.Location = new System.Drawing.Point(6, 21);
            this.btngenerate.Name = "btngenerate";
            this.btngenerate.Size = new System.Drawing.Size(176, 43);
            this.btngenerate.TabIndex = 5;
            this.btngenerate.Text = "GENERATE";
            this.btngenerate.UseVisualStyleBackColor = false;
            this.btngenerate.Click += new System.EventHandler(this.btngenerate_Click);
            // 
            // vendor_InfoTableAdapter
            // 
            this.vendor_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // PurchasePay_ViewTableAdapter
            // 
            this.PurchasePay_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // PurchaseInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 569);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.panelbottom);
            this.Controls.Add(this.paneltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PurchaseInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseInformation";
            this.Load += new System.EventHandler(this.PurchaseInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Purchase_ViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchasePay_ViewBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfoBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelbottom;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource Purchase_ViewBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.Purchase_ViewTableAdapter Purchase_ViewTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt2;
        private System.Windows.Forms.DateTimePicker dt1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btngenerate;
        private System.Windows.Forms.RadioButton rbvenpay;
        private System.Windows.Forms.RadioButton rbpay;
        private System.Windows.Forms.RadioButton rbvendordate;
        private System.Windows.Forms.RadioButton rbdatewise;
        private System.Windows.Forms.ComboBox cmbvendor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource vendorInfoBindingSource;
        private DataSet1TableAdapters.Vendor_InfoTableAdapter vendor_InfoTableAdapter;
        private System.Windows.Forms.BindingSource PurchasePay_ViewBindingSource;
        private DataSet1TableAdapters.PurchasePay_ViewTableAdapter PurchasePay_ViewTableAdapter;
    }
}