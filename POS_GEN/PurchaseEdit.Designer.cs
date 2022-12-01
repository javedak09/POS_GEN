namespace POS_GEN
{
    partial class PurchaseEdit
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
            System.Windows.Forms.Label pO_NoLabel;
            System.Windows.Forms.Label vendor_IDLabel;
            System.Windows.Forms.Label product_IDLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label unit_PriceLabel;
            System.Windows.Forms.Label total_PriceLabel;
            System.Windows.Forms.Label reg_DateLabel;
            System.Windows.Forms.Label purchase_IDLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelbottom = new System.Windows.Forms.Panel();
            this.paneltop = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbproduct = new System.Windows.Forms.ComboBox();
            this.purchase_InfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new POS_GEN.DataSet1();
            this.productInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbvendor = new System.Windows.Forms.ComboBox();
            this.vendorInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchase_IDTextBox = new System.Windows.Forms.TextBox();
            this.pO_NoTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.unit_PriceTextBox = new System.Windows.Forms.TextBox();
            this.total_PriceTextBox = new System.Windows.Forms.TextBox();
            this.reg_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.purchase_InfoTableAdapter = new POS_GEN.DataSet1TableAdapters.Purchase_InfoTableAdapter();
            this.tableAdapterManager = new POS_GEN.DataSet1TableAdapters.TableAdapterManager();
            this.product_InfoTableAdapter = new POS_GEN.DataSet1TableAdapters.Product_InfoTableAdapter();
            this.vendor_InfoTableAdapter = new POS_GEN.DataSet1TableAdapters.Vendor_InfoTableAdapter();
            this.purchase_InfoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btndisplay = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtposearch = new System.Windows.Forms.TextBox();
            pO_NoLabel = new System.Windows.Forms.Label();
            vendor_IDLabel = new System.Windows.Forms.Label();
            product_IDLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            unit_PriceLabel = new System.Windows.Forms.Label();
            total_PriceLabel = new System.Windows.Forms.Label();
            reg_DateLabel = new System.Windows.Forms.Label();
            purchase_IDLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_InfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_InfoDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pO_NoLabel
            // 
            pO_NoLabel.AutoSize = true;
            pO_NoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pO_NoLabel.Location = new System.Drawing.Point(11, 66);
            pO_NoLabel.Name = "pO_NoLabel";
            pO_NoLabel.Size = new System.Drawing.Size(59, 21);
            pO_NoLabel.TabIndex = 2;
            pO_NoLabel.Text = "PO No:";
            // 
            // vendor_IDLabel
            // 
            vendor_IDLabel.AutoSize = true;
            vendor_IDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vendor_IDLabel.Location = new System.Drawing.Point(11, 101);
            vendor_IDLabel.Name = "vendor_IDLabel";
            vendor_IDLabel.Size = new System.Drawing.Size(82, 21);
            vendor_IDLabel.TabIndex = 4;
            vendor_IDLabel.Text = "Vendor ID:";
            // 
            // product_IDLabel
            // 
            product_IDLabel.AutoSize = true;
            product_IDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            product_IDLabel.Location = new System.Drawing.Point(11, 136);
            product_IDLabel.Name = "product_IDLabel";
            product_IDLabel.Size = new System.Drawing.Size(86, 21);
            product_IDLabel.TabIndex = 6;
            product_IDLabel.Text = "Product ID:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantityLabel.Location = new System.Drawing.Point(11, 171);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(73, 21);
            quantityLabel.TabIndex = 8;
            quantityLabel.Text = "Quantity:";
            // 
            // unit_PriceLabel
            // 
            unit_PriceLabel.AutoSize = true;
            unit_PriceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            unit_PriceLabel.Location = new System.Drawing.Point(11, 206);
            unit_PriceLabel.Name = "unit_PriceLabel";
            unit_PriceLabel.Size = new System.Drawing.Size(80, 21);
            unit_PriceLabel.TabIndex = 10;
            unit_PriceLabel.Text = "Unit Price:";
            // 
            // total_PriceLabel
            // 
            total_PriceLabel.AutoSize = true;
            total_PriceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            total_PriceLabel.Location = new System.Drawing.Point(11, 241);
            total_PriceLabel.Name = "total_PriceLabel";
            total_PriceLabel.Size = new System.Drawing.Size(83, 21);
            total_PriceLabel.TabIndex = 12;
            total_PriceLabel.Text = "Total Price:";
            // 
            // reg_DateLabel
            // 
            reg_DateLabel.AutoSize = true;
            reg_DateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reg_DateLabel.Location = new System.Drawing.Point(11, 277);
            reg_DateLabel.Name = "reg_DateLabel";
            reg_DateLabel.Size = new System.Drawing.Size(76, 21);
            reg_DateLabel.TabIndex = 14;
            reg_DateLabel.Text = "Reg Date:";
            // 
            // purchase_IDLabel
            // 
            purchase_IDLabel.AutoSize = true;
            purchase_IDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            purchase_IDLabel.Location = new System.Drawing.Point(11, 31);
            purchase_IDLabel.Name = "purchase_IDLabel";
            purchase_IDLabel.Size = new System.Drawing.Size(95, 21);
            purchase_IDLabel.TabIndex = 0;
            purchase_IDLabel.Text = "Purchase ID:";
            // 
            // panelbottom
            // 
            this.panelbottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(8)))), ((int)(((byte)(58)))));
            this.panelbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelbottom.Location = new System.Drawing.Point(0, 378);
            this.panelbottom.Name = "panelbottom";
            this.panelbottom.Size = new System.Drawing.Size(1108, 4);
            this.panelbottom.TabIndex = 15;
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(8)))), ((int)(((byte)(58)))));
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(1108, 4);
            this.paneltop.TabIndex = 14;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(8)))), ((int)(((byte)(58)))));
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(1070, 12);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(28, 27);
            this.btnclose.TabIndex = 16;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(8)))), ((int)(((byte)(58)))));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "PURCHASE EDIT PANEL";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbproduct);
            this.groupBox2.Controls.Add(this.cmbvendor);
            this.groupBox2.Controls.Add(purchase_IDLabel);
            this.groupBox2.Controls.Add(this.purchase_IDTextBox);
            this.groupBox2.Controls.Add(pO_NoLabel);
            this.groupBox2.Controls.Add(this.pO_NoTextBox);
            this.groupBox2.Controls.Add(vendor_IDLabel);
            this.groupBox2.Controls.Add(product_IDLabel);
            this.groupBox2.Controls.Add(quantityLabel);
            this.groupBox2.Controls.Add(this.quantityTextBox);
            this.groupBox2.Controls.Add(unit_PriceLabel);
            this.groupBox2.Controls.Add(this.unit_PriceTextBox);
            this.groupBox2.Controls.Add(total_PriceLabel);
            this.groupBox2.Controls.Add(this.total_PriceTextBox);
            this.groupBox2.Controls.Add(reg_DateLabel);
            this.groupBox2.Controls.Add(this.reg_DateDateTimePicker);
            this.groupBox2.Location = new System.Drawing.Point(155, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 315);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter Credentials";
            // 
            // cmbproduct
            // 
            this.cmbproduct.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.purchase_InfoBindingSource, "Product_ID", true));
            this.cmbproduct.DataSource = this.productInfoBindingSource;
            this.cmbproduct.DisplayMember = "Product_Name";
            this.cmbproduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbproduct.FormattingEnabled = true;
            this.cmbproduct.Location = new System.Drawing.Point(112, 133);
            this.cmbproduct.Name = "cmbproduct";
            this.cmbproduct.Size = new System.Drawing.Size(182, 29);
            this.cmbproduct.TabIndex = 17;
            this.cmbproduct.ValueMember = "Product_ID";
            // 
            // purchase_InfoBindingSource
            // 
            this.purchase_InfoBindingSource.DataMember = "Purchase_Info";
            this.purchase_InfoBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productInfoBindingSource
            // 
            this.productInfoBindingSource.DataMember = "Product_Info";
            this.productInfoBindingSource.DataSource = this.dataSet1;
            // 
            // cmbvendor
            // 
            this.cmbvendor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.purchase_InfoBindingSource, "Vendor_ID", true));
            this.cmbvendor.DataSource = this.vendorInfoBindingSource;
            this.cmbvendor.DisplayMember = "Vendor_Name";
            this.cmbvendor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbvendor.FormattingEnabled = true;
            this.cmbvendor.Location = new System.Drawing.Point(112, 98);
            this.cmbvendor.Name = "cmbvendor";
            this.cmbvendor.Size = new System.Drawing.Size(182, 29);
            this.cmbvendor.TabIndex = 16;
            this.cmbvendor.ValueMember = "Vendor_ID";
            // 
            // vendorInfoBindingSource
            // 
            this.vendorInfoBindingSource.DataMember = "Vendor_Info";
            this.vendorInfoBindingSource.DataSource = this.dataSet1;
            // 
            // purchase_IDTextBox
            // 
            this.purchase_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchase_InfoBindingSource, "Purchase_ID", true));
            this.purchase_IDTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_IDTextBox.Location = new System.Drawing.Point(112, 28);
            this.purchase_IDTextBox.Name = "purchase_IDTextBox";
            this.purchase_IDTextBox.Size = new System.Drawing.Size(165, 29);
            this.purchase_IDTextBox.TabIndex = 1;
            // 
            // pO_NoTextBox
            // 
            this.pO_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchase_InfoBindingSource, "PO_No", true));
            this.pO_NoTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pO_NoTextBox.Location = new System.Drawing.Point(112, 63);
            this.pO_NoTextBox.Name = "pO_NoTextBox";
            this.pO_NoTextBox.Size = new System.Drawing.Size(182, 29);
            this.pO_NoTextBox.TabIndex = 3;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchase_InfoBindingSource, "Quantity", true));
            this.quantityTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextBox.Location = new System.Drawing.Point(112, 168);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(182, 29);
            this.quantityTextBox.TabIndex = 9;
            // 
            // unit_PriceTextBox
            // 
            this.unit_PriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchase_InfoBindingSource, "Unit_Price", true));
            this.unit_PriceTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit_PriceTextBox.Location = new System.Drawing.Point(112, 203);
            this.unit_PriceTextBox.Name = "unit_PriceTextBox";
            this.unit_PriceTextBox.Size = new System.Drawing.Size(182, 29);
            this.unit_PriceTextBox.TabIndex = 11;
            this.unit_PriceTextBox.TextChanged += new System.EventHandler(this.unit_PriceTextBox_TextChanged);
            // 
            // total_PriceTextBox
            // 
            this.total_PriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchase_InfoBindingSource, "Total_Price", true));
            this.total_PriceTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_PriceTextBox.Location = new System.Drawing.Point(112, 238);
            this.total_PriceTextBox.Name = "total_PriceTextBox";
            this.total_PriceTextBox.Size = new System.Drawing.Size(182, 29);
            this.total_PriceTextBox.TabIndex = 13;
            // 
            // reg_DateDateTimePicker
            // 
            this.reg_DateDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.reg_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.purchase_InfoBindingSource, "Reg_Date", true));
            this.reg_DateDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.reg_DateDateTimePicker.Location = new System.Drawing.Point(112, 273);
            this.reg_DateDateTimePicker.Name = "reg_DateDateTimePicker";
            this.reg_DateDateTimePicker.Size = new System.Drawing.Size(182, 29);
            this.reg_DateDateTimePicker.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.btnedit);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Location = new System.Drawing.Point(16, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 315);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operations";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(7, 139);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(120, 31);
            this.btndelete.TabIndex = 3;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnedit.FlatAppearance.BorderSize = 0;
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.Color.White;
            this.btnedit.Location = new System.Drawing.Point(7, 65);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(120, 31);
            this.btnedit.TabIndex = 2;
            this.btnedit.Text = "EDIT RECORD";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(7, 102);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(120, 31);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "SAVE/ UPDATE";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // purchase_InfoTableAdapter
            // 
            this.purchase_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Account_Title_InfoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Category_InfoTableAdapter = null;
            this.tableAdapterManager.Expense_InfoTableAdapter = null;
            this.tableAdapterManager.LedgerProcedureTableAdapter = null;
            this.tableAdapterManager.POS_InfoTableAdapter = null;
            this.tableAdapterManager.Pos_Pay_InfoTableAdapter = null;
            this.tableAdapterManager.Product_InfoTableAdapter = this.product_InfoTableAdapter;
            this.tableAdapterManager.Purchase_InfoTableAdapter = this.purchase_InfoTableAdapter;
            this.tableAdapterManager.Purchase_LogTableAdapter = null;
            this.tableAdapterManager.Purchase_Pay_InfoTableAdapter = null;
            this.tableAdapterManager.Sale_LogTableAdapter = null;
            this.tableAdapterManager.SaleSummaryProcedureTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = POS_GEN.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User_InfoTableAdapter = null;
            this.tableAdapterManager.Vendor_InfoTableAdapter = this.vendor_InfoTableAdapter;
            // 
            // product_InfoTableAdapter
            // 
            this.product_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // vendor_InfoTableAdapter
            // 
            this.vendor_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // purchase_InfoDataGridView
            // 
            this.purchase_InfoDataGridView.AllowUserToAddRows = false;
            this.purchase_InfoDataGridView.AllowUserToDeleteRows = false;
            this.purchase_InfoDataGridView.AutoGenerateColumns = false;
            this.purchase_InfoDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purchase_InfoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.purchase_InfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchase_InfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.purchase_InfoDataGridView.DataSource = this.purchase_InfoBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.purchase_InfoDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.purchase_InfoDataGridView.Location = new System.Drawing.Point(466, 117);
            this.purchase_InfoDataGridView.Name = "purchase_InfoDataGridView";
            this.purchase_InfoDataGridView.ReadOnly = true;
            this.purchase_InfoDataGridView.Size = new System.Drawing.Size(632, 252);
            this.purchase_InfoDataGridView.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Purchase_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Purchase_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PO_No";
            this.dataGridViewTextBoxColumn2.HeaderText = "PO_No";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Vendor_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "Vendor_ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Product_ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "Product_ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn5.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Unit_Price";
            this.dataGridViewTextBoxColumn6.HeaderText = "Unit_Price";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Total_Price";
            this.dataGridViewTextBoxColumn7.HeaderText = "Total_Price";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Reg_Date";
            this.dataGridViewTextBoxColumn8.HeaderText = "Reg_Date";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btndisplay);
            this.groupBox3.Controls.Add(this.btnsearch);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtposearch);
            this.groupBox3.Location = new System.Drawing.Point(466, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(632, 57);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Credentials";
            // 
            // btndisplay
            // 
            this.btndisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btndisplay.FlatAppearance.BorderSize = 0;
            this.btndisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndisplay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndisplay.ForeColor = System.Drawing.Color.White;
            this.btndisplay.Location = new System.Drawing.Point(458, 18);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(161, 29);
            this.btndisplay.TabIndex = 5;
            this.btndisplay.Text = "DISPLAY ALL";
            this.btndisplay.UseVisualStyleBackColor = false;
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnsearch.FlatAppearance.BorderSize = 0;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(332, 18);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(120, 29);
            this.btnsearch.TabIndex = 4;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter PO Number:";
            // 
            // txtposearch
            // 
            this.txtposearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtposearch.Location = new System.Drawing.Point(148, 18);
            this.txtposearch.Name = "txtposearch";
            this.txtposearch.Size = new System.Drawing.Size(178, 29);
            this.txtposearch.TabIndex = 0;
            // 
            // PurchaseEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1108, 382);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.purchase_InfoDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.panelbottom);
            this.Controls.Add(this.paneltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PurchaseEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseEdit";
            this.Load += new System.EventHandler(this.PurchaseEdit_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_InfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.purchase_InfoDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelbottom;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource purchase_InfoBindingSource;
        private DataSet1TableAdapters.Purchase_InfoTableAdapter purchase_InfoTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox purchase_IDTextBox;
        private System.Windows.Forms.TextBox pO_NoTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox unit_PriceTextBox;
        private System.Windows.Forms.TextBox total_PriceTextBox;
        private System.Windows.Forms.DateTimePicker reg_DateDateTimePicker;
        private System.Windows.Forms.DataGridView purchase_InfoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtposearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.ComboBox cmbproduct;
        private System.Windows.Forms.ComboBox cmbvendor;
        private DataSet1TableAdapters.Vendor_InfoTableAdapter vendor_InfoTableAdapter;
        private System.Windows.Forms.BindingSource vendorInfoBindingSource;
        private DataSet1TableAdapters.Product_InfoTableAdapter product_InfoTableAdapter;
        private System.Windows.Forms.BindingSource productInfoBindingSource;
    }
}