namespace POS_GEN
{
    partial class ProductReg
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
            System.Windows.Forms.Label product_IDLabel;
            System.Windows.Forms.Label product_CodeLabel;
            System.Windows.Forms.Label product_NameLabel;
            System.Windows.Forms.Label discountLabel;
            System.Windows.Forms.Label sale_PriceLabel;
            System.Windows.Forms.Label category_IDLabel;
            System.Windows.Forms.Label prod_ImageLabel;
            System.Windows.Forms.Label warehouseLabel;
            System.Windows.Forms.Label barcodeLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnclose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.barcodeTextBox = new System.Windows.Forms.TextBox();
            this.product_InfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new POS_GEN.DataSet1();
            this.cmbcategory = new System.Windows.Forms.ComboBox();
            this.categoryInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnupload = new System.Windows.Forms.Button();
            this.product_IDTextBox = new System.Windows.Forms.TextBox();
            this.product_CodeTextBox = new System.Windows.Forms.TextBox();
            this.product_NameTextBox = new System.Windows.Forms.TextBox();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.sale_PriceTextBox = new System.Windows.Forms.TextBox();
            this.prod_ImagePictureBox = new System.Windows.Forms.PictureBox();
            this.warehouseComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.product_InfoTableAdapter = new POS_GEN.DataSet1TableAdapters.Product_InfoTableAdapter();
            this.tableAdapterManager = new POS_GEN.DataSet1TableAdapters.TableAdapterManager();
            this.category_InfoTableAdapter = new POS_GEN.DataSet1TableAdapters.Category_InfoTableAdapter();
            this.product_InfoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            product_IDLabel = new System.Windows.Forms.Label();
            product_CodeLabel = new System.Windows.Forms.Label();
            product_NameLabel = new System.Windows.Forms.Label();
            discountLabel = new System.Windows.Forms.Label();
            sale_PriceLabel = new System.Windows.Forms.Label();
            category_IDLabel = new System.Windows.Forms.Label();
            prod_ImageLabel = new System.Windows.Forms.Label();
            warehouseLabel = new System.Windows.Forms.Label();
            barcodeLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_InfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prod_ImagePictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_InfoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // product_IDLabel
            // 
            product_IDLabel.AutoSize = true;
            product_IDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            product_IDLabel.Location = new System.Drawing.Point(7, 28);
            product_IDLabel.Name = "product_IDLabel";
            product_IDLabel.Size = new System.Drawing.Size(86, 21);
            product_IDLabel.TabIndex = 0;
            product_IDLabel.Text = "Product ID:";
            // 
            // product_CodeLabel
            // 
            product_CodeLabel.AutoSize = true;
            product_CodeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            product_CodeLabel.Location = new System.Drawing.Point(7, 62);
            product_CodeLabel.Name = "product_CodeLabel";
            product_CodeLabel.Size = new System.Drawing.Size(107, 21);
            product_CodeLabel.TabIndex = 2;
            product_CodeLabel.Text = "Product Code:";
            // 
            // product_NameLabel
            // 
            product_NameLabel.AutoSize = true;
            product_NameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            product_NameLabel.Location = new System.Drawing.Point(7, 97);
            product_NameLabel.Name = "product_NameLabel";
            product_NameLabel.Size = new System.Drawing.Size(113, 21);
            product_NameLabel.TabIndex = 4;
            product_NameLabel.Text = "Product Name:";
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            discountLabel.Location = new System.Drawing.Point(7, 389);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new System.Drawing.Size(74, 21);
            discountLabel.TabIndex = 6;
            discountLabel.Text = "Discount:";
            // 
            // sale_PriceLabel
            // 
            sale_PriceLabel.AutoSize = true;
            sale_PriceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sale_PriceLabel.Location = new System.Drawing.Point(7, 131);
            sale_PriceLabel.Name = "sale_PriceLabel";
            sale_PriceLabel.Size = new System.Drawing.Size(80, 21);
            sale_PriceLabel.TabIndex = 8;
            sale_PriceLabel.Text = "Sale Price:";
            // 
            // category_IDLabel
            // 
            category_IDLabel.AutoSize = true;
            category_IDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            category_IDLabel.Location = new System.Drawing.Point(7, 165);
            category_IDLabel.Name = "category_IDLabel";
            category_IDLabel.Size = new System.Drawing.Size(76, 21);
            category_IDLabel.TabIndex = 10;
            category_IDLabel.Text = "Category:";
            // 
            // prod_ImageLabel
            // 
            prod_ImageLabel.AutoSize = true;
            prod_ImageLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prod_ImageLabel.Location = new System.Drawing.Point(7, 198);
            prod_ImageLabel.Name = "prod_ImageLabel";
            prod_ImageLabel.Size = new System.Drawing.Size(93, 21);
            prod_ImageLabel.TabIndex = 12;
            prod_ImageLabel.Text = "Prod Image:";
            // 
            // warehouseLabel
            // 
            warehouseLabel.AutoSize = true;
            warehouseLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            warehouseLabel.Location = new System.Drawing.Point(384, 18);
            warehouseLabel.Name = "warehouseLabel";
            warehouseLabel.Size = new System.Drawing.Size(93, 21);
            warehouseLabel.TabIndex = 15;
            warehouseLabel.Text = "Available In:";
            warehouseLabel.Visible = false;
            // 
            // barcodeLabel
            // 
            barcodeLabel.AutoSize = true;
            barcodeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            barcodeLabel.Location = new System.Drawing.Point(7, 354);
            barcodeLabel.Name = "barcodeLabel";
            barcodeLabel.Size = new System.Drawing.Size(69, 21);
            barcodeLabel.TabIndex = 17;
            barcodeLabel.Text = "Barcode:";
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(8)))), ((int)(((byte)(58)))));
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(890, 12);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(28, 27);
            this.btnclose.TabIndex = 11;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(8)))), ((int)(((byte)(58)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 502);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(930, 4);
            this.panel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(8)))), ((int)(((byte)(58)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 4);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(8)))), ((int)(((byte)(58)))));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "PRODUCT REGISTRATION PANEL";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(barcodeLabel);
            this.groupBox2.Controls.Add(this.barcodeTextBox);
            this.groupBox2.Controls.Add(this.cmbcategory);
            this.groupBox2.Controls.Add(this.btnupload);
            this.groupBox2.Controls.Add(product_IDLabel);
            this.groupBox2.Controls.Add(this.product_IDTextBox);
            this.groupBox2.Controls.Add(product_CodeLabel);
            this.groupBox2.Controls.Add(this.discountTextBox);
            this.groupBox2.Controls.Add(this.product_CodeTextBox);
            this.groupBox2.Controls.Add(discountLabel);
            this.groupBox2.Controls.Add(product_NameLabel);
            this.groupBox2.Controls.Add(this.product_NameTextBox);
            this.groupBox2.Controls.Add(sale_PriceLabel);
            this.groupBox2.Controls.Add(this.sale_PriceTextBox);
            this.groupBox2.Controls.Add(category_IDLabel);
            this.groupBox2.Controls.Add(prod_ImageLabel);
            this.groupBox2.Controls.Add(this.prod_ImagePictureBox);
            this.groupBox2.Location = new System.Drawing.Point(155, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 442);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter Credentials";
            // 
            // barcodeTextBox
            // 
            this.barcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.product_InfoBindingSource, "Barcode", true));
            this.barcodeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeTextBox.Location = new System.Drawing.Point(126, 351);
            this.barcodeTextBox.Name = "barcodeTextBox";
            this.barcodeTextBox.Size = new System.Drawing.Size(146, 29);
            this.barcodeTextBox.TabIndex = 18;
            this.barcodeTextBox.Text = "0";
            // 
            // product_InfoBindingSource
            // 
            this.product_InfoBindingSource.DataMember = "Product_Info";
            this.product_InfoBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbcategory
            // 
            this.cmbcategory.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.product_InfoBindingSource, "Category_ID", true));
            this.cmbcategory.DataSource = this.categoryInfoBindingSource;
            this.cmbcategory.DisplayMember = "Category_Name";
            this.cmbcategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcategory.FormattingEnabled = true;
            this.cmbcategory.Location = new System.Drawing.Point(126, 163);
            this.cmbcategory.Name = "cmbcategory";
            this.cmbcategory.Size = new System.Drawing.Size(146, 29);
            this.cmbcategory.TabIndex = 14;
            this.cmbcategory.ValueMember = "Category_ID";
            // 
            // categoryInfoBindingSource
            // 
            this.categoryInfoBindingSource.DataMember = "Category_Info";
            this.categoryInfoBindingSource.DataSource = this.dataSet1;
            // 
            // btnupload
            // 
            this.btnupload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnupload.FlatAppearance.BorderSize = 0;
            this.btnupload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupload.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupload.ForeColor = System.Drawing.Color.White;
            this.btnupload.Location = new System.Drawing.Point(126, 291);
            this.btnupload.Name = "btnupload";
            this.btnupload.Size = new System.Drawing.Size(146, 35);
            this.btnupload.TabIndex = 4;
            this.btnupload.Text = "UPLOAD";
            this.btnupload.UseVisualStyleBackColor = false;
            this.btnupload.Click += new System.EventHandler(this.btnupload_Click);
            // 
            // product_IDTextBox
            // 
            this.product_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.product_InfoBindingSource, "Product_ID", true));
            this.product_IDTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_IDTextBox.Location = new System.Drawing.Point(126, 25);
            this.product_IDTextBox.Name = "product_IDTextBox";
            this.product_IDTextBox.Size = new System.Drawing.Size(146, 29);
            this.product_IDTextBox.TabIndex = 1;
            // 
            // product_CodeTextBox
            // 
            this.product_CodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.product_InfoBindingSource, "Product_Code", true));
            this.product_CodeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_CodeTextBox.Location = new System.Drawing.Point(126, 59);
            this.product_CodeTextBox.Name = "product_CodeTextBox";
            this.product_CodeTextBox.Size = new System.Drawing.Size(146, 29);
            this.product_CodeTextBox.TabIndex = 3;
            this.product_CodeTextBox.Text = "0";
            // 
            // product_NameTextBox
            // 
            this.product_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.product_InfoBindingSource, "Product_Name", true));
            this.product_NameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_NameTextBox.Location = new System.Drawing.Point(126, 94);
            this.product_NameTextBox.Name = "product_NameTextBox";
            this.product_NameTextBox.Size = new System.Drawing.Size(146, 29);
            this.product_NameTextBox.TabIndex = 5;
            // 
            // discountTextBox
            // 
            this.discountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.product_InfoBindingSource, "Discount", true));
            this.discountTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountTextBox.Location = new System.Drawing.Point(126, 386);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(146, 29);
            this.discountTextBox.TabIndex = 7;
            this.discountTextBox.Text = "0";
            // 
            // sale_PriceTextBox
            // 
            this.sale_PriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.product_InfoBindingSource, "Sale_Price", true));
            this.sale_PriceTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sale_PriceTextBox.Location = new System.Drawing.Point(126, 128);
            this.sale_PriceTextBox.Name = "sale_PriceTextBox";
            this.sale_PriceTextBox.Size = new System.Drawing.Size(146, 29);
            this.sale_PriceTextBox.TabIndex = 9;
            // 
            // prod_ImagePictureBox
            // 
            this.prod_ImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prod_ImagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.product_InfoBindingSource, "Prod_Image", true));
            this.prod_ImagePictureBox.Location = new System.Drawing.Point(126, 198);
            this.prod_ImagePictureBox.Name = "prod_ImagePictureBox";
            this.prod_ImagePictureBox.Size = new System.Drawing.Size(146, 87);
            this.prod_ImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prod_ImagePictureBox.TabIndex = 13;
            this.prod_ImagePictureBox.TabStop = false;
            // 
            // warehouseComboBox
            // 
            this.warehouseComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.product_InfoBindingSource, "Warehouse", true));
            this.warehouseComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseComboBox.FormattingEnabled = true;
            this.warehouseComboBox.Items.AddRange(new object[] {
            "Shop",
            "Ware House"});
            this.warehouseComboBox.Location = new System.Drawing.Point(501, 15);
            this.warehouseComboBox.Name = "warehouseComboBox";
            this.warehouseComboBox.Size = new System.Drawing.Size(146, 29);
            this.warehouseComboBox.TabIndex = 16;
            this.warehouseComboBox.Text = "-";
            this.warehouseComboBox.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.btnedit);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Location = new System.Drawing.Point(16, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 442);
            this.groupBox1.TabIndex = 13;
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
            this.btndelete.Location = new System.Drawing.Point(6, 142);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(120, 32);
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
            this.btnedit.Location = new System.Drawing.Point(7, 104);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(120, 32);
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
            this.btnsave.Location = new System.Drawing.Point(7, 66);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(120, 32);
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
            this.btnadd.Size = new System.Drawing.Size(120, 32);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "NEW RECORD";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // product_InfoTableAdapter
            // 
            this.product_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Account_Title_InfoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Category_InfoTableAdapter = null;
            this.tableAdapterManager.CustomerInfoTableAdapter = null;
            this.tableAdapterManager.Expense_InfoTableAdapter = null;
            this.tableAdapterManager.LedgerProcedureTableAdapter = null;
            this.tableAdapterManager.PNLPurchaseTableAdapter = null;
            this.tableAdapterManager.PNLSaleTableAdapter = null;
            this.tableAdapterManager.POS_InfoTableAdapter = null;
            this.tableAdapterManager.Pos_Pay_InfoTableAdapter = null;
            this.tableAdapterManager.Product_InfoTableAdapter = this.product_InfoTableAdapter;
            this.tableAdapterManager.Purchase_InfoTableAdapter = null;
            this.tableAdapterManager.Purchase_LogTableAdapter = null;
            this.tableAdapterManager.Purchase_Pay_InfoTableAdapter = null;
            this.tableAdapterManager.Sale_LogTableAdapter = null;
            this.tableAdapterManager.SaleSummaryProcedureTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = POS_GEN.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User_InfoTableAdapter = null;
            this.tableAdapterManager.Vendor_InfoTableAdapter = null;
            // 
            // category_InfoTableAdapter
            // 
            this.category_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // product_InfoDataGridView
            // 
            this.product_InfoDataGridView.AllowUserToAddRows = false;
            this.product_InfoDataGridView.AllowUserToDeleteRows = false;
            this.product_InfoDataGridView.AutoGenerateColumns = false;
            this.product_InfoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.product_InfoDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.product_InfoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.product_InfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_InfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.product_InfoDataGridView.DataSource = this.product_InfoBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.product_InfoDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.product_InfoDataGridView.Location = new System.Drawing.Point(439, 57);
            this.product_InfoDataGridView.Name = "product_InfoDataGridView";
            this.product_InfoDataGridView.ReadOnly = true;
            this.product_InfoDataGridView.Size = new System.Drawing.Size(479, 436);
            this.product_InfoDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Product_Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 129;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Product_Code";
            this.dataGridViewTextBoxColumn2.HeaderText = "Product Code";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 124;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Barcode";
            this.dataGridViewTextBoxColumn1.HeaderText = "Barcode";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 89;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Discount";
            this.dataGridViewTextBoxColumn4.HeaderText = "Discount";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 92;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Sale_Price";
            this.dataGridViewTextBoxColumn5.HeaderText = "Sale Price";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 98;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Prod_Image";
            this.dataGridViewImageColumn1.HeaderText = "Prod_Image";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 94;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Product_ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "Product_ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 106;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Category_ID";
            this.dataGridViewTextBoxColumn7.HeaderText = "Category_ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 115;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(11, 332);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(261, 100);
            this.panel3.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(7, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "CANCEL";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 506);
            this.Controls.Add(this.product_InfoDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(warehouseLabel);
            this.Controls.Add(this.warehouseComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ProductReg_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_InfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prod_ImagePictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.product_InfoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnadd;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource product_InfoBindingSource;
        private DataSet1TableAdapters.Product_InfoTableAdapter product_InfoTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnupload;
        private System.Windows.Forms.TextBox product_IDTextBox;
        private System.Windows.Forms.TextBox product_CodeTextBox;
        private System.Windows.Forms.TextBox product_NameTextBox;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.TextBox sale_PriceTextBox;
        private System.Windows.Forms.PictureBox prod_ImagePictureBox;
        private System.Windows.Forms.ComboBox cmbcategory;
        private System.Windows.Forms.BindingSource categoryInfoBindingSource;
        private DataSet1TableAdapters.Category_InfoTableAdapter category_InfoTableAdapter;
        private System.Windows.Forms.DataGridView product_InfoDataGridView;
        private System.Windows.Forms.ComboBox warehouseComboBox;
        private System.Windows.Forms.TextBox barcodeTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
    }
}

