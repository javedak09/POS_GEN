namespace POS_GEN
{
    partial class PurchasePayment
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
            System.Windows.Forms.Label pay_IDLabel;
            System.Windows.Forms.Label vendor_IDLabel;
            System.Windows.Forms.Label prev_AmountLabel;
            System.Windows.Forms.Label current_AmountLabel;
            System.Windows.Forms.Label total_AmountLabel;
            System.Windows.Forms.Label balanceLabel;
            System.Windows.Forms.Label mOPLabel;
            System.Windows.Forms.Label reg_DateLabel;
            System.Windows.Forms.Label recieved_AmountLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelbottom = new System.Windows.Forms.Panel();
            this.paneltop = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.recieved_AmountTextBox = new System.Windows.Forms.TextBox();
            this.purchase_Pay_InfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new POS_GEN.DataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dt1 = new System.Windows.Forms.DateTimePicker();
            this.cmbvendor = new System.Windows.Forms.ComboBox();
            this.vendorInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pay_IDTextBox = new System.Windows.Forms.TextBox();
            this.prev_AmountTextBox = new System.Windows.Forms.TextBox();
            this.current_AmountTextBox = new System.Windows.Forms.TextBox();
            this.total_AmountTextBox = new System.Windows.Forms.TextBox();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.mOPComboBox = new System.Windows.Forms.ComboBox();
            this.reg_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnprevious = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnfirst = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.purchase_Pay_InfoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbsearchvendor = new System.Windows.Forms.ComboBox();
            this.vendorInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.purchase_Pay_InfoTableAdapter = new POS_GEN.DataSet1TableAdapters.Purchase_Pay_InfoTableAdapter();
            this.tableAdapterManager = new POS_GEN.DataSet1TableAdapters.TableAdapterManager();
            this.vendor_InfoTableAdapter = new POS_GEN.DataSet1TableAdapters.Vendor_InfoTableAdapter();
            pay_IDLabel = new System.Windows.Forms.Label();
            vendor_IDLabel = new System.Windows.Forms.Label();
            prev_AmountLabel = new System.Windows.Forms.Label();
            current_AmountLabel = new System.Windows.Forms.Label();
            total_AmountLabel = new System.Windows.Forms.Label();
            balanceLabel = new System.Windows.Forms.Label();
            mOPLabel = new System.Windows.Forms.Label();
            reg_DateLabel = new System.Windows.Forms.Label();
            recieved_AmountLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_Pay_InfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_Pay_InfoDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pay_IDLabel
            // 
            pay_IDLabel.AutoSize = true;
            pay_IDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pay_IDLabel.Location = new System.Drawing.Point(12, 78);
            pay_IDLabel.Name = "pay_IDLabel";
            pay_IDLabel.Size = new System.Drawing.Size(56, 21);
            pay_IDLabel.TabIndex = 0;
            pay_IDLabel.Text = "Pay ID:";
            // 
            // vendor_IDLabel
            // 
            vendor_IDLabel.AutoSize = true;
            vendor_IDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vendor_IDLabel.Location = new System.Drawing.Point(12, 112);
            vendor_IDLabel.Name = "vendor_IDLabel";
            vendor_IDLabel.Size = new System.Drawing.Size(82, 21);
            vendor_IDLabel.TabIndex = 2;
            vendor_IDLabel.Text = "Vendor ID:";
            // 
            // prev_AmountLabel
            // 
            prev_AmountLabel.AutoSize = true;
            prev_AmountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prev_AmountLabel.Location = new System.Drawing.Point(12, 148);
            prev_AmountLabel.Name = "prev_AmountLabel";
            prev_AmountLabel.Size = new System.Drawing.Size(104, 21);
            prev_AmountLabel.TabIndex = 4;
            prev_AmountLabel.Text = "Prev Amount:";
            // 
            // current_AmountLabel
            // 
            current_AmountLabel.AutoSize = true;
            current_AmountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            current_AmountLabel.Location = new System.Drawing.Point(12, 183);
            current_AmountLabel.Name = "current_AmountLabel";
            current_AmountLabel.Size = new System.Drawing.Size(126, 21);
            current_AmountLabel.TabIndex = 6;
            current_AmountLabel.Text = "Current Amount:";
            // 
            // total_AmountLabel
            // 
            total_AmountLabel.AutoSize = true;
            total_AmountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            total_AmountLabel.Location = new System.Drawing.Point(12, 218);
            total_AmountLabel.Name = "total_AmountLabel";
            total_AmountLabel.Size = new System.Drawing.Size(105, 21);
            total_AmountLabel.TabIndex = 8;
            total_AmountLabel.Text = "Total Amount:";
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            balanceLabel.Location = new System.Drawing.Point(12, 288);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new System.Drawing.Size(66, 21);
            balanceLabel.TabIndex = 10;
            balanceLabel.Text = "Balance:";
            // 
            // mOPLabel
            // 
            mOPLabel.AutoSize = true;
            mOPLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mOPLabel.Location = new System.Drawing.Point(12, 323);
            mOPLabel.Name = "mOPLabel";
            mOPLabel.Size = new System.Drawing.Size(48, 21);
            mOPLabel.TabIndex = 12;
            mOPLabel.Text = "MOP:";
            // 
            // reg_DateLabel
            // 
            reg_DateLabel.AutoSize = true;
            reg_DateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reg_DateLabel.Location = new System.Drawing.Point(12, 359);
            reg_DateLabel.Name = "reg_DateLabel";
            reg_DateLabel.Size = new System.Drawing.Size(76, 21);
            reg_DateLabel.TabIndex = 14;
            reg_DateLabel.Text = "Reg Date:";
            // 
            // recieved_AmountLabel
            // 
            recieved_AmountLabel.AutoSize = true;
            recieved_AmountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            recieved_AmountLabel.Location = new System.Drawing.Point(12, 253);
            recieved_AmountLabel.Name = "recieved_AmountLabel";
            recieved_AmountLabel.Size = new System.Drawing.Size(75, 21);
            recieved_AmountLabel.TabIndex = 19;
            recieved_AmountLabel.Text = "Recieved:";
            // 
            // panelbottom
            // 
            this.panelbottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(8)))), ((int)(((byte)(58)))));
            this.panelbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelbottom.Location = new System.Drawing.Point(0, 463);
            this.panelbottom.Name = "panelbottom";
            this.panelbottom.Size = new System.Drawing.Size(937, 4);
            this.panelbottom.TabIndex = 13;
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(8)))), ((int)(((byte)(58)))));
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(937, 4);
            this.paneltop.TabIndex = 12;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(8)))), ((int)(((byte)(58)))));
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(891, 18);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(28, 27);
            this.btnclose.TabIndex = 14;
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
            this.label1.Size = new System.Drawing.Size(285, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "PURCHASE PAYMENT PANEL";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(recieved_AmountLabel);
            this.groupBox2.Controls.Add(this.recieved_AmountTextBox);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dt1);
            this.groupBox2.Controls.Add(this.cmbvendor);
            this.groupBox2.Controls.Add(pay_IDLabel);
            this.groupBox2.Controls.Add(this.pay_IDTextBox);
            this.groupBox2.Controls.Add(vendor_IDLabel);
            this.groupBox2.Controls.Add(prev_AmountLabel);
            this.groupBox2.Controls.Add(this.prev_AmountTextBox);
            this.groupBox2.Controls.Add(current_AmountLabel);
            this.groupBox2.Controls.Add(this.current_AmountTextBox);
            this.groupBox2.Controls.Add(total_AmountLabel);
            this.groupBox2.Controls.Add(this.total_AmountTextBox);
            this.groupBox2.Controls.Add(balanceLabel);
            this.groupBox2.Controls.Add(this.balanceTextBox);
            this.groupBox2.Controls.Add(mOPLabel);
            this.groupBox2.Controls.Add(this.mOPComboBox);
            this.groupBox2.Controls.Add(reg_DateLabel);
            this.groupBox2.Controls.Add(this.reg_DateDateTimePicker);
            this.groupBox2.Location = new System.Drawing.Point(155, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 393);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter Credentials";
            // 
            // recieved_AmountTextBox
            // 
            this.recieved_AmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchase_Pay_InfoBindingSource, "Recieved_Amount", true));
            this.recieved_AmountTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieved_AmountTextBox.Location = new System.Drawing.Point(144, 250);
            this.recieved_AmountTextBox.Name = "recieved_AmountTextBox";
            this.recieved_AmountTextBox.Size = new System.Drawing.Size(158, 29);
            this.recieved_AmountTextBox.TabIndex = 20;
            this.recieved_AmountTextBox.TextChanged += new System.EventHandler(this.recieved_AmountTextBox_TextChanged);
            // 
            // purchase_Pay_InfoBindingSource
            // 
            this.purchase_Pay_InfoBindingSource.DataMember = "Purchase_Pay_Info";
            this.purchase_Pay_InfoBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(22, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 3);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Select Date";
            // 
            // dt1
            // 
            this.dt1.CustomFormat = "yyyy-MM-dd";
            this.dt1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt1.Location = new System.Drawing.Point(144, 27);
            this.dt1.Name = "dt1";
            this.dt1.Size = new System.Drawing.Size(158, 29);
            this.dt1.TabIndex = 17;
            this.dt1.ValueChanged += new System.EventHandler(this.dt1_ValueChanged);
            // 
            // cmbvendor
            // 
            this.cmbvendor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.purchase_Pay_InfoBindingSource, "Vendor_ID", true));
            this.cmbvendor.DataSource = this.vendorInfoBindingSource;
            this.cmbvendor.DisplayMember = "Vendor_Name";
            this.cmbvendor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbvendor.FormattingEnabled = true;
            this.cmbvendor.Location = new System.Drawing.Point(144, 110);
            this.cmbvendor.Name = "cmbvendor";
            this.cmbvendor.Size = new System.Drawing.Size(158, 29);
            this.cmbvendor.TabIndex = 16;
            this.cmbvendor.ValueMember = "Vendor_ID";
            this.cmbvendor.SelectedIndexChanged += new System.EventHandler(this.cmbvendor_SelectedIndexChanged);
            this.cmbvendor.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // vendorInfoBindingSource
            // 
            this.vendorInfoBindingSource.DataMember = "Vendor_Info";
            this.vendorInfoBindingSource.DataSource = this.dataSet1;
            // 
            // pay_IDTextBox
            // 
            this.pay_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchase_Pay_InfoBindingSource, "Pay_ID", true));
            this.pay_IDTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay_IDTextBox.Location = new System.Drawing.Point(144, 75);
            this.pay_IDTextBox.Name = "pay_IDTextBox";
            this.pay_IDTextBox.Size = new System.Drawing.Size(128, 29);
            this.pay_IDTextBox.TabIndex = 1;
            // 
            // prev_AmountTextBox
            // 
            this.prev_AmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchase_Pay_InfoBindingSource, "Prev_Amount", true));
            this.prev_AmountTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prev_AmountTextBox.Location = new System.Drawing.Point(144, 145);
            this.prev_AmountTextBox.Name = "prev_AmountTextBox";
            this.prev_AmountTextBox.Size = new System.Drawing.Size(158, 29);
            this.prev_AmountTextBox.TabIndex = 5;
            this.prev_AmountTextBox.TextChanged += new System.EventHandler(this.prev_AmountTextBox_TextChanged);
            this.prev_AmountTextBox.Leave += new System.EventHandler(this.prev_AmountTextBox_Leave);
            // 
            // current_AmountTextBox
            // 
            this.current_AmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchase_Pay_InfoBindingSource, "Current_Amount", true));
            this.current_AmountTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_AmountTextBox.Location = new System.Drawing.Point(144, 180);
            this.current_AmountTextBox.Name = "current_AmountTextBox";
            this.current_AmountTextBox.Size = new System.Drawing.Size(158, 29);
            this.current_AmountTextBox.TabIndex = 7;
            // 
            // total_AmountTextBox
            // 
            this.total_AmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchase_Pay_InfoBindingSource, "Total_Amount", true));
            this.total_AmountTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_AmountTextBox.Location = new System.Drawing.Point(144, 215);
            this.total_AmountTextBox.Name = "total_AmountTextBox";
            this.total_AmountTextBox.Size = new System.Drawing.Size(158, 29);
            this.total_AmountTextBox.TabIndex = 9;
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchase_Pay_InfoBindingSource, "Balance", true));
            this.balanceTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceTextBox.Location = new System.Drawing.Point(144, 285);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(158, 29);
            this.balanceTextBox.TabIndex = 11;
            // 
            // mOPComboBox
            // 
            this.mOPComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchase_Pay_InfoBindingSource, "MOP", true));
            this.mOPComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mOPComboBox.FormattingEnabled = true;
            this.mOPComboBox.Items.AddRange(new object[] {
            "Cash",
            "Online Bank Transfer",
            "Cheque"});
            this.mOPComboBox.Location = new System.Drawing.Point(144, 320);
            this.mOPComboBox.Name = "mOPComboBox";
            this.mOPComboBox.Size = new System.Drawing.Size(158, 29);
            this.mOPComboBox.TabIndex = 13;
            // 
            // reg_DateDateTimePicker
            // 
            this.reg_DateDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.reg_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.purchase_Pay_InfoBindingSource, "Reg_Date", true));
            this.reg_DateDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.reg_DateDateTimePicker.Location = new System.Drawing.Point(144, 355);
            this.reg_DateDateTimePicker.Name = "reg_DateDateTimePicker";
            this.reg_DateDateTimePicker.Size = new System.Drawing.Size(158, 29);
            this.reg_DateDateTimePicker.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnlast);
            this.groupBox1.Controls.Add(this.btnprevious);
            this.groupBox1.Controls.Add(this.btnnext);
            this.groupBox1.Controls.Add(this.btnfirst);
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.btnedit);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Location = new System.Drawing.Point(16, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 393);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operations";
            // 
            // btnlast
            // 
            this.btnlast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnlast.FlatAppearance.BorderSize = 0;
            this.btnlast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlast.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlast.ForeColor = System.Drawing.Color.White;
            this.btnlast.Location = new System.Drawing.Point(6, 338);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(120, 34);
            this.btnlast.TabIndex = 7;
            this.btnlast.Text = "LAST";
            this.btnlast.UseVisualStyleBackColor = false;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // btnprevious
            // 
            this.btnprevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnprevious.FlatAppearance.BorderSize = 0;
            this.btnprevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprevious.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprevious.ForeColor = System.Drawing.Color.White;
            this.btnprevious.Location = new System.Drawing.Point(6, 298);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(120, 34);
            this.btnprevious.TabIndex = 6;
            this.btnprevious.Text = "PREVIOUS";
            this.btnprevious.UseVisualStyleBackColor = false;
            this.btnprevious.Click += new System.EventHandler(this.btnprevious_Click);
            // 
            // btnnext
            // 
            this.btnnext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnnext.FlatAppearance.BorderSize = 0;
            this.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnext.ForeColor = System.Drawing.Color.White;
            this.btnnext.Location = new System.Drawing.Point(6, 258);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(120, 34);
            this.btnnext.TabIndex = 5;
            this.btnnext.Text = "NEXT";
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnfirst
            // 
            this.btnfirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnfirst.FlatAppearance.BorderSize = 0;
            this.btnfirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfirst.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfirst.ForeColor = System.Drawing.Color.White;
            this.btnfirst.Location = new System.Drawing.Point(6, 218);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(120, 34);
            this.btnfirst.TabIndex = 4;
            this.btnfirst.Text = "FIRST";
            this.btnfirst.UseVisualStyleBackColor = false;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(7, 152);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(120, 34);
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
            this.btnedit.Location = new System.Drawing.Point(7, 112);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(120, 34);
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
            this.btnsave.Location = new System.Drawing.Point(7, 72);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(120, 34);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "SAVE/ UPDATE";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(7, 32);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(120, 34);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "NEW RECORD";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // purchase_Pay_InfoDataGridView
            // 
            this.purchase_Pay_InfoDataGridView.AllowUserToAddRows = false;
            this.purchase_Pay_InfoDataGridView.AllowUserToDeleteRows = false;
            this.purchase_Pay_InfoDataGridView.AutoGenerateColumns = false;
            this.purchase_Pay_InfoDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purchase_Pay_InfoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.purchase_Pay_InfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchase_Pay_InfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.purchase_Pay_InfoDataGridView.DataSource = this.purchase_Pay_InfoBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.purchase_Pay_InfoDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.purchase_Pay_InfoDataGridView.Location = new System.Drawing.Point(473, 134);
            this.purchase_Pay_InfoDataGridView.Name = "purchase_Pay_InfoDataGridView";
            this.purchase_Pay_InfoDataGridView.ReadOnly = true;
            this.purchase_Pay_InfoDataGridView.Size = new System.Drawing.Size(452, 315);
            this.purchase_Pay_InfoDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Pay_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Pay_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Vendor_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Vendor_ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prev_Amount";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prev_Amount";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Current_Amount";
            this.dataGridViewTextBoxColumn4.HeaderText = "Current_Amount";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Total_Amount";
            this.dataGridViewTextBoxColumn5.HeaderText = "Total_Amount";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Balance";
            this.dataGridViewTextBoxColumn6.HeaderText = "Balance";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MOP";
            this.dataGridViewTextBoxColumn7.HeaderText = "MOP";
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
            this.groupBox3.Controls.Add(this.btnsearch);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cmbsearchvendor);
            this.groupBox3.Location = new System.Drawing.Point(473, 56);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(452, 72);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Credentials";
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnsearch.FlatAppearance.BorderSize = 0;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(298, 30);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(148, 30);
            this.btnsearch.TabIndex = 8;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Select Vendor";
            // 
            // cmbsearchvendor
            // 
            this.cmbsearchvendor.DataSource = this.vendorInfoBindingSource1;
            this.cmbsearchvendor.DisplayMember = "Vendor_Name";
            this.cmbsearchvendor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsearchvendor.FormattingEnabled = true;
            this.cmbsearchvendor.Location = new System.Drawing.Point(117, 30);
            this.cmbsearchvendor.Name = "cmbsearchvendor";
            this.cmbsearchvendor.Size = new System.Drawing.Size(175, 29);
            this.cmbsearchvendor.TabIndex = 0;
            this.cmbsearchvendor.ValueMember = "Vendor_ID";
            // 
            // vendorInfoBindingSource1
            // 
            this.vendorInfoBindingSource1.DataMember = "Vendor_Info";
            this.vendorInfoBindingSource1.DataSource = this.dataSet1;
            // 
            // purchase_Pay_InfoTableAdapter
            // 
            this.purchase_Pay_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Account_Title_InfoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Category_InfoTableAdapter = null;
            this.tableAdapterManager.Expense_InfoTableAdapter = null;
            this.tableAdapterManager.LedgerProcedureTableAdapter = null;
            this.tableAdapterManager.PNLPurchaseTableAdapter = null;
            this.tableAdapterManager.PNLSaleTableAdapter = null;
            this.tableAdapterManager.POS_InfoTableAdapter = null;
            this.tableAdapterManager.Pos_Pay_InfoTableAdapter = null;
            this.tableAdapterManager.Product_InfoTableAdapter = null;
            this.tableAdapterManager.Purchase_InfoTableAdapter = null;
            this.tableAdapterManager.Purchase_LogTableAdapter = null;
            this.tableAdapterManager.Purchase_Pay_InfoTableAdapter = this.purchase_Pay_InfoTableAdapter;
            this.tableAdapterManager.Sale_LogTableAdapter = null;
            this.tableAdapterManager.SaleSummaryProcedureTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = POS_GEN.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User_InfoTableAdapter = null;
            this.tableAdapterManager.Vendor_InfoTableAdapter = this.vendor_InfoTableAdapter;
            // 
            // vendor_InfoTableAdapter
            // 
            this.vendor_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // PurchasePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(937, 467);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.purchase_Pay_InfoDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.panelbottom);
            this.Controls.Add(this.paneltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PurchasePayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchasePayment";
            this.Load += new System.EventHandler(this.PurchasePayment_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_Pay_InfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.purchase_Pay_InfoDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfoBindingSource1)).EndInit();
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
        private System.Windows.Forms.Button btnadd;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource purchase_Pay_InfoBindingSource;
        private DataSet1TableAdapters.Purchase_Pay_InfoTableAdapter purchase_Pay_InfoTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbvendor;
        private System.Windows.Forms.TextBox pay_IDTextBox;
        private System.Windows.Forms.TextBox prev_AmountTextBox;
        private System.Windows.Forms.TextBox current_AmountTextBox;
        private System.Windows.Forms.TextBox total_AmountTextBox;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.ComboBox mOPComboBox;
        private System.Windows.Forms.DateTimePicker reg_DateDateTimePicker;
        private DataSet1TableAdapters.Vendor_InfoTableAdapter vendor_InfoTableAdapter;
        private System.Windows.Forms.BindingSource vendorInfoBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt1;
        private System.Windows.Forms.DataGridView purchase_Pay_InfoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button btnprevious;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbsearchvendor;
        private System.Windows.Forms.BindingSource vendorInfoBindingSource1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox recieved_AmountTextBox;
    }
}