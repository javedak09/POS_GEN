namespace POS_GEN
{
    partial class AccountTitleReg
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
            System.Windows.Forms.Label title_IDLabel;
            System.Windows.Forms.Label account_TitleLabel;
            System.Windows.Forms.Label account_TypeLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.title_IDTextBox = new System.Windows.Forms.TextBox();
            this.account_Title_InfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new POS_GEN.DataSet1();
            this.account_TitleTextBox = new System.Windows.Forms.TextBox();
            this.account_TypeComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnprevious = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnfirst = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.account_Title_InfoTableAdapter = new POS_GEN.DataSet1TableAdapters.Account_Title_InfoTableAdapter();
            this.tableAdapterManager = new POS_GEN.DataSet1TableAdapters.TableAdapterManager();
            this.account_Title_InfoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            title_IDLabel = new System.Windows.Forms.Label();
            account_TitleLabel = new System.Windows.Forms.Label();
            account_TypeLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.account_Title_InfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.account_Title_InfoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // title_IDLabel
            // 
            title_IDLabel.AutoSize = true;
            title_IDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title_IDLabel.Location = new System.Drawing.Point(5, 25);
            title_IDLabel.Name = "title_IDLabel";
            title_IDLabel.Size = new System.Drawing.Size(61, 21);
            title_IDLabel.TabIndex = 0;
            title_IDLabel.Text = "Title ID:";
            // 
            // account_TitleLabel
            // 
            account_TitleLabel.AutoSize = true;
            account_TitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            account_TitleLabel.Location = new System.Drawing.Point(192, 25);
            account_TitleLabel.Name = "account_TitleLabel";
            account_TitleLabel.Size = new System.Drawing.Size(102, 21);
            account_TitleLabel.TabIndex = 2;
            account_TitleLabel.Text = "Account Title:";
            // 
            // account_TypeLabel
            // 
            account_TypeLabel.AutoSize = true;
            account_TypeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            account_TypeLabel.Location = new System.Drawing.Point(477, 25);
            account_TypeLabel.Name = "account_TypeLabel";
            account_TypeLabel.Size = new System.Drawing.Size(105, 21);
            account_TypeLabel.TabIndex = 4;
            account_TypeLabel.Text = "Account Type:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(8)))), ((int)(((byte)(58)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 452);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(946, 4);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(8)))), ((int)(((byte)(58)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 4);
            this.panel1.TabIndex = 7;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(8)))), ((int)(((byte)(58)))));
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(909, 12);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(28, 27);
            this.btnclose.TabIndex = 9;
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
            this.label1.Size = new System.Drawing.Size(378, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "ACCOUNT TITLE REGISTRATION PANEL";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(title_IDLabel);
            this.groupBox2.Controls.Add(this.title_IDTextBox);
            this.groupBox2.Controls.Add(account_TitleLabel);
            this.groupBox2.Controls.Add(this.account_TitleTextBox);
            this.groupBox2.Controls.Add(account_TypeLabel);
            this.groupBox2.Controls.Add(this.account_TypeComboBox);
            this.groupBox2.Location = new System.Drawing.Point(155, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(782, 64);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter Credentials";
            // 
            // title_IDTextBox
            // 
            this.title_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.account_Title_InfoBindingSource, "Title_ID", true));
            this.title_IDTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_IDTextBox.Location = new System.Drawing.Point(72, 22);
            this.title_IDTextBox.Name = "title_IDTextBox";
            this.title_IDTextBox.Size = new System.Drawing.Size(114, 29);
            this.title_IDTextBox.TabIndex = 1;
            // 
            // account_Title_InfoBindingSource
            // 
            this.account_Title_InfoBindingSource.DataMember = "Account_Title_Info";
            this.account_Title_InfoBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // account_TitleTextBox
            // 
            this.account_TitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.account_Title_InfoBindingSource, "Account_Title", true));
            this.account_TitleTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account_TitleTextBox.Location = new System.Drawing.Point(300, 22);
            this.account_TitleTextBox.Name = "account_TitleTextBox";
            this.account_TitleTextBox.Size = new System.Drawing.Size(171, 29);
            this.account_TitleTextBox.TabIndex = 3;
            // 
            // account_TypeComboBox
            // 
            this.account_TypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.account_Title_InfoBindingSource, "Account_Type", true));
            this.account_TypeComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account_TypeComboBox.FormattingEnabled = true;
            this.account_TypeComboBox.Items.AddRange(new object[] {
            "Revenue",
            "Cost of Goods Sold",
            "Operating expense",
            "Other Income",
            "Other Expense",
            "Taxes",
            "Current Assets",
            "Fixed Assets",
            "Investments",
            "Intangible Assets",
            "Current liability",
            "Shareholders Equity"});
            this.account_TypeComboBox.Location = new System.Drawing.Point(588, 22);
            this.account_TypeComboBox.Name = "account_TypeComboBox";
            this.account_TypeComboBox.Size = new System.Drawing.Size(187, 29);
            this.account_TypeComboBox.TabIndex = 5;
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
            this.groupBox1.Location = new System.Drawing.Point(16, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 389);
            this.groupBox1.TabIndex = 11;
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
            this.btnlast.Location = new System.Drawing.Point(6, 337);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(120, 36);
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
            this.btnprevious.Location = new System.Drawing.Point(7, 295);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(120, 36);
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
            this.btnnext.Location = new System.Drawing.Point(7, 253);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(120, 36);
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
            this.btnfirst.Location = new System.Drawing.Point(7, 211);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(120, 36);
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
            this.btndelete.Location = new System.Drawing.Point(7, 154);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(120, 36);
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
            this.btnedit.Size = new System.Drawing.Size(120, 36);
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
            this.btnsave.Location = new System.Drawing.Point(7, 70);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(120, 36);
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
            this.btnadd.Location = new System.Drawing.Point(7, 28);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(120, 36);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "NEW RECORD";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // account_Title_InfoTableAdapter
            // 
            this.account_Title_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Account_Title_InfoTableAdapter = this.account_Title_InfoTableAdapter;
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
            this.tableAdapterManager.Purchase_Pay_InfoTableAdapter = null;
            this.tableAdapterManager.Sale_LogTableAdapter = null;
            this.tableAdapterManager.SaleSummaryProcedureTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = POS_GEN.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User_InfoTableAdapter = null;
            this.tableAdapterManager.Vendor_InfoTableAdapter = null;
            // 
            // account_Title_InfoDataGridView
            // 
            this.account_Title_InfoDataGridView.AllowUserToAddRows = false;
            this.account_Title_InfoDataGridView.AllowUserToDeleteRows = false;
            this.account_Title_InfoDataGridView.AutoGenerateColumns = false;
            this.account_Title_InfoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.account_Title_InfoDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.account_Title_InfoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.account_Title_InfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.account_Title_InfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.account_Title_InfoDataGridView.DataSource = this.account_Title_InfoBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.account_Title_InfoDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.account_Title_InfoDataGridView.Location = new System.Drawing.Point(155, 122);
            this.account_Title_InfoDataGridView.Name = "account_Title_InfoDataGridView";
            this.account_Title_InfoDataGridView.ReadOnly = true;
            this.account_Title_InfoDataGridView.Size = new System.Drawing.Size(782, 319);
            this.account_Title_InfoDataGridView.TabIndex = 12;
            this.account_Title_InfoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.account_Title_InfoDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Title_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Title_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Account_Title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Account_Title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Account_Type";
            this.dataGridViewTextBoxColumn3.HeaderText = "Account_Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // AccountTitleReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(946, 456);
            this.Controls.Add(this.account_Title_InfoDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountTitleReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountTitleReg";
            this.Load += new System.EventHandler(this.AccountTitleReg_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.account_Title_InfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.account_Title_InfoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button btnprevious;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnadd;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource account_Title_InfoBindingSource;
        private DataSet1TableAdapters.Account_Title_InfoTableAdapter account_Title_InfoTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox title_IDTextBox;
        private System.Windows.Forms.TextBox account_TitleTextBox;
        private System.Windows.Forms.ComboBox account_TypeComboBox;
        private System.Windows.Forms.DataGridView account_Title_InfoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}